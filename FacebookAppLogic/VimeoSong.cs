using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace FacebookAppLogic
{
    internal class VimeoSong : URLSong
    {
        public VimeoSong(string i_URL) : base(i_URL)
        {
        }

        public override bool IsValidURL(string i_URL)
        {
            return i_URL.Contains("vimeo");
        }

        protected override string parseToAudio(string i_URL)
        {
            WebRequest WReq = WebRequest.Create(i_URL);
            WReq.Method = "HEAD";
            Uri ActualURL = WReq.GetResponse().ResponseUri;

            return ActualURL.AbsoluteUri + @"?autoplay=1";
        }

        protected override string parseToVideo(string i_URL)
        {
            WebRequest WReq = WebRequest.Create(i_URL);
            WReq.Method = "HEAD";
            Uri ActualURL = WReq.GetResponse().ResponseUri;

            return @"https://player.vimeo.com/video" + ActualURL.AbsolutePath + @"?autoplay=1&title=0&byline=0";
        }
    }
}
