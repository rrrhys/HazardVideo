using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Media;
using Microsoft.VisualBasic;
namespace Hazard_Video
{
    public partial class Form1 : Form
    {
        public enum test_type
        {
            real_test, fake_score_high, fake_score_low
        }
        public List<Hazard_video> hazard_videos = new List<Hazard_video>();
        public string definition_file = "definitions/state.json";
        public Hazard_video current_video = null;
        public Hazard_test current_hazard_test = null;
        public Hazard_test_question current_hazard_test_question = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Dock = DockStyle.Fill;
            pNextQuestion.Dock = DockStyle.Fill;
            pNextQuestion.Visible = false;
            pre_test_detail_panel.Dock = DockStyle.Fill;
            pTestFinished.Dock = DockStyle.Fill;
            panel1.Visible = false;
            wmp.uiMode = "none";
            tTimeSittingExam.Text = DateTime.Now.ToString();
            load_state();
            load_videos_ui();
            load_test_state();
           // wmp.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(movie_tick);

              }

        private void load_test_state()
        {
            if (File.Exists("definitions/test_state.json"))
            {
                using (StreamReader sr = new StreamReader("definitions/test_state.json"))
                {
                    string state = sr.ReadToEnd();
                    current_hazard_test = Newtonsoft.Json.JsonConvert.DeserializeObject<Hazard_test>(state);
                    continue_test();
                }
            }
        }

        private void load_state()
        {
            //throw new NotImplementedException();
            if (!File.Exists(definition_file))
            {
                hazard_videos = new List<Hazard_video>();
                find_videos_and_add();
            }
            else
            {
                using (StreamReader sr = new StreamReader(definition_file))
                {
                    string state = sr.ReadToEnd();
                    hazard_videos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Hazard_video>>(state);
                }
                if (hazard_videos.Count == 0)
                {
                    find_videos_and_add();
                }
            }
        }

        private void find_videos_and_add()
        {
            if (!Directory.Exists("videos/"))
            {
                Directory.CreateDirectory("videos/");
            }
            foreach (string v in Directory.GetFiles("videos/", "*.avi"))
            {
                Hazard_video h = new Hazard_video();
                h.filename = v;
                if (!video_exists(h))
                {
                    hazard_videos.Add(h);
                }
            }
            foreach (string v in Directory.GetFiles("videos/", "*.mp4"))
            {
                Hazard_video h = new Hazard_video();
                h.filename = v;
                if (!video_exists(h))
                {
                    hazard_videos.Add(h);
                }
            }
            save_state();
        }

        private bool video_exists(Hazard_video h_new)
        {
            foreach (Hazard_video h in hazard_videos)
            {
                if (h.filename == h_new.filename)
                {
                    return true;
                }
            }
            return false;
        }

        void save_state()
        {
            if (!Directory.Exists("definitions/"))
            {
                Directory.CreateDirectory("definitions/");
            }
            using (StreamWriter sw = new StreamWriter(definition_file))
            {
                sw.Write(Newtonsoft.Json.JsonConvert.SerializeObject(hazard_videos));
            }
        }
        void movie_tick()
        {
            if(is_hazard(wmp.Ctlcontrols.currentPosition)){
                lHazardIndicator.BackColor = Color.Red;
            }
                else
                {
                    lHazardIndicator.BackColor = Color.Green;
                }
        }

