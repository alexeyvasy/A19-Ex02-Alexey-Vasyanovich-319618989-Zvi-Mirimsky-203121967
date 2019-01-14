namespace FacebookApp
{
    partial class FacebookPlayerForm
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
            this.allSongsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addToPlayListButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.SongsPlayer = new SongPlayerController();
            this.SuspendLayout();
            // 
            // allSongsListBox
            // 
            this.allSongsListBox.FormattingEnabled = true;
            this.allSongsListBox.Location = new System.Drawing.Point(12, 59);
            this.allSongsListBox.Name = "allSongsListBox";
            this.allSongsListBox.Size = new System.Drawing.Size(163, 251);
            this.allSongsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Songs:";
            // 
            // playListBox
            // 
            this.playListBox.FormattingEnabled = true;
            this.playListBox.Location = new System.Drawing.Point(203, 59);
            this.playListBox.Name = "playListBox";
            this.playListBox.Size = new System.Drawing.Size(184, 251);
            this.playListBox.TabIndex = 2;
            this.playListBox.SelectedIndexChanged += new System.EventHandler(this.playListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Play List:";
            // 
            // addToPlayListButton
            // 
            this.addToPlayListButton.Location = new System.Drawing.Point(15, 316);
            this.addToPlayListButton.Name = "addToPlayListButton";
            this.addToPlayListButton.Size = new System.Drawing.Size(160, 23);
            this.addToPlayListButton.TabIndex = 4;
            this.addToPlayListButton.Text = "Add To Playlist";
            this.addToPlayListButton.UseVisualStyleBackColor = true;
            this.addToPlayListButton.Click += new System.EventHandler(this.addToPlayListButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.Location = new System.Drawing.Point(203, 316);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(184, 23);
            this.EraseButton.TabIndex = 5;
            this.EraseButton.Text = "Erase Song";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Visible = false;
            this.EraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // SongsPlayer
            // 
            this.SongsPlayer.Location = new System.Drawing.Point(393, 4);
            this.SongsPlayer.Name = "SongsPlayer";
            this.SongsPlayer.Size = new System.Drawing.Size(632, 433);
            this.SongsPlayer.TabIndex = 6;
            this.SongsPlayer.Visible = false;
            // 
            // FacebookPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 449);
            this.Controls.Add(this.SongsPlayer);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.addToPlayListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allSongsListBox);
            this.Name = "FacebookPlayerForm";
            this.Text = "FacebookPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allSongsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToPlayListButton;
        private System.Windows.Forms.Button EraseButton;
        private SongPlayerController SongsPlayer;
    }
}