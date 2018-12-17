using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppLogic
{
    public static class URLSongFactory
    {
        public static URLSong CreateURLSong(string i_URL)
        {
            URLSong urlSong = null;

            if(i_URL.Contains("youtube"))
            {
                urlSong = new YoutubeSong(i_URL);
            }
            else if (i_URL.Contains("soundcloud"))
            {
                urlSong = new SoundCloudSong(i_URL);
            }
            else if (i_URL.Contains("vimeo"))
            {
                urlSong = new VimeoSong(i_URL);
            }

            return urlSong;
        
        }
    }
}
