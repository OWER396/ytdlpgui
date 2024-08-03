namespace ytdlpgui
{
    partial class ytdlpgui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ytdlpgui));
            this.linkBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.qualityCombo = new System.Windows.Forms.ComboBox();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.audioButton = new System.Windows.Forms.Button();
            this.videoButton = new System.Windows.Forms.Button();
            this.updateytdlpButton = new System.Windows.Forms.Button();
            this.downloadsButton = new System.Windows.Forms.Button();
            this.downloadpath = new System.Windows.Forms.Button();
            this.videoFormatText = new System.Windows.Forms.Label();
            this.videoFormatCombo = new System.Windows.Forms.ComboBox();
            this.audioFormatText = new System.Windows.Forms.Label();
            this.audioFormatCombo = new System.Windows.Forms.ComboBox();
            this.nonYoutubeFlag = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // linkBox
            // 
            this.linkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.linkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkBox.ForeColor = System.Drawing.Color.White;
            this.linkBox.Location = new System.Drawing.Point(12, 26);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(280, 20);
            this.linkBox.TabIndex = 2;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkLabel.ForeColor = System.Drawing.Color.White;
            this.linkLabel.Location = new System.Drawing.Point(12, 10);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(30, 13);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.Text = "Link:";
            // 
            // qualityCombo
            // 
            this.qualityCombo.AllowDrop = true;
            this.qualityCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.qualityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qualityCombo.ForeColor = System.Drawing.Color.White;
            this.qualityCombo.FormattingEnabled = true;
            this.qualityCombo.Items.AddRange(new object[] {
            "Best available",
            "2160p",
            "1440p",
            "1080p",
            "720p",
            "480p",
            "360p",
            "240p",
            "144p"});
            this.qualityCombo.Location = new System.Drawing.Point(12, 65);
            this.qualityCombo.MaxLength = 10;
            this.qualityCombo.Name = "qualityCombo";
            this.qualityCombo.Size = new System.Drawing.Size(280, 21);
            this.qualityCombo.TabIndex = 4;
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qualityLabel.ForeColor = System.Drawing.Color.White;
            this.qualityLabel.Location = new System.Drawing.Point(12, 49);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(42, 13);
            this.qualityLabel.TabIndex = 5;
            this.qualityLabel.Text = "Quality:";
            // 
            // audioButton
            // 
            this.audioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioButton.ForeColor = System.Drawing.Color.White;
            this.audioButton.Location = new System.Drawing.Point(12, 181);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(133, 30);
            this.audioButton.TabIndex = 6;
            this.audioButton.Text = "Download Audio";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
            // 
            // videoButton
            // 
            this.videoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoButton.ForeColor = System.Drawing.Color.White;
            this.videoButton.Location = new System.Drawing.Point(159, 181);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(133, 30);
            this.videoButton.TabIndex = 7;
            this.videoButton.Text = "Download Video";
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // updateytdlpButton
            // 
            this.updateytdlpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateytdlpButton.ForeColor = System.Drawing.Color.White;
            this.updateytdlpButton.Location = new System.Drawing.Point(12, 221);
            this.updateytdlpButton.Name = "updateytdlpButton";
            this.updateytdlpButton.Size = new System.Drawing.Size(133, 30);
            this.updateytdlpButton.TabIndex = 8;
            this.updateytdlpButton.Text = "Update YTDLP";
            this.updateytdlpButton.UseVisualStyleBackColor = true;
            this.updateytdlpButton.Click += new System.EventHandler(this.updateytdlpButton_Click);
            // 
            // downloadsButton
            // 
            this.downloadsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadsButton.ForeColor = System.Drawing.Color.White;
            this.downloadsButton.Location = new System.Drawing.Point(159, 221);
            this.downloadsButton.Name = "downloadsButton";
            this.downloadsButton.Size = new System.Drawing.Size(133, 30);
            this.downloadsButton.TabIndex = 9;
            this.downloadsButton.Text = "Open downloads";
            this.downloadsButton.UseVisualStyleBackColor = true;
            this.downloadsButton.Click += new System.EventHandler(this.downloadsButton_Click);
            // 
            // downloadpath
            // 
            this.downloadpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadpath.ForeColor = System.Drawing.Color.White;
            this.downloadpath.Location = new System.Drawing.Point(12, 261);
            this.downloadpath.Name = "downloadpath";
            this.downloadpath.Size = new System.Drawing.Size(280, 30);
            this.downloadpath.TabIndex = 10;
            this.downloadpath.Text = "Change download path";
            this.downloadpath.UseVisualStyleBackColor = true;
            this.downloadpath.Click += new System.EventHandler(this.downloadpath_Click);
            // 
            // videoFormatText
            // 
            this.videoFormatText.AutoSize = true;
            this.videoFormatText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoFormatText.ForeColor = System.Drawing.Color.White;
            this.videoFormatText.Location = new System.Drawing.Point(12, 90);
            this.videoFormatText.Name = "videoFormatText";
            this.videoFormatText.Size = new System.Drawing.Size(72, 13);
            this.videoFormatText.TabIndex = 12;
            this.videoFormatText.Text = "Video Format:";
            // 
            // videoFormatCombo
            // 
            this.videoFormatCombo.AllowDrop = true;
            this.videoFormatCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.videoFormatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoFormatCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoFormatCombo.ForeColor = System.Drawing.Color.White;
            this.videoFormatCombo.FormattingEnabled = true;
            this.videoFormatCombo.Items.AddRange(new object[] {
            "avi",
            "flv",
            "mkv",
            "mov",
            "mp4",
            "webm"});
            this.videoFormatCombo.Location = new System.Drawing.Point(12, 106);
            this.videoFormatCombo.MaxLength = 10;
            this.videoFormatCombo.Name = "videoFormatCombo";
            this.videoFormatCombo.Size = new System.Drawing.Size(280, 21);
            this.videoFormatCombo.TabIndex = 11;
            // 
            // audioFormatText
            // 
            this.audioFormatText.AutoSize = true;
            this.audioFormatText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioFormatText.ForeColor = System.Drawing.Color.White;
            this.audioFormatText.Location = new System.Drawing.Point(12, 131);
            this.audioFormatText.Name = "audioFormatText";
            this.audioFormatText.Size = new System.Drawing.Size(72, 13);
            this.audioFormatText.TabIndex = 14;
            this.audioFormatText.Text = "Audio Format:";
            // 
            // audioFormatCombo
            // 
            this.audioFormatCombo.AllowDrop = true;
            this.audioFormatCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.audioFormatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioFormatCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioFormatCombo.ForeColor = System.Drawing.Color.White;
            this.audioFormatCombo.FormattingEnabled = true;
            this.audioFormatCombo.Items.AddRange(new object[] {
            "aac",
            "alac",
            "flac",
            "m4a",
            "mp3",
            "opus",
            "vorbis",
            "wav"});
            this.audioFormatCombo.Location = new System.Drawing.Point(12, 147);
            this.audioFormatCombo.MaxLength = 10;
            this.audioFormatCombo.Name = "audioFormatCombo";
            this.audioFormatCombo.Size = new System.Drawing.Size(280, 21);
            this.audioFormatCombo.TabIndex = 13;
            // 
            // nonYoutubeFlag
            // 
            this.nonYoutubeFlag.AutoSize = true;
            this.nonYoutubeFlag.ForeColor = System.Drawing.Color.White;
            this.nonYoutubeFlag.Location = new System.Drawing.Point(95, 301);
            this.nonYoutubeFlag.Name = "nonYoutubeFlag";
            this.nonYoutubeFlag.Size = new System.Drawing.Size(116, 17);
            this.nonYoutubeFlag.TabIndex = 15;
            this.nonYoutubeFlag.Text = "Non-youtube mode";
            this.nonYoutubeFlag.UseVisualStyleBackColor = true;
            this.nonYoutubeFlag.CheckedChanged += new System.EventHandler(this.nonYoutubeFlag_CheckedChanged);
            // 
            // ytdlpgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(304, 325);
            this.Controls.Add(this.nonYoutubeFlag);
            this.Controls.Add(this.audioFormatText);
            this.Controls.Add(this.audioFormatCombo);
            this.Controls.Add(this.videoFormatText);
            this.Controls.Add(this.videoFormatCombo);
            this.Controls.Add(this.downloadpath);
            this.Controls.Add(this.downloadsButton);
            this.Controls.Add(this.updateytdlpButton);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.audioButton);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.qualityCombo);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.linkBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 364);
            this.MinimumSize = new System.Drawing.Size(320, 364);
            this.Name = "ytdlpgui";
            this.Text = "ytdlpgui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.ComboBox qualityCombo;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Button audioButton;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Button updateytdlpButton;
        private System.Windows.Forms.Button downloadsButton;
        private System.Windows.Forms.Button downloadpath;
        private System.Windows.Forms.Label videoFormatText;
        private System.Windows.Forms.ComboBox videoFormatCombo;
        private System.Windows.Forms.Label audioFormatText;
        private System.Windows.Forms.ComboBox audioFormatCombo;
        private System.Windows.Forms.CheckBox nonYoutubeFlag;
    }
}

