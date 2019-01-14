namespace FacebookApp
{
    partial class SongPlayerController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongPlayerController));
            this.mediaPlayer = new System.Windows.Forms.WebBrowser();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.switchToVideoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.likePictureBox = new System.Windows.Forms.PictureBox();
            this.commentPictureBox = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.LikesNumberLabel = new System.Windows.Forms.Label();
            this.CommentsNumberLable = new System.Windows.Forms.Label();
            this.uploadDateLable = new System.Windows.Forms.Label();
            this.switchToAudioButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.likePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Location = new System.Drawing.Point(3, 58);
            this.mediaPlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.Size = new System.Drawing.Size(593, 297);
            this.mediaPlayer.TabIndex = 0;
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNameLabel.Location = new System.Drawing.Point(12, 13);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(107, 25);
            this.songNameLabel.TabIndex = 1;
            this.songNameLabel.Text = "Song Name";
            // 
            // switchToVideoButton
            // 
            this.switchToVideoButton.Location = new System.Drawing.Point(17, 387);
            this.switchToVideoButton.Name = "switchToVideoButton";
            this.switchToVideoButton.Size = new System.Drawing.Size(117, 23);
            this.switchToVideoButton.TabIndex = 2;
            this.switchToVideoButton.Text = "Switch to Video";
            this.switchToVideoButton.UseVisualStyleBackColor = true;
            this.switchToVideoButton.Visible = false;
            this.switchToVideoButton.Click += new System.EventHandler(this.switchToVideoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "uploaded:";
            // 
            // likePictureBox
            // 
            this.likePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.likePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("likePictureBox.BackgroundImage")));
            this.likePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likePictureBox.Location = new System.Drawing.Point(483, 375);
            this.likePictureBox.Name = "likePictureBox";
            this.likePictureBox.Size = new System.Drawing.Size(35, 35);
            this.likePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likePictureBox.TabIndex = 29;
            this.likePictureBox.TabStop = false;
            // 
            // commentPictureBox
            // 
            this.commentPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.commentPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commentPictureBox.BackgroundImage")));
            this.commentPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commentPictureBox.Location = new System.Drawing.Point(547, 375);
            this.commentPictureBox.Name = "commentPictureBox";
            this.commentPictureBox.Size = new System.Drawing.Size(35, 35);
            this.commentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentPictureBox.TabIndex = 30;
            this.commentPictureBox.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Location = new System.Drawing.Point(529, 13);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(35, 34);
            this.restartButton.TabIndex = 41;
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(570, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.TabIndex = 42;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LikesNumberLabel
            // 
            this.LikesNumberLabel.AutoSize = true;
            this.LikesNumberLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LikesNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.LikesNumberLabel.Location = new System.Drawing.Point(500, 375);
            this.LikesNumberLabel.Name = "LikesNumberLabel";
            this.LikesNumberLabel.Size = new System.Drawing.Size(41, 13);
            this.LikesNumberLabel.TabIndex = 43;
            this.LikesNumberLabel.Text = "label4";
            // 
            // CommentsNumberLable
            // 
            this.CommentsNumberLable.AutoSize = true;
            this.CommentsNumberLable.BackColor = System.Drawing.Color.Transparent;
            this.CommentsNumberLable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CommentsNumberLable.ForeColor = System.Drawing.Color.Black;
            this.CommentsNumberLable.Location = new System.Drawing.Point(555, 375);
            this.CommentsNumberLable.Name = "CommentsNumberLable";
            this.CommentsNumberLable.Size = new System.Drawing.Size(41, 13);
            this.CommentsNumberLable.TabIndex = 44;
            this.CommentsNumberLable.Text = "label2";
            // 
            // uploadDateLable
            // 
            this.uploadDateLable.AutoSize = true;
            this.uploadDateLable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uploadDateLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadDateLable.Location = new System.Drawing.Point(359, 392);
            this.uploadDateLable.Name = "uploadDateLable";
            this.uploadDateLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uploadDateLable.Size = new System.Drawing.Size(35, 13);
            this.uploadDateLable.TabIndex = 45;
            this.uploadDateLable.Text = "label3";
            this.uploadDateLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // switchToAudioButton
            // 
            this.switchToAudioButton.Location = new System.Drawing.Point(17, 364);
            this.switchToAudioButton.Name = "switchToAudioButton";
            this.switchToAudioButton.Size = new System.Drawing.Size(117, 23);
            this.switchToAudioButton.TabIndex = 46;
            this.switchToAudioButton.Text = "Switch to Audio";
            this.switchToAudioButton.UseVisualStyleBackColor = true;
            this.switchToAudioButton.Click += new System.EventHandler(this.switchToAudioButton_Click);
            // 
            // SongPlayerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.switchToAudioButton);
            this.Controls.Add(this.uploadDateLable);
            this.Controls.Add(this.CommentsNumberLable);
            this.Controls.Add(this.LikesNumberLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.commentPictureBox);
            this.Controls.Add(this.likePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchToVideoButton);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.mediaPlayer);
            this.Name = "SongPlayerController";
            this.Size = new System.Drawing.Size(632, 433);
            ((System.ComponentModel.ISupportInitialize)(this.likePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser mediaPlayer;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Button switchToVideoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox likePictureBox;
        private System.Windows.Forms.PictureBox commentPictureBox;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label LikesNumberLabel;
        private System.Windows.Forms.Label CommentsNumberLable;
        private System.Windows.Forms.Label uploadDateLable;
        private System.Windows.Forms.Button switchToAudioButton;
    }
}
