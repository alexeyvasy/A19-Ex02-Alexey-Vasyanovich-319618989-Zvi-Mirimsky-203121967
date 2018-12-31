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
        private static List<FacebookSharedSong> s_Songs = new List<FacebookSharedSong>();

        public static List<FacebookSharedSong> GetFacebookSharedSongCollection(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = 300;
            FacebookObjectCollection<Link> links = i_LoggedInUser.PostedLinks;

            if(links == null)
            {
                throw new Exception("error accessing your facebook posts!");
            }

            foreach (Link link in links)
            {   // check if the link is supported
                if (URLSongFactory.IsLinkSupported(link.URL) == true) 
                {
                    s_Songs.Add(new FacebookSharedSong(link, eSongMode.Video));
                }
            }

            return s_Songs;
        }

        public static void Close()
        {
            FacebookService.s_CollectionLimit = 25;
        }
    }
}
