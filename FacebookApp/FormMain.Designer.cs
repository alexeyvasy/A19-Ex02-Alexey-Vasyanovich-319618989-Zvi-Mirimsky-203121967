using System;
using System.Windows.Forms;

namespace FacebookApp
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.connectButton = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.RichTextBox();
            this.buttonFacebookPlayer = new System.Windows.Forms.Button();
            this.buttonAdvancedSearch = new System.Windows.Forms.Button();
            this.userProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(31, 25);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(69, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(31, 222);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(289, 160);
            this.listBoxFriends.TabIndex = 2;
            this.listBoxFriends.Visible = false;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(316, 154);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(67, 23);
            this.buttonPostStatus.TabIndex = 4;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Visible = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Checked = true;
            this.checkBoxRememberUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(31, 54);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(102, 17);
            this.checkBoxRememberUser.TabIndex = 6;
            this.checkBoxRememberUser.Text = "Remember User";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            this.checkBoxRememberUser.Visible = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(106, 25);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 8;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Visible = false;
            this.buttonDisconnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDisconnect_MouseClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(137, 73);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 33);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "username";
            this.usernameLabel.Visible = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(31, 418);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(289, 160);
            this.listBoxPosts.TabIndex = 11;
            this.listBoxPosts.Visible = false;
            // 
            // labelFriends
            // 
            this.labelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(27, 197);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(105, 22);
            this.labelFriends.TabIndex = 12;
            this.labelFriends.Text = "Your Friends:";
            this.labelFriends.Visible = false;
            // 
            // labelPosts
            // 
            this.labelPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.labelPosts.Location = new System.Drawing.Point(27, 394);
            this.labelPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(89, 22);
            this.labelPosts.TabIndex = 13;
            this.labelPosts.Text = "Your Posts:";
            this.labelPosts.Visible = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(137, 108);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(176, 70);
            this.textBoxStatus.TabIndex = 14;
            this.textBoxStatus.Text = "";
            this.textBoxStatus.Visible = false;
            // 
            // buttonFacebookPlayer
            // 
            this.buttonFacebookPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFacebookPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFacebookPlayer.BackgroundImage")));
            this.buttonFacebookPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFacebookPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonFacebookPlayer.FlatAppearance.BorderSize = 22;
            this.buttonFacebookPlayer.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFacebookPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFacebookPlayer.Location = new System.Drawing.Point(407, 25);
            this.buttonFacebookPlayer.Name = "buttonFacebookPlayer";
            this.buttonFacebookPlayer.Size = new System.Drawing.Size(120, 109);
            this.buttonFacebookPlayer.TabIndex = 9;
            this.buttonFacebookPlayer.Text = "Facebook Player";
            this.buttonFacebookPlayer.UseVisualStyleBackColor = true;
            this.buttonFacebookPlayer.Visible = false;
            this.buttonFacebookPlayer.Click += new System.EventHandler(this.buttonFacebookPlayer_Click);
            // 
            // buttonAdvancedSearch
            // 
            this.buttonAdvancedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdvancedSearch.BackgroundImage = global::FacebookApp.Properties.Resources.search_icon;
            this.buttonAdvancedSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdvancedSearch.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvancedSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonAdvancedSearch.Location = new System.Drawing.Point(543, 27);
            this.buttonAdvancedSearch.Name = "buttonAdvancedSearch";
            this.buttonAdvancedSearch.Size = new System.Drawing.Size(123, 107);
            this.buttonAdvancedSearch.TabIndex = 7;
            this.buttonAdvancedSearch.Text = "Perform Advanced Search";
            this.buttonAdvancedSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAdvancedSearch.UseVisualStyleBackColor = true;
            this.buttonAdvancedSearch.Visible = false;
            this.buttonAdvancedSearch.Click += new System.EventHandler(this.buttonAdvancedFriendSearch_Click);
            // 
            // userProfilePictureBox
            // 
            this.userProfilePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userProfilePictureBox.Location = new System.Drawing.Point(31, 79);
            this.userProfilePictureBox.Name = "userProfilePictureBox";
            this.userProfilePictureBox.Size = new System.Drawing.Size(101, 97);
            this.userProfilePictureBox.TabIndex = 1;
            this.userProfilePictureBox.TabStop = false;
            this.userProfilePictureBox.Visible = false;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(352, 207);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(175, 160);
            this.pictureBoxFriend.TabIndex = 15;
            this.pictureBoxFriend.TabStop = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 594);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.buttonFacebookPlayer);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonAdvancedSearch);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.userProfilePictureBox);
            this.Controls.Add(this.connectButton);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.PictureBox userProfilePictureBox;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.Button buttonAdvancedSearch;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonFacebookPlayer;
        private Label usernameLabel;
        private ListBox listBoxPosts;
        private Label labelFriends;
        private Label labelPosts;
        private RichTextBox textBoxStatus;
        private PictureBox pictureBoxFriend;
        private BindingSource postBindingSource;
        private BindingSource userBindingSource;
    }
}