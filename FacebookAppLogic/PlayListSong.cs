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
        public string SongName { get; }
        private URLSong m_SongURL;
        public eSongMode CurrentMode { get; set; }

        public PlayListSong(string i_SongName, URLSong i_SongURL, eSongMode i_Songmode)
        {
            m_SongURL = i_SongURL;
            SongName = i_SongName;
            CurrentMode = i_Songmode;
        }


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
    }
}
