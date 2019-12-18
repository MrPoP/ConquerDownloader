using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader
{
    public partial class Form1 : Form
    {
        DownloadProgressTracker tracker;
        public WebClient client;
        private bool GigaBytes = false;
        public Form1()
        {
            InitializeComponent();
            installbtn.Enabled = false;
            stopbtn.Enabled = false;
            tracker = new DownloadProgressTracker(5000, TimeSpan.FromMilliseconds(500));
            savedis.Text = Environment.CurrentDirectory + "\\" + Properties.Settings.Default.Name;
            installdis.Text = System.IO.Path.GetPathRoot(Environment.SystemDirectory) +"Program Files (x86)\\zf\\";
            Text = Properties.Settings.Default.GameName + "[" + Properties.Settings.Default.Version + "]";
            gamenamelbl.Text = Properties.Settings.Default.Name;
            downlbl.Text = Properties.Settings.Default.DownloadLbl;
            downlbl.Links.Add(new LinkLabel.Link() { LinkData = Properties.Settings.Default.DownloadLink });
            client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void downloadstart_Click(object sender, EventArgs e)
        {
            downloadstart.Enabled = false;
            stopbtn.Enabled = true;
            installbtn.Enabled = false;
            installdis.Enabled = false;
            savedis.Enabled = false;
            browssave.Enabled = false;
            browsinstall.Enabled = false;
            client.DownloadFileAsync(new Uri(Properties.Settings.Default.FileLink), savedis.Text);
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            downloadstart.Enabled = true;
            stopbtn.Enabled = false;
            installbtn.Enabled = false;
            installdis.Enabled = true;
            savedis.Enabled = true;
            browssave.Enabled = true;
            browsinstall.Enabled = true;
            client.CancelAsync();
            tracker.NewFile();
            Speed.Text = "Speed : 0 KB/S";
            Time.Text = "00:00:00";
        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            string file = savedis.Text;
            if (File.Exists(file))
            {
                Process.Start(file);
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            GigaBytes = (e.TotalBytesToReceive / 1024 / 1024) >= 1024;
            tracker.SetProgress(e.BytesReceived, e.TotalBytesToReceive);
            progressBar1.Value = (int)(tracker.GetProgress() * 100);
            Time.Text = tracker.TimeStamp();
            if (GigaBytes)
                Percent.Text = Math.Round(((double)(e.BytesReceived / 1024.0 / 1024.0 / 1024.0)), 3) + " GB / " + Math.Round(((double)(e.TotalBytesToReceive / 1024.0 / 1024.0 / 1024.0)), 3) + " GB";
            else
                Percent.Text = string.Format("{0} MB / {1} MB", Math.Round((double)(e.BytesReceived / 1024.0 / 1024.0), 2), Math.Round((double)(e.TotalBytesToReceive / 1024.0 / 1024.0), 2));
            Speed.Text = string.Format("Speed: {0}", tracker.GetBytesPerSecondString());
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if ((tracker.GetProgress()  * 100.0) != 100.0)
            {
                stopbtn.Enabled = false;
                MessageBox.Show("Download Stopped.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                installbtn.Enabled = true;
                stopbtn.Enabled = true;
                MessageBox.Show("Download Completed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void browssave_Click(object sender, EventArgs e)
        {
            if (browssave.Enabled == false)
                return;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    savedis.Text = fbd.SelectedPath + "\\" + Properties.Settings.Default.Name;
                }
            }
        }

        private void browsinstall_Click(object sender, EventArgs e)
        {
            if (browsinstall.Enabled == false)
                return;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    installdis.Text = fbd.SelectedPath;
                }
            }
        }

        private void downlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(Properties.Settings.Default.DownloadLink);
            }
            catch
            {
            }
        }
    }
}
