using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ytdlpgui
{
    public partial class ytdlpgui : Form
    {
        private static string dwnPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\ytdlpgui";
        private static string ytdlp = AppDomain.CurrentDomain.BaseDirectory+"\\ytdlp\\ytdlp.exe";

        public ytdlpgui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(dwnPath))
            {
                Directory.CreateDirectory(dwnPath);
            }
            qualityCombo.SelectedIndex = 0;
        }

        private void updateytdlpButton_Click(object sender, EventArgs e)
        {
            Process ytupd = new Process();
            ytupd.StartInfo.FileName = "cmd.exe";
            ytupd.StartInfo.Arguments = "/K "+ ytdlp + " -U";
            ytupd.Start();
        }

        private void videoButton_Click(object sender, EventArgs e)
        {

            if (qualityCombo.SelectedItem.ToString() == "Best available")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_bestquality.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "2160p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=2160]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_2160p.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "1440p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=1440]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_1440p.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "1080p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=1080]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_1080p.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "720p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=720]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_720p.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "480p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=480]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_480p.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "360p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=360]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_360p.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "240p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=240]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_240p.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedItem.ToString() == "144p")
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height=144]+ba --merge-output-format mp4 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s_144p.%(ext)s";
                video.Start();
            }
        }

        private void audioButton_Click(object sender, EventArgs e)
        {
            Process audio = new Process();
            audio.StartInfo.FileName = "cmd.exe";
            audio.StartInfo.Arguments = "/K " + ytdlp + " -f ba -x --audio-format mp3 " + linkBox.Text + " -o " + dwnPath + "\\%(title)s.%(ext)s";
            audio.Start();
        }

        private void downloadsButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dwnPath);
        }
    }
}