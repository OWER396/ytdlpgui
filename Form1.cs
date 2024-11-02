using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ytdlpgui
{
    public partial class ytdlpgui : Form
    {
        private static readonly string ytdlp = AppDomain.CurrentDomain.BaseDirectory+"\\ytdlp\\ytdlp.exe";
        private static readonly string config = AppDomain.CurrentDomain.BaseDirectory + "\\config.json";
        private static readonly string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ytdlpgui";
        private string dwnPath;

        public ytdlpgui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);

            if (!File.Exists(config))
            {
                var newConfig = new Config()
                {
                    dwnPath = defaultPath,
                    quality = 0,
                    video = 4,
                    audio = 4
                };

                var newConfigJson = JsonConvert.SerializeObject(newConfig);

                using (StreamWriter json = new StreamWriter(config))
                {
                    json.WriteLine(newConfigJson.ToString());
                }
            }

            var configFile = JsonConvert.DeserializeObject<Config>(File.ReadAllText(config));

            if(String.IsNullOrEmpty(configFile.dwnPath))
            {
                dwnPath = defaultPath;
            }
            else
            {
                dwnPath = configFile.dwnPath;
            }

            if(!Directory.Exists(configFile.dwnPath) && !String.IsNullOrEmpty(configFile.dwnPath))
            {
                Directory.CreateDirectory(configFile.dwnPath);
            }
            qualityCombo.SelectedIndex = configFile.quality;
            videoFormatCombo.SelectedIndex = configFile.video;
            audioFormatCombo.SelectedIndex = configFile.audio;
        }

        public string ExtractNumber(string original)
        {
            return new string(original.Where(c => Char.IsDigit(c)).ToArray());
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
            if (qualityCombo.SelectedIndex == 0 && !nonYoutubeFlag.Checked)
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv+ba --merge-output-format " + videoFormatCombo.SelectedItem.ToString() + " " + linkBox.Text + " -o " + '"' + dwnPath + '"' + "\\%(title)s_bestquality.%(ext)s";
                video.Start();
            }

            if (qualityCombo.SelectedIndex >= 1 && !nonYoutubeFlag.Checked)
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " -f bv[height="+ExtractNumber(qualityCombo.SelectedItem.ToString())+"]+ba --merge-output-format " + videoFormatCombo.SelectedItem.ToString() + " " + linkBox.Text + " -o " + '"' + dwnPath + '"' + "\\%(title)s_" + qualityCombo.SelectedItem.ToString()+".%(ext)s";
                video.Start();
            }

            if(nonYoutubeFlag.Checked)
            {
                Process video = new Process();
                video.StartInfo.FileName = "cmd.exe";
                video.StartInfo.Arguments = "/K " + ytdlp + " --remux-video " + videoFormatCombo.SelectedItem.ToString() + " " + linkBox.Text + " -o " + '"' + dwnPath + '"' + "\\%(title)s.%(ext)s";
                video.Start();
            }
        }

        private void audioButton_Click(object sender, EventArgs e)
        {
            if(!nonYoutubeFlag.Checked)
            {
                Process audio = new Process();
                audio.StartInfo.FileName = "cmd.exe";
                audio.StartInfo.Arguments = "/K " + ytdlp + " -f ba -x --audio-format "+audioFormatCombo.SelectedItem.ToString()+ " " + linkBox.Text + " -o " + '"' + dwnPath + '"' + "\\%(title)s.%(ext)s";
                audio.Start();
            }else
            {
                Process audio = new Process();
                audio.StartInfo.FileName = "cmd.exe";
                audio.StartInfo.Arguments = "/K " + ytdlp + " -x --audio-format " + audioFormatCombo.SelectedItem.ToString() + " " + linkBox.Text + " -o " + +'"' + dwnPath + '"' + "\\%(title)s.%(ext)s";
                audio.Start();
            }
        }

        private void downloadsButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dwnPath);
        }


        private void downloadpath_Click(object sender, EventArgs e)
        {

            using(var path = new FolderBrowserDialog())
            {
                DialogResult result = path.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrEmpty(path.SelectedPath))
                {
                    dwnPath = path.SelectedPath;
                }
            }
        }

        private void nonYoutubeFlag_CheckedChanged(object sender, EventArgs e)
        {
            qualityCombo.Enabled = !nonYoutubeFlag.Checked;
        }

        private void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            var savedConfig = new Config()
            {
                dwnPath = dwnPath,
                quality = qualityCombo.SelectedIndex,
                video = videoFormatCombo.SelectedIndex,
                audio = audioFormatCombo.SelectedIndex
            };

            var configJson = JsonConvert.SerializeObject(savedConfig);

            using (StreamWriter json = new StreamWriter(config))
            {
                json.WriteLine(configJson.ToString());
            }

        }

    }

    public class Config
    {
        public string dwnPath { get; set; }
        public int quality { get; set; }
        public int video { get; set; }
        public int audio { get; set; }
    }
}