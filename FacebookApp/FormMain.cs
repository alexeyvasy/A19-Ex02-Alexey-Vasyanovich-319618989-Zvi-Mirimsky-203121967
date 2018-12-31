using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApp;
using FacebookAppLogic;
using FacebookPlayer;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private AppSettings m_AppSettings;
        private Action m_LogOut = null;     // required for Facebook Logout method

        public FormMain()
        {
            InitializeComponent();
            m_AppSettings = AppSettings.LoadFromFile();
            this.Size = m_AppSettings.m_LastWindowSize;
            this.Location = m_AppSettings.m_LastWindowLocation;

            if (m_AppSettings.m_RememberUser && !string.IsNullOrEmpty(m_AppSettings.m_LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.m_LastAccessToken);

                loadUser();
            }
        }

        private void fetchUserInfo()
        {
            userProfilePictureBox.LoadAsync(m_LoggedInUser.PictureSqaureURL);
            userProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameLabel.Text = m_LoggedInUser.Name;
            usernameLabel.ForeColor = Color.FromArgb(75, 150, 236);
            usernameLabel.Font = new Font("Arial", 16);
            showAllControls(true);

            postBindingSource.DataSource = m_LoggedInUser.Posts;
            userBindingSource.DataSource = m_LoggedInUser.Friends;
        }

        // 2036909676555640 - my app
        private void logIntoAccount()
        {
            m_LoginResult = FacebookService.Login(
"1450160541956417",
"email",
"groups_access_member_info",
"publish_to_groups",
"user_age_range",
"user_birthday",
"user_events",
"user_friends",
"user_gender",
"user_hometown",
"user_likes",
"user_link",
"user_location",
"user_photos",
"user_posts",
"user_tagged_places",
"user_videos");

            loadUser();
        }

        private void loadUser()
        {
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void logOutOfAccount()
        {
            FacebookService.Logout(m_LogOut);
            userProfilePictureBox.Image = null;
            usernameLabel.Text = null;
            m_LoggedInUser = null;
        }

        private void buttonAdvancedFriendSearch_Click(object sender, EventArgs e)
        {
            FormAdvancedSearcher newSearch = new FormAdvancedSearcher(m_LoggedInUser);
            newSearch.Show();
        }

        private void buttonFacebookPlayer_Click(object sender, EventArgs e)
        {
            FacebookPlayerForm facebookPlayerForm = new FacebookPlayerForm();

            facebookPlayerForm.Show();
            facebookPlayerForm.LoadSongs(m_LoggedInUser);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            m_AppSettings.m_LastWindowLocation = this.Location;
            m_AppSettings.m_LastWindowSize = this.Size;
            m_AppSettings.m_RememberUser = checkBoxRememberUser.Checked;

            if (checkBoxRememberUser.Checked && m_LoginResult != null)
            {
                m_AppSettings.m_LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.m_LastAccessToken = string.Empty;
            }

            m_AppSettings.SaveToFile();
        }

        private void buttonDisconnect_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                FacebookService.Logout(m_LogOut);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            showAllControls(false);
        }

        private void showAllControls(bool i_Show)
        {
            foreach(Control control in this.Controls)
            {
                control.Visible = i_Show;
            }

            connectButton.Visible = true;
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            logIntoAccount(); 
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend != null)
                {
                    if (selectedFriend.PictureNormalURL != null)
                    {
                        pictureBoxFriend.LoadAsync(selectedFriend.PictureLargeURL);
                    }
                }
            }
        }
    }
}
