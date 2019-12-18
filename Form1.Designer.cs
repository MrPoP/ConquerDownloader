namespace Downloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gamenamelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.savedis = new System.Windows.Forms.TextBox();
            this.browssave = new System.Windows.Forms.Button();
            this.browsinstall = new System.Windows.Forms.Button();
            this.installdis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.downlbl = new System.Windows.Forms.LinkLabel();
            this.downloadstart = new System.Windows.Forms.Button();
            this.installbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Downloader.Properties.Resources.Capturepic;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 185);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(549, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Downloaded:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game name:";
            // 
            // gamenamelbl
            // 
            this.gamenamelbl.AutoSize = true;
            this.gamenamelbl.Location = new System.Drawing.Point(113, 248);
            this.gamenamelbl.Name = "gamenamelbl";
            this.gamenamelbl.Size = new System.Drawing.Size(100, 13);
            this.gamenamelbl.TabIndex = 5;
            this.gamenamelbl.Text = "Conquer_0000.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Save folder:";
            // 
            // savedis
            // 
            this.savedis.Location = new System.Drawing.Point(116, 273);
            this.savedis.Name = "savedis";
            this.savedis.Size = new System.Drawing.Size(402, 20);
            this.savedis.TabIndex = 7;
            // 
            // browssave
            // 
            this.browssave.Location = new System.Drawing.Point(524, 271);
            this.browssave.Name = "browssave";
            this.browssave.Size = new System.Drawing.Size(33, 23);
            this.browssave.TabIndex = 8;
            this.browssave.Text = "...";
            this.browssave.UseVisualStyleBackColor = true;
            this.browssave.Click += new System.EventHandler(this.browssave_Click);
            // 
            // browsinstall
            // 
            this.browsinstall.Location = new System.Drawing.Point(524, 299);
            this.browsinstall.Name = "browsinstall";
            this.browsinstall.Size = new System.Drawing.Size(33, 23);
            this.browsinstall.TabIndex = 11;
            this.browsinstall.Text = "...";
            this.browsinstall.UseVisualStyleBackColor = true;
            this.browsinstall.Click += new System.EventHandler(this.browsinstall_Click);
            // 
            // installdis
            // 
            this.installdis.Location = new System.Drawing.Point(116, 301);
            this.installdis.Name = "installdis";
            this.installdis.Size = new System.Drawing.Size(402, 20);
            this.installdis.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Install folder:";
            // 
            // downlbl
            // 
            this.downlbl.AutoSize = true;
            this.downlbl.Location = new System.Drawing.Point(12, 342);
            this.downlbl.Name = "downlbl";
            this.downlbl.Size = new System.Drawing.Size(81, 13);
            this.downlbl.TabIndex = 12;
            this.downlbl.TabStop = true;
            this.downlbl.Text = "Download page";
            this.downlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.downlbl_LinkClicked);
            // 
            // downloadstart
            // 
            this.downloadstart.Location = new System.Drawing.Point(193, 337);
            this.downloadstart.Name = "downloadstart";
            this.downloadstart.Size = new System.Drawing.Size(113, 23);
            this.downloadstart.TabIndex = 13;
            this.downloadstart.Text = "Download Now!";
            this.downloadstart.UseVisualStyleBackColor = true;
            this.downloadstart.Click += new System.EventHandler(this.downloadstart_Click);
            // 
            // installbtn
            // 
            this.installbtn.Location = new System.Drawing.Point(312, 337);
            this.installbtn.Name = "installbtn";
            this.installbtn.Size = new System.Drawing.Size(113, 23);
            this.installbtn.TabIndex = 14;
            this.installbtn.Text = "Install";
            this.installbtn.UseVisualStyleBackColor = true;
            this.installbtn.Click += new System.EventHandler(this.installbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(430, 337);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(113, 23);
            this.stopbtn.TabIndex = 15;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Location = new System.Drawing.Point(113, 221);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(63, 13);
            this.Percent.TabIndex = 16;
            this.Percent.Text = "0 MB / 0 MB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estimated time:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(336, 221);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(51, 13);
            this.Time.TabIndex = 18;
            this.Time.Text = "00:00:00";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(452, 221);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(78, 13);
            this.Speed.TabIndex = 19;
            this.Speed.Text = "Speed : 0 KB/S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 374);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.installbtn);
            this.Controls.Add(this.downloadstart);
            this.Controls.Add(this.downlbl);
            this.Controls.Add(this.browsinstall);
            this.Controls.Add(this.installdis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.browssave);
            this.Controls.Add(this.savedis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gamenamelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conquer[0000]";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gamenamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox savedis;
        private System.Windows.Forms.Button browssave;
        private System.Windows.Forms.Button browsinstall;
        private System.Windows.Forms.TextBox installdis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel downlbl;
        private System.Windows.Forms.Button downloadstart;
        private System.Windows.Forms.Button installbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Speed;
    }
}

