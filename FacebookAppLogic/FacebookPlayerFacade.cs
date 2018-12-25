using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public static class FacebookPlayerFacade
    {
        private static List<FacebookSharedSong> m_Songs = new List<FacebookSharedSong>();

        public static List<FacebookSharedSong> getFacebookSharedSongCollection(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = 300;
            FacebookObjectCollection<Link> links = i_LoggedInUser.PostedLinks;
            if(links == null)
            {
                throw new Exception("error accessing your facebook posts!");
            }

            foreach (Link link in links)
            {
                if (URLSongFactory.IsLinkSupported(link.URL) == true) //check if the link is supported
                {
                    m_Songs.Add(new FacebookSharedSong(link, eSongMode.Video));
                }
            }

            return m_Songs;
        }

        public static void Close()
        {
            FacebookService.s_CollectionLimit = 25;
        }
    }
}
