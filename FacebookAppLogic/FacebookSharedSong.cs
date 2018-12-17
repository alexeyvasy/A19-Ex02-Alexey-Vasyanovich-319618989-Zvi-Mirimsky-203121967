using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class FacebookSharedSong : PlayListSong
    {
        private Link m_FacebookSongLink;

        public FacebookSharedSong(URLSong i_SongURL, Link i_FacebookSongLink, eSongMode i_SongMode) : base(i_FacebookSongLink.Name, i_SongURL, i_SongMode)
        {
            m_FacebookSongLink = i_FacebookSongLink;
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
