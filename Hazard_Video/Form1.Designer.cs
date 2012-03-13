﻿namespace Hazard_Video
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
           
            save_state();
            this.Visible = false;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hazard_guessed = new System.Windows.Forms.Label();
            this.llog = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addHazard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bShowAdmin = new System.Windows.Forms.Button();
            this.wmp_click = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstHazards = new System.Windows.Forms.ListBox();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.lHazardIndicator = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bAddNewVideos = new System.Windows.Forms.Button();
            this.bDeleteHazard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pre_test_detail_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rSetC = new System.Windows.Forms.RadioButton();
            this.rSetB = new System.Windows.Forms.RadioButton();
            this.rSetA = new System.Windows.Forms.RadioButton();
            this.tCandidateName = new System.Windows.Forms.TextBox();
            this.tTimeSittingExam = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bBeginTest = new System.Windows.Forms.Button();
            this.pNextQuestion = new System.Windows.Forms.Panel();
            this.bNextQuestion = new System.Windows.Forms.Button();
            this.pTestFinished = new System.Windows.Forms.Panel();
            this.lScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_click)).BeginInit();
            this.panel3.SuspendLayout();
            this.pre_test_detail_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pNextQuestion.SuspendLayout();
            this.pTestFinished.SuspendLayout();
            this.SuspendLayout();
            // 
            // hazard_guessed
            // 
            this.hazard_guessed.AutoSize = true;
            this.hazard_guessed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hazard_guessed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hazard_guessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hazard_guessed.ForeColor = System.Drawing.Color.Black;
            this.hazard_guessed.Location = new System.Drawing.Point(17, 8);
            this.hazard_guessed.Name = "hazard_guessed";
            this.hazard_guessed.Size = new System.Drawing.Size(87, 25);
            this.hazard_guessed.TabIndex = 4;
            this.hazard_guessed.Text = "Hazard";
            this.hazard_guessed.Click += new System.EventHandler(this.label2_Click);
            this.hazard_guessed.MouseEnter += new System.EventHandler(this.hazard_guessed_MouseEnter);
            this.hazard_guessed.MouseLeave += new System.EventHandler(this.hazard_guessed_MouseLeave);
            // 
            // llog
            // 
            this.llog.FormattingEnabled = true;
            this.llog.Location = new System.Drawing.Point(16, 356);
            this.llog.Name = "llog";
            this.llog.Size = new System.Drawing.Size(172, 82);
            this.llog.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start >";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "End >";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 10;
            // 
            // addHazard
            // 
            this.addHazard.Location = new System.Drawing.Point(93, 204);
            this.addHazard.Name = "addHazard";
            this.addHazard.Size = new System.Drawing.Size(75, 23);
            this.addHazard.TabIndex = 11;
            this.addHazard.Text = "Add Hazard";
            this.addHazard.UseVisualStyleBackColor = true;
            this.addHazard.Click += new System.EventHandler(this.addHazard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wmp);
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 211);
            this.panel1.TabIndex = 15;
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(191, 211);
            this.wmp.TabIndex = 0;
            this.wmp.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.wmp_ClickEvent);
            this.wmp.MouseUpEvent += new AxWMPLib._WMPOCXEvents_MouseUpEventHandler(this.wmp_MouseUpEvent);
            this.wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmp_PlayStateChange);
            this.wmp.Enter += new System.EventHandler(this.wmp_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.wmp_click);
            this.panel2.Controls.Add(this.hazard_guessed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 43);
            this.panel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bShowAdmin);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(358, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(83, 43);
            this.panel7.TabIndex = 21;
            // 
            // bShowAdmin
            // 
            this.bShowAdmin.Location = new System.Drawing.Point(3, 8);
            this.bShowAdmin.Name = "bShowAdmin";
            this.bShowAdmin.Size = new System.Drawing.Size(75, 23);
            this.bShowAdmin.TabIndex = 20;
            this.bShowAdmin.Text = "Show Admin";
            this.bShowAdmin.UseVisualStyleBackColor = true;
            this.bShowAdmin.Click += new System.EventHandler(this.bShowAdmin_Click);
            // 
            // wmp_click
            // 
            this.wmp_click.Enabled = true;
            this.wmp_click.Location = new System.Drawing.Point(238, 14);
            this.wmp_click.Name = "wmp_click";
            this.wmp_click.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_click.OcxState")));
            this.wmp_click.Size = new System.Drawing.Size(75, 23);
            this.wmp_click.TabIndex = 19;
            this.wmp_click.Visible = false;
            // 
            // lstHazards
            // 
            this.lstHazards.FormattingEnabled = true;
            this.lstHazards.Location = new System.Drawing.Point(16, 251);
            this.lstHazards.Name = "lstHazards";
            this.lstHazards.Size = new System.Drawing.Size(169, 69);
            this.lstHazards.TabIndex = 13;
            this.lstHazards.SelectedIndexChanged += new System.EventHandler(this.lstHazards_SelectedIndexChanged);
            // 
            // lstVideos
            // 
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.Location = new System.Drawing.Point(16, 12);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(152, 82);
            this.lstVideos.TabIndex = 14;
            this.lstVideos.SelectedIndexChanged += new System.EventHandler(this.lstVideos_SelectedIndexChanged);
            // 
            // lHazardIndicator
            // 
            this.lHazardIndicator.AutoSize = true;
            this.lHazardIndicator.Location = new System.Drawing.Point(470, 45);
            this.lHazardIndicator.Name = "lHazardIndicator";
            this.lHazardIndicator.Size = new System.Drawing.Size(47, 13);
            this.lHazardIndicator.TabIndex = 16;
            this.lHazardIndicator.Text = "Hazard?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.bAddNewVideos);
            this.panel3.Controls.Add(this.bDeleteHazard);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lstVideos);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lstHazards);
            this.panel3.Controls.Add(this.llog);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.addHazard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(441, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 450);
            this.panel3.TabIndex = 17;
            this.panel3.Visible = false;
            // 
            // bAddNewVideos
            // 
            this.bAddNewVideos.Location = new System.Drawing.Point(93, 96);
            this.bAddNewVideos.Name = "bAddNewVideos";
            this.bAddNewVideos.Size = new System.Drawing.Size(75, 23);
            this.bAddNewVideos.TabIndex = 21;
            this.bAddNewVideos.Text = "Add new Videos";
            this.bAddNewVideos.UseVisualStyleBackColor = true;
            this.bAddNewVideos.Click += new System.EventHandler(this.bAddNewVideos_Click);
            // 
            // bDeleteHazard
            // 
            this.bDeleteHazard.Enabled = false;
            this.bDeleteHazard.Location = new System.Drawing.Point(110, 326);
            this.bDeleteHazard.Name = "bDeleteHazard";
            this.bDeleteHazard.Size = new System.Drawing.Size(75, 23);
            this.bDeleteHazard.TabIndex = 17;
            this.bDeleteHazard.Text = "Delete Hazard";
            this.bDeleteHazard.UseVisualStyleBackColor = true;
            this.bDeleteHazard.Click += new System.EventHandler(this.bDeleteHazard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Existing Hazards:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add a new Hazard:";
            // 
            // pre_test_detail_panel
            // 
            this.pre_test_detail_panel.Controls.Add(this.panel5);
            this.pre_test_detail_panel.Controls.Add(this.panel4);
            this.pre_test_detail_panel.Controls.Add(this.panel6);
            this.pre_test_detail_panel.Location = new System.Drawing.Point(238, 55);
            this.pre_test_detail_panel.Name = "pre_test_detail_panel";
            this.pre_test_detail_panel.Size = new System.Drawing.Size(152, 126);
            this.pre_test_detail_panel.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rSetC);
            this.panel5.Controls.Add(this.rSetB);
            this.panel5.Controls.Add(this.rSetA);
            this.panel5.Controls.Add(this.tCandidateName);
            this.panel5.Controls.Add(this.tTimeSittingExam);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(133, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 26);
            this.panel5.TabIndex = 6;
            // 
            // rSetC
            // 
            this.rSetC.AutoSize = true;
            this.rSetC.Location = new System.Drawing.Point(6, 137);
            this.rSetC.Name = "rSetC";
            this.rSetC.Size = new System.Drawing.Size(51, 17);
            this.rSetC.TabIndex = 7;
            this.rSetC.TabStop = true;
            this.rSetC.Text = "Set C";
            this.rSetC.UseVisualStyleBackColor = true;
            // 
            // rSetB
            // 
            this.rSetB.AutoSize = true;
            this.rSetB.Location = new System.Drawing.Point(6, 114);
            this.rSetB.Name = "rSetB";
            this.rSetB.Size = new System.Drawing.Size(51, 17);
            this.rSetB.TabIndex = 6;
            this.rSetB.TabStop = true;
            this.rSetB.Text = "Set B";
            this.rSetB.UseVisualStyleBackColor = true;
            // 
            // rSetA
            // 
            this.rSetA.AutoSize = true;
            this.rSetA.Location = new System.Drawing.Point(6, 91);
            this.rSetA.Name = "rSetA";
            this.rSetA.Size = new System.Drawing.Size(51, 17);
            this.rSetA.TabIndex = 5;
            this.rSetA.TabStop = true;
            this.rSetA.Text = "Set A";
            this.rSetA.UseVisualStyleBackColor = true;
            // 
            // tCandidateName
            // 
            this.tCandidateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCandidateName.Location = new System.Drawing.Point(6, 10);
            this.tCandidateName.Name = "tCandidateName";
            this.tCandidateName.Size = new System.Drawing.Size(200, 29);
            this.tCandidateName.TabIndex = 3;
            // 
            // tTimeSittingExam
            // 
            this.tTimeSittingExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTimeSittingExam.Location = new System.Drawing.Point(6, 49);
            this.tTimeSittingExam.Name = "tTimeSittingExam";
            this.tTimeSittingExam.Size = new System.Drawing.Size(200, 29);
            this.tTimeSittingExam.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 26);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Candidate Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time Sitting Exam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Question Set";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bBeginTest);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 100);
            this.panel6.TabIndex = 9;
            this.panel6.Resize += new System.EventHandler(this.panel6_Resize);
            // 
            // bBeginTest
            // 
            this.bBeginTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBeginTest.Location = new System.Drawing.Point(52, 26);
            this.bBeginTest.Name = "bBeginTest";
            this.bBeginTest.Size = new System.Drawing.Size(130, 42);
            this.bBeginTest.TabIndex = 7;
            this.bBeginTest.Text = "Begin Test";
            this.bBeginTest.UseVisualStyleBackColor = true;
            this.bBeginTest.Click += new System.EventHandler(this.bBeginTest_Click);
            // 
            // pNextQuestion
            // 
            this.pNextQuestion.Controls.Add(this.bNextQuestion);
            this.pNextQuestion.Location = new System.Drawing.Point(230, 338);
            this.pNextQuestion.Name = "pNextQuestion";
            this.pNextQuestion.Size = new System.Drawing.Size(200, 100);
            this.pNextQuestion.TabIndex = 8;
            this.pNextQuestion.Visible = false;
            // 
            // bNextQuestion
            // 
            this.bNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNextQuestion.Location = new System.Drawing.Point(46, 18);
            this.bNextQuestion.Name = "bNextQuestion";
            this.bNextQuestion.Size = new System.Drawing.Size(133, 69);
            this.bNextQuestion.TabIndex = 0;
            this.bNextQuestion.Text = "Next Question";
            this.bNextQuestion.UseVisualStyleBackColor = true;
            this.bNextQuestion.Click += new System.EventHandler(this.bNextQuestion_Click);
            // 
            // pTestFinished
            // 
            this.pTestFinished.Controls.Add(this.lScore);
            this.pTestFinished.Controls.Add(this.label8);
            this.pTestFinished.Controls.Add(this.label7);
            this.pTestFinished.Location = new System.Drawing.Point(32, 65);
            this.pTestFinished.Name = "pTestFinished";
            this.pTestFinished.Size = new System.Drawing.Size(200, 127);
            this.pTestFinished.TabIndex = 20;
            this.pTestFinished.Visible = false;
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Location = new System.Drawing.Point(58, 31);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(35, 13);
            this.lScore.TabIndex = 2;
            this.lScore.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "You finished the test!";
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.pTestFinished);
            this.Controls.Add(this.pNextQuestion);
            this.Controls.Add(this.pre_test_detail_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lHazardIndicator);
            this.Name = "Form1";
            this.Text = "Hazard Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp_click)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pre_test_detail_panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pNextQuestion.ResumeLayout(false);
            this.pTestFinished.ResumeLayout(false);
            this.pTestFinished.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hazard_guessed;
        private System.Windows.Forms.ListBox llog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addHazard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstHazards;
        private System.Windows.Forms.ListBox lstVideos;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Label lHazardIndicator;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pre_test_detail_panel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rSetB;
        private System.Windows.Forms.RadioButton rSetA;
        private System.Windows.Forms.TextBox tCandidateName;
        private System.Windows.Forms.TextBox tTimeSittingExam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bBeginTest;
        private System.Windows.Forms.Panel pNextQuestion;
        private System.Windows.Forms.Button bNextQuestion;
        private AxWMPLib.AxWindowsMediaPlayer wmp_click;
        private System.Windows.Forms.RadioButton rSetC;
        private System.Windows.Forms.Panel pTestFinished;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bDeleteHazard;
        private System.Windows.Forms.Button bAddNewVideos;
        private System.Windows.Forms.Button bShowAdmin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer timer2;
    }
}

