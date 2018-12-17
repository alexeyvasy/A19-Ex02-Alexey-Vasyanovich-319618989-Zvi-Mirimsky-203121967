using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookPlayer
{
    public partial class FacebookPlayerForm : Form
    {
        private List<PlayListSong> m_Songs;

        public FacebookPlayerForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 300;
            m_Songs = new List<PlayListSong>();
            allSongsListBox.DisplayMember = "Name";
            playListBox.DisplayMember = "Name";
        }

        public void LoadSongs(User i_LoggedInUser)
        {
            new Thread(() => loadSongs(i_LoggedInUser)).Start();
        }

        private void loadSongs(User i_LoggedInUser)
        {
            FacebookObjectCollection<Link> links = i_LoggedInUser.PostedLinks;

            foreach (Link link in links)
            {
                if (link.URL != null)
                {
                    m_Songs.Add(new FacebookSharedSong(URLSongFactory.CreateURLSong(link.URL), link, eSongMode.Video));
                }
            }       

            foreach (PlayListSong song in m_Songs)
            {
                allSongsListBox.Invoke(new Action(() => allSongsListBox.Items.Add(song)));
            }
        }

        private void addToPlayListButton_Click(object sender, EventArgs e)
        {
            PlayListSong song = allSongsListBox.SelectedItem as PlayListSong; 

            if (song != null)
            {
                addSongToPlayList(song);
            }
            else
            {
                MessageBox.Show("First Choose a Song from the list!");
            }
        }

        private void addSongToPlayList(PlayListSong song)
        {
            if (!playListBox.Items.Contains(song))
            {
                playListBox.Items.Add(song);
                if (EraseButton.Visible == false)
                {
                    EraseButton.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("The song is already in your playlist!");
            }
        }

        private void playListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongsPlayer.Visible == false)
            {
                SongsPlayer.Visible = true;
            }

            playSelectedSong();
        }

        private void playSelectedSong()
        {
            PlayListSong song = playListBox.SelectedItem as PlayListSong;
            if (song != null)
            {
                SongsPlayer.Play(song);
            }
            else
            {
                SongsPlayer.Visible = false;
            }
        }

        public void StopPlaying()
        {
            SongsPlayer.Stop();
        }

        private void facebookPlayerTab_Enter(object sender, EventArgs e)
        {
            if (playListBox.SelectedItem != null)
            {
                SongsPlayer.Visible = true;
                SongsPlayer.Play(playListBox.SelectedItem as PlayListSong);
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            SongsPlayer.Stop();
            if (playListBox.Items.Count != 0)
            {
                playListBox.Items.Remove(playListBox.SelectedItem);
                if (playListBox.Items.Count == 0)
                {
                    EraseButton.Visible = false;
                }
            }
        }

        public void ContinuePlaying()
        {
            playSelectedSong();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            FacebookService.s_CollectionLimit = 25;
        }
    }
}
