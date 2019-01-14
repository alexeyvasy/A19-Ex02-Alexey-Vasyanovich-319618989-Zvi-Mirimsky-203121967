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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.RichTextBox();
            this.buttonFacebookPlayer = new System.Windows.Forms.Button();
            this.buttonAdvancedSearch = new System.Windows.Forms.Button();
            this.userProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.buttonBackgroundChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(41, 31);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(92, 28);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(41, 273);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(384, 196);
            this.listBoxFriends.TabIndex = 2;
            this.listBoxFriends.Visible = false;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(421, 190);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(89, 28);
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
            this.checkBoxRememberUser.Location = new System.Drawing.Point(41, 66);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(133, 21);
            this.checkBoxRememberUser.TabIndex = 6;
            this.checkBoxRememberUser.Text = "Remember User";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            this.checkBoxRememberUser.Visible = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(141, 31);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(100, 28);
            this.buttonDisconnect.TabIndex = 8;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Visible = false;
            this.buttonDisconnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDisconnect_MouseClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(183, 90);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(176, 39);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "username";
            this.usernameLabel.Visible = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(41, 514);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(384, 196);
            this.listBoxPosts.TabIndex = 11;
            this.listBoxPosts.Visible = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(36, 242);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(158, 29);
            this.labelFriends.TabIndex = 12;
            this.labelFriends.Text = "Your Friends:";
            this.labelFriends.Visible = false;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic);
            this.labelPosts.Location = new System.Drawing.Point(36, 485);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(136, 29);
            this.labelPosts.TabIndex = 13;
            this.labelPosts.Text = "Your Posts:";
            this.labelPosts.Visible = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(183, 133);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(233, 85);
            this.textBoxStatus.TabIndex = 14;
            this.textBoxStatus.Text = "";
            this.textBoxStatus.Visible = false;
            // 
            // buttonFacebookPlayer
            // 
            this.buttonFacebookPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFacebookPlayer.BackgroundImage")));
            this.buttonFacebookPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFacebookPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonFacebookPlayer.FlatAppearance.BorderSize = 22;
            this.buttonFacebookPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFacebookPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFacebookPlayer.Location = new System.Drawing.Point(543, 31);
            this.buttonFacebookPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFacebookPlayer.Name = "buttonFacebookPlayer";
            this.buttonFacebookPlayer.Size = new System.Drawing.Size(160, 134);
            this.buttonFacebookPlayer.TabIndex = 9;
            this.buttonFacebookPlayer.Text = "Facebook Player";
            this.buttonFacebookPlayer.UseVisualStyleBackColor = true;
            this.buttonFacebookPlayer.Visible = false;
            this.buttonFacebookPlayer.Click += new System.EventHandler(this.buttonFacebookPlayer_Click);
            // 
            // buttonAdvancedSearch
            // 
            this.buttonAdvancedSearch.BackgroundImage = global::FacebookApp.Properties.Resources.search_icon;
            this.buttonAdvancedSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdvancedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvancedSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonAdvancedSearch.Location = new System.Drawing.Point(724, 33);
            this.buttonAdvancedSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdvancedSearch.Name = "buttonAdvancedSearch";
            this.buttonAdvancedSearch.Size = new System.Drawing.Size(164, 132);
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
            this.userProfilePictureBox.Location = new System.Drawing.Point(41, 97);
            this.userProfilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.userProfilePictureBox.Name = "userProfilePictureBox";
            this.userProfilePictureBox.Size = new System.Drawing.Size(135, 119);
            this.userProfilePictureBox.TabIndex = 1;
            this.userProfilePictureBox.TabStop = false;
            this.userProfilePictureBox.Visible = false;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(469, 255);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(233, 197);
            this.pictureBoxFriend.TabIndex = 15;
            this.pictureBoxFriend.TabStop = false;
            // 
            // buttonBackgroundChange
            // 
            this.buttonBackgroundChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackgroundChange.Location = new System.Drawing.Point(813, 666);
            this.buttonBackgroundChange.Name = "buttonBackgroundChange";
            this.buttonBackgroundChange.Size = new System.Drawing.Size(94, 53);
            this.buttonBackgroundChange.TabIndex = 16;
            this.buttonBackgroundChange.Text = "Change Background";
            this.buttonBackgroundChange.UseVisualStyleBackColor = true;
            this.buttonBackgroundChange.Click += new System.EventHandler(this.buttonBackgroundChange_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 731);
            this.Controls.Add(this.buttonBackgroundChange);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
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
        private Button buttonBackgroundChange;
    }
}