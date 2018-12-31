using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class FacebookSharedSong 
    {
        private Link m_FacebookSongLink;
        private URLSong m_SongURL;

        public string SongName { get; }

        public eSongMode CurrentMode { get; set; }

        public string URL
        {
            get
            {
                string url;

                if (CurrentMode == eSongMode.Audio)
                {
                    url = m_SongURL.AudioURL;
                }
                else
                {
                    url = m_SongURL.VideoURL;
                }

                return url;
            }
        }

        public FacebookSharedSong(Link i_FacebookSongLink, eSongMode i_SongMode)
        {
            CurrentMode = i_SongMode;
            m_FacebookSongLink = i_FacebookSongLink;
            m_SongURL = URLSongFactory.CreateURLSong(i_FacebookSongLink.URL);
            SongName = i_FacebookSongLink.Name;
        }

        public DateTime? UploadedDate
        {
            get
            {
                return m_FacebookSongLink.CreatedTime;
            }
        }

        public int NumberOfComments
        {
            get
            {
                return m_FacebookSongLink.Comments.Count;
            }
        }

        public int NumberOfLikes
        {
            get
            {
                return m_FacebookSongLink.LikedBy.Count;
            }
        }
    }
}
