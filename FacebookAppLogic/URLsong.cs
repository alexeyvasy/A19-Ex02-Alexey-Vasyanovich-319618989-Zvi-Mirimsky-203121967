using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FacebookAppLogic
{
    public abstract class URLSong
    {
        protected string m_VideoURL;
        protected string m_AudioURL;

        public URLSong(string i_URL)
        {
            m_AudioURL = parseToAudio(i_URL);
            m_VideoURL = parseToVideo(i_URL);

            if (!IsValidURL(m_VideoURL) && !IsValidURL(m_AudioURL))
            {
                throw new Exception("this URL doesnt match!");
            }
        }

        protected abstract string parseToAudio(string i_URL);

        protected abstract string parseToVideo(string i_URL);

        public abstract bool IsValidURL(string i_URL);

        public string VideoURL
        {
            get
            {
                return m_VideoURL;
            }
        }

        public string AudioURL
        {
            get
            {
                return m_AudioURL;
            }
        }
    }
}