        private void load_videos_ui()
        {
            lstVideos.Items.Clear();
            foreach (Hazard_video h in hazard_videos)
            {
                lstVideos.Items.Add(h.filename);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //wmp.Ctlcontrols.pause();
            hazard_guessed_attempt(wmp.Ctlcontrols.currentPosition);
        }



        private void hazard_guessed_attempt(double video_time)
        {
            if (current_hazard_test_question != null)
            {
                
                current_hazard_test_question.clicks_recorded.Add(video_time);
                play_click();
                
            }
            if (is_hazard(video_time))
            {
                
                log("Hazard guessed correctly at: " + video_time.ToString());
            }
            else
            {
                log("Hazard guessed incorrectly at: " + video_time.ToString());
            }
            

        }

        private void play_click()
        {
            wmp_click.URL = "click.mp3";
        }
        private bool is_hazard(double video_time)
        {
            if (current_video != null)
            {
                foreach (Hazard h in current_video.hazards)
                {
                    if (video_time > h.hazard_start && video_time < h.hazard_end)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void begin_video()
        {
            panel1.Visible = true;
            pre_test_detail_panel.Visible = false;
            timer1.Enabled = true;
            load_hazards();
            log("Begin Video: " + current_video.filename);
            wmp.uiMode = "Full";
            wmp.URL = current_video.filename;
            wmp.Ctlcontrols.play();
            wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmp_PlayStateChange);
        }

        void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
                
                if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
                {
                    log("Video Playing");
                }
 
                else if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
                {
                    log("Player Stopped");
                    timer1.Enabled = false;
                    if (current_hazard_test_question != null)
                    {
                        current_hazard_test_question.finished = true;
                    
                    
                    panel1.Visible = false;
                    pNextQuestion.Visible = true;
                    }
                    save_state();

                }

                else
                {
                   //log.Items.Add("New Play state: " + e.newState);
                }
        }

        private void log(string p)
        {
            llog.Items.Insert(0,p);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = wmp.Ctlcontrols.currentPosition.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = wmp.Ctlcontrols.currentPosition.ToString();
        }

        private void addHazard_Click(object sender, EventArgs e)
        {
            try
            {
                Hazard h = new Hazard();
                h.hazard_start = double.Parse(textBox1.Text);
                h.hazard_end = double.Parse(textBox2.Text);
              
                current_video.hazards.Add(h);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start and end must be a point in the video. This hazard was not added.");
            }
            load_hazards();
        }
       
        private void load_hazards()
        {
            lstHazards.Items.Clear();
            foreach (Hazard h in current_video.hazards)
            {
                lstHazards.Items.Add(h.hazard_start + " - " + h.hazard_end);
            }
        }

        private void lstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideos.SelectedIndex >= 0)
            {
                current_video = null;
                foreach (Hazard_video h in hazard_videos)
                {
                    if (h.filename == lstVideos.SelectedItem.ToString())
                    {
                        current_video = h;
                        begin_video();
                        load_hazards();
                    }
                }
                if (current_video == null)
                {
                    throw new Exception("Chosen video not loaded.");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movie_tick();
        }

        private void hazard_guessed_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Red;
        }

        private void hazard_guessed_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.HotTrack;
        }

        private void panel6_Resize(object sender, EventArgs e)
        {
            bBeginTest.Left = panel6.Width/2 - bBeginTest.Width / 2;
        }

        private void bBeginTest_Click(object sender, EventArgs e)
        {
            current_hazard_test = new Hazard_test();
            current_hazard_test.candidate_name = tCandidateName.Text;
            current_hazard_test.time_started = DateTime.Now;
            if (rSetA.Checked)
            {
                current_hazard_test.test_type = test_type.real_test;
            }
            else if (rSetB.Checked)
            {
                current_hazard_test.test_type = test_type.fake_score_high;
            }
            else if (rSetC.Checked)
            {
                current_hazard_test.test_type = test_type.fake_score_low;
            }
            foreach (Hazard_video h in hazard_videos)
            {
                Hazard_test_question q = new Hazard_test_question();
                q.video = h;
                
                current_hazard_test.hazard_test_questions.Add(q);
                current_hazard_test.hazard_test_questions.Sort(delegate(Hazard_test_question h1, Hazard_test_question h2) { return h1.ordering_key.CompareTo(h2.ordering_key); });
            }
            save_test_state();
            pre_test_detail_panel.Visible = false;
            panel1.Visible = true;
            continue_test();
        }

        private void continue_test()
        {
            wmp.uiMode = "None";
            foreach (Hazard_test_question q in current_hazard_test.hazard_test_questions)
            {
                if (q.finished == false)
                {
                    current_hazard_test_question = q;
                    current_video = q.video;
                    load_hazards();
                    wmp.URL = q.video.filename;
                    wmp.stretchToFit = true;
                    panel1.Visible = true;
                    pNextQuestion.Visible = false;
                    timer1.Enabled = true;
                    return;
                }
            }
            do_test_finished();
        }

