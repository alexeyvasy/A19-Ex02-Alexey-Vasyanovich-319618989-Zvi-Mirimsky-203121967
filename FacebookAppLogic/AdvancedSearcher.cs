using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public enum eGender
    {
        male,
        female,
        both
    }

    public class AdvancedSearcher
    {
        public static int UserAge(User i_User)
        {
            int age = 0;
            string[] birthday = i_User.Birthday.Split('/');

            // if user has entered year of birth
            if (birthday.Count() == 3)   
            {
                DateTime today = DateTime.Today;
                DateTime userBirthday = new DateTime(int.Parse(birthday[2]), int.Parse(birthday[0]), int.Parse(birthday[1]));

                age = DateTime.Now.Year - userBirthday.Year;

                if (DateTime.Now.DayOfYear < userBirthday.DayOfYear)
                {
                    age = age - 1;
                }
            }

            return age;
        }

        public SearchParameters SearchParameters { get; private set; }

        public User LoggedInUser { get; private set; }

        public List<PostWrapper> SearchResults { get; private set; }

        public Func<string, string, bool> KeyPhraseSearcher { private get; set; }

        public AdvancedSearcher(User i_LoggedInUser, SearchParameters i_SearchParameters)
        {
            LoggedInUser = i_LoggedInUser;
            SearchResults = new List<PostWrapper>();
            SearchParameters = i_SearchParameters;
        }

        public void Search()
        {
            if (SearchParameters.GroupSearch)
            {
                searchGroups();
            }

            if (SearchParameters.FriendSearch)
            {
                SearchFriends();
            }

            if (SearchParameters.EventSearch)
            {
                searchEvents();
            }
        }

        private bool ageRestrictions(User i_User)       // The person's birthday. This is a fixed format string, like MM/DD/YYYY. However, people can control who can see the year they were born separately from the month and day so this string can be only the year (YYYY) or the month + day (MM/DD)
        {
            bool ageOK = false;

            // if user has not entered year of birth, we assume he is in the right age
            if (i_User == null || i_User.Birthday == null)
            {
                ageOK = true;
            }
            else
            {
                if (UserAge(i_User) != 0)
                { 
                    if (UserAge(i_User) <= SearchParameters.EndAge && UserAge(i_User) >= SearchParameters.StartAge)
                    {
                        ageOK = true;
                    }
                }
                else    
                {
                    ageOK = true;
                }       
            }

            return ageOK;
        }

        private bool genderRestrictions(User i_Friend)
        {
            bool genderOK = false;

            if (i_Friend == null)
            {
                genderOK = true;
            }
            else
            {
                if (SearchParameters.ChosenGender == eGender.both)
                {
                    genderOK = true;
                }
                else if (SearchParameters.ChosenGender.ToString() == i_Friend.Gender.ToString())
                {
                    genderOK = true;
                }
            }

            return genderOK;
        }

        private void searchPosts(FacebookObjectCollection<Post> i_Posts)
        {
            foreach (Post post in i_Posts)
            {
                PostWrapper myPost = new PostWrapper(post);
                bool postBeenAdded = false;

                if (ageRestrictions(post.From) && genderRestrictions(post.From))
                {
                    if (post.Message != null)
                    {
                        if (KeyPhraseSearcher.Invoke(post.Message, SearchParameters.KeyPhrase))         //  post.Message.Contains(SearchParameters.KeyPhrase)
                        {
                            SearchResults.Add(myPost);
                            postBeenAdded = true;
                        }
                    }

                    if (post.Name != null)
                    {
                        if (KeyPhraseSearcher.Invoke(post.Name, SearchParameters.KeyPhrase) && !postBeenAdded)
                        {
                            SearchResults.Add(myPost);
                            postBeenAdded = true;
                        }
                    }

                    if (post.Description != null)
                    {
                        if (KeyPhraseSearcher.Invoke(post.Description, SearchParameters.KeyPhrase) && !postBeenAdded)
                        {
                            SearchResults.Add(myPost);
                            postBeenAdded = true;
                        }
                    }
                }
            }
        }
        
        private void SearchFriends()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                if (genderRestrictions(friend) && ageRestrictions(friend))
                {
                    searchPosts(friend.Posts);
                }
            }
        }

        private void searchGroups()
        {
            foreach (Group group in SearchParameters.ChosenGroups)
            {               
                searchPosts(group.WallPosts);
            }
        }

        private void searchEvents()
        {
            try
            {
                foreach (Event userEvent in LoggedInUser.Events)
                {
                    searchPosts(userEvent.WallPosts);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
