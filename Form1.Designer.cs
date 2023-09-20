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
            this.SuspendLayout();
            // 
            // linkBox
            // 
            this.linkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.linkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkBox.ForeColor = System.Drawing.Color.White;
            this.linkBox.Location = new System.Drawing.Point(12, 25);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(280, 20);
            this.linkBox.TabIndex = 2;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkLabel.ForeColor = System.Drawing.Color.White;
            this.linkLabel.Location = new System.Drawing.Point(12, 9);
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
            this.qualityCombo.Location = new System.Drawing.Point(12, 64);
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
            this.qualityLabel.Location = new System.Drawing.Point(12, 48);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(42, 13);
            this.qualityLabel.TabIndex = 5;
            this.qualityLabel.Text = "Quality:";
            // 
            // audioButton
            // 
            this.audioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioButton.ForeColor = System.Drawing.Color.White;
            this.audioButton.Location = new System.Drawing.Point(12, 101);
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
            this.videoButton.Location = new System.Drawing.Point(159, 101);
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
            this.updateytdlpButton.Location = new System.Drawing.Point(12, 141);
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
            this.downloadsButton.Location = new System.Drawing.Point(159, 141);
            this.downloadsButton.Name = "downloadsButton";
            this.downloadsButton.Size = new System.Drawing.Size(133, 30);
            this.downloadsButton.TabIndex = 9;
            this.downloadsButton.Text = "Open downloads";
            this.downloadsButton.UseVisualStyleBackColor = true;
            this.downloadsButton.Click += new System.EventHandler(this.downloadsButton_Click);
            // 
            // ytdlpgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(304, 183);
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
    }
}

