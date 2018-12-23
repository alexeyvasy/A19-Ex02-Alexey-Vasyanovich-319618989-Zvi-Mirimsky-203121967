using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic
{
    internal class YoutubeSong : URLSong
    {
        public YoutubeSong(string i_URL) : base(i_URL)
        {
        }

        public override bool IsValidURL(string i_URL)
        {
            return i_URL.Contains("www.youtube.com");
        }

        private string getVideoCode(string i_URL)
        {
            int start, end;
            start = i_URL.IndexOf("%3D");
            if (start != -1)
            {
                start += 3;
                end = i_URL.IndexOf("%26");
            }
            else
            {
                start = i_URL.IndexOf("v=") + 2;
                end = i_URL.Length;
            }

            return i_URL.Substring(start, end - start);
        }

        protected override string parseToAudio(string i_URL)
        {
            return i_URL;
        }

        protected override string parseToVideo(string i_URL)
        {
            return @"https://www.youtube.com/v/" + getVideoCode(i_URL) + "?version=3&autoplay=1";
        }
    }
}
