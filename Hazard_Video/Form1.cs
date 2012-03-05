﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Converters;
using System.IO;
namespace Hazard_Video
{
    public partial class Form1 : Form
    {
        public List<Hazard_video> hazard_videos = new List<Hazard_video>();
        public Hazard_video current_video = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmp.uiMode = "none";

            load_state();
            load_videos_ui();
            
           // wmp.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(movie_tick);
              }

        private void load_state()
        {
            //throw new NotImplementedException();
            using (StreamReader sr = new StreamReader("state.json"))
            {
                string state = sr.ReadToEnd();
                hazard_videos = Newtonsoft.Json.JsonConvert.DeserializeObject < List<Hazard_video>>(state);
            }
        }

        void save_state()
        {
            using (StreamWriter sw = new StreamWriter("state.json"))
            {
                sw.Write(Newtonsoft.Json.JsonConvert.SerializeObject(hazard_videos));
            }
        }
        void movie_tick()
        {
            foreach (Hazard h in current_video.hazards)
            {
                if (wmp.Ctlcontrols.currentPosition > h.hazard_start && wmp.Ctlcontrols.currentPosition < h.hazard_end)
                {
                    lHazardIndicator.BackColor = Color.Red;
                }
                else
                {
                    lHazardIndicator.BackColor = Color.Green;
                }
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
            log.Items.Add("Hazard guessed at: " + video_time.ToString());
        }
        private void begin_video()
        {
            timer1.Enabled = true;
            load_hazards();
            log.Items.Add("Begin Video: " + current_video.filename);
            wmp.URL = "definitions/" + current_video.filename;
            wmp.Ctlcontrols.play();
            wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmp_PlayStateChange);
        }

        void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
                
                if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
                {
                    log.Items.Add("Video Playing");
                }
                else if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    log.Items.Add("Video Ended");
                }
                else if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
                {
                    log.Items.Add("Player Stopped");
                    timer1.Enabled = false;
                    save_state();
                }
                else
                {
                    log.Items.Add("New Play state: " + e.newState);
                }
        }
        public class Hazard_video
        {
            public List<Hazard> hazards = new List<Hazard>();
            public string filename;
        }
        public class Hazard{
            public double hazard_start;
            public double hazard_end;
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

    }
}
