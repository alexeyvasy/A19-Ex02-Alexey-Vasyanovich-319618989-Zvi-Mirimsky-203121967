using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class PlayListSong
    {
        protected string m_SongName;
        private URLSong m_SongURL;
        private eSongMode m_CurrentMode;

        public PlayListSong(string i_SongName, URLSong i_SongURL, eSongMode i_Songmode)
        {
            m_SongURL = i_SongURL;
            m_SongName = i_SongName;
            m_CurrentMode = i_Songmode;
        }

        public string Name
        {
            get
            {
                return m_SongName;
            }
        }

        public eSongMode Mode
        {
            get
            {
                return m_CurrentMode;
            }

            set
            {
                m_CurrentMode = value;
            }
        }

        public string URL
        {
            get
            {
                string url;

                if (m_CurrentMode == eSongMode.Audio)
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
    }
}
