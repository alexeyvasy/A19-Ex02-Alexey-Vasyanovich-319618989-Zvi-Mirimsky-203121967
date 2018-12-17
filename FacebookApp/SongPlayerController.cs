using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookPlayer
{
    public partial class SongPlayerController : UserControl
    {
        private PlayListSong m_CurrentSong;

        public SongPlayerController()
        {
            InitializeComponent();
        }

        public void Stop()
        {
            mediaPlayer.Url = new Uri("https://www.google.co.il/");
        }

        public void Play(PlayListSong i_newSong)
        {
            bool isVideoMode;

            m_CurrentSong = i_newSong;
            isVideoMode = m_CurrentSong.Mode == eSongMode.Video;
            showVideoMode(isVideoMode);
            showMinimalSongInfo();
            showSongAddOnsInfo();
        }

        private void showMinimalSongInfo()
        {
            songNameLabel.Text = m_CurrentSong.Name;
            mediaPlayer.Url = new Uri(m_CurrentSong.URL);
        }

        private void showSongAddOnsInfo()
        {
            FacebookSharedSong fss = m_CurrentSong as FacebookSharedSong;
            if (fss != null)
            {
                showFacebookShareInfo(fss);
            }
            else
            {
                showFacebookInfoControllers(false);
            }
        }

        private void showFacebookShareInfo(FacebookSharedSong i_FacebookSharedSong)
        {
            showFacebookInfoControllers(true);
            CommentsNumberLable.Text = i_FacebookSharedSong.NumberOfComments.ToString();
            LikesNumberLabel.Text = i_FacebookSharedSong.NumberOfLikes.ToString();
            if (i_FacebookSharedSong.UploadedDate.HasValue)
            {
                uploadDateLable.Text = i_FacebookSharedSong.UploadedDate.HasValue ? i_FacebookSharedSong.UploadedDate.Value.ToShortDateString() : "לא זמין";
            }
        }

        private void showVideoMode(bool i_isVideo)
        { 
            mediaPlayer.Visible = i_isVideo;
            switchToVideoButton.Visible = !i_isVideo;
            switchToAudioButton.Visible = i_isVideo;
        }

        private void showFacebookInfoControllers(bool i_isFacebookInfo)
        {
            uploadDateLable.Visible = i_isFacebookInfo;
            CommentsNumberLable.Visible = i_isFacebookInfo;
            LikesNumberLabel.Visible = i_isFacebookInfo;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Refresh();
        }

        private void switchToAudioButton_Click(object sender, EventArgs e)
        {
            showVideoMode(false);
            m_CurrentSong.Mode = eSongMode.Audio;
            mediaPlayer.Url = new Uri(m_CurrentSong.URL);
        }

        private void switchToVideoButton_Click(object sender, EventArgs e)
        {
            showVideoMode(true);
            m_CurrentSong.Mode = eSongMode.Video;
            mediaPlayer.Url = new Uri(m_CurrentSong.URL);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Refresh();
            mediaPlayer.Stop();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mediaPlayer.Url = new Uri("https://www.google.co.il/");
        }
    }
}