        private void do_test_finished()
        {
            current_hazard_test.time_finished = DateTime.Now;
            pNextQuestion.Visible = false;
            pTestFinished.Visible = true;
            int actual_score = 0;
            int report_score = 0;
            //generate score.
            foreach (Hazard_test_question hq in current_hazard_test.hazard_test_questions)
            {
                if (hq.Question_passed)
                {
                    actual_score += 1;
                }
                report_score = actual_score;
            }
            if (current_hazard_test.test_type == test_type.fake_score_high)
            {
                report_score = current_hazard_test.hazard_test_questions.Count - 1;
            }
            if (current_hazard_test.test_type == test_type.fake_score_low)
            {
                report_score = 2;
            }
            string report_filename = "definitions/scores.csv";
            if (!File.Exists(report_filename))
            {
                using (StreamWriter sw = new StreamWriter(report_filename, true, Encoding.Default))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5}", "Candidate Name", "Test Started", "Test Finished", "Actual Score", "Reported Score", "Test Conducted");
                }
            }
            using (StreamWriter sw = new StreamWriter(report_filename,true,Encoding.Default))
            {
                sw.WriteLine("{0},{1},{2},{3},{4},{5}", current_hazard_test.candidate_name, current_hazard_test.time_started.ToString(), current_hazard_test.time_finished.ToString(), actual_score, report_score,current_hazard_test.test_type.ToString());
            }
            File.Delete("definitions/test_state.json");
            lScore.Text = report_score.ToString() + "/" +  current_hazard_test.hazard_test_questions.Count;
        }

        private void save_test_state()
        {
            using (StreamWriter sw = new StreamWriter("definitions/test_state.json"))
            {
                sw.Write(Newtonsoft.Json.JsonConvert.SerializeObject(current_hazard_test));
            }
        }
            #region classes
        public class Hazard_test_question
        {
            public Hazard_test_question()
            {
                this.ordering_key = Guid.NewGuid().ToString();
            }
            public Hazard_video video;
            public DateTime time_started;
            public DateTime time_finished;
            public bool finished = false;
            public List<double> clicks_recorded = new List<double>();
            public string ordering_key;
            public bool Question_passed
            {
                get
                {
                    foreach (double click in clicks_recorded)
                    {
                        foreach (Hazard h in video.hazards)
                        {
                            if (h.hazard_start < click && h.hazard_end > click)
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                set
                {

                }
            }
        }
        public class Hazard_test
        {
            public string candidate_name;
            public DateTime time_started;
            public DateTime time_finished;
            public List<Hazard_test_question> hazard_test_questions = new List<Hazard_test_question>();
            public test_type test_type;

        }
        public class Hazard_video
        {
            public List<Hazard> hazards = new List<Hazard>();
            public string filename;
        }
        public class Hazard
        {
            public double hazard_start;
            public double hazard_end;
        }
        #endregion

        private void bNextQuestion_Click(object sender, EventArgs e)
        {
            continue_test();
        }

        private void wmp_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            hazard_guessed_attempt(wmp.Ctlcontrols.currentPosition);
        }

        private void bDeleteHazard_Click(object sender, EventArgs e)
        {
            current_video.hazards.RemoveAt(lstHazards.SelectedIndex);
        }

        private void lstHazards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHazards.SelectedIndex > -1)
            {
                bDeleteHazard.Enabled = true;
            }
            else
            {
                bDeleteHazard.Enabled = false;
            }
        }

        private void bAddNewVideos_Click(object sender, EventArgs e)
        {
            find_videos_and_add();
        }

        private void rAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bShowAdmin_Click(object sender, EventArgs e)
        {
            if (bShowAdmin.Text == "Show Admin")
            {
                if ("wyburd" == Interaction.InputBox("Password key?").ToLower())
                {
                    panel3.Visible = true;
                    bShowAdmin.Text = "Hide Admin";
                }
            }
            else
            {
                panel3.Visible = false;
                bShowAdmin.Text = "Show Admin";
            }
        }

    }
}
