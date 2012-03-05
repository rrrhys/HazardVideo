namespace Hazard_Video
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
            this.log = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addHazard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstHazards = new System.Windows.Forms.ListBox();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.lHazardIndicator = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hazard_guessed
            // 
            this.hazard_guessed.AutoSize = true;
            this.hazard_guessed.Location = new System.Drawing.Point(17, 8);
            this.hazard_guessed.Name = "hazard_guessed";
            this.hazard_guessed.Size = new System.Drawing.Size(41, 13);
            this.hazard_guessed.TabIndex = 4;
            this.hazard_guessed.Text = "Hazard";
            this.hazard_guessed.Click += new System.EventHandler(this.label2_Click);
            // 
            // log
            // 
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(21, 207);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(182, 82);
            this.log.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hazard Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(286, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Hazard End";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // addHazard
            // 
            this.addHazard.Location = new System.Drawing.Point(392, 246);
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
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 15;
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(200, 100);
            this.wmp.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hazard_guessed);
            this.panel2.Location = new System.Drawing.Point(33, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 34);
            this.panel2.TabIndex = 2;
            // 
            // lstHazards
            // 
            this.lstHazards.FormattingEnabled = true;
            this.lstHazards.Location = new System.Drawing.Point(473, 187);
            this.lstHazards.Name = "lstHazards";
            this.lstHazards.Size = new System.Drawing.Size(120, 95);
            this.lstHazards.TabIndex = 13;
            // 
            // lstVideos
            // 
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.Location = new System.Drawing.Point(473, 71);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(120, 95);
            this.lstVideos.TabIndex = 14;
            this.lstVideos.SelectedIndexChanged += new System.EventHandler(this.lstVideos_SelectedIndexChanged);
            // 
            // lHazardIndicator
            // 
            this.lHazardIndicator.AutoSize = true;
            this.lHazardIndicator.Location = new System.Drawing.Point(470, 45);
            this.lHazardIndicator.Name = "lHazardIndicator";
            this.lHazardIndicator.Size = new System.Drawing.Size(35, 13);
            this.lHazardIndicator.TabIndex = 16;
            this.lHazardIndicator.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 301);
            this.Controls.Add(this.lHazardIndicator);
            this.Controls.Add(this.lstVideos);
            this.Controls.Add(this.lstHazards);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addHazard);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hazard_guessed;
        private System.Windows.Forms.ListBox log;
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
    }
}

