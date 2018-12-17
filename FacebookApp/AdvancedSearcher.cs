using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppp
{
    public enum eGender
    {
        male,
        female,
        both
    }

    public class AdvancedSearcher
    {
        private eGender Gender { get; set; }
        private int StartAge { get; set; }
        private int EndAge { get; set; }
        private string KeyPhrase { get; set; }
        public User LoggedInUser { get; set; }
        public List<Post> SearchResults { get; private set; }

        public AdvancedSearcher(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            SearchResults = new List<Post>();
        }

        private bool ageRestrictions(User i_User)       // The person's birthday. This is a fixed format string, like MM/DD/YYYY. However, people can control who can see the year they were born separately from the month and day so this string can be only the year (YYYY) or the month + day (MM/DD)
        {            
            bool ageOK = false;
            
            if (i_User == null)
            {
                ageOK = true;
            }
            else
            {
                int age = 0;
                if (i_User.Birthday != null)
                {
                    string[] birthday = i_User.Birthday.Split('/');
                    DateTime today = DateTime.Today;
                    DateTime userBirthday = new DateTime(int.Parse(birthday[2]), int.Parse(birthday[0]), int.Parse(birthday[1]));
                    //Convert.ToDateTime(i_User.Birthday);

                    age = DateTime.Now.Year - userBirthday.Year;

                    if (DateTime.Now.DayOfYear < userBirthday.DayOfYear)
                    {
                        age = age - 1;
                    }

                    if (age <= EndAge && age >= StartAge)
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

                if (Gender == eGender.both)
                {
                    genderOK = true;
                }
                else if (Gender.ToString() == i_Friend.Gender.ToString())
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
                bool postBeenAdded = false;

                if (ageRestrictions(post.From) && genderRestrictions(post.From))
                {
                    if (post.Message != null)
                    {
                        if (post.Message.Contains(KeyPhrase))
                        {
                            SearchResults.Add(post);
                            postBeenAdded = true;
                        }
                    }

                    if (post.Name != null)
                    {
                        if (post.Name.Contains(KeyPhrase) && !postBeenAdded)
                        {
                            SearchResults.Add(post);
                            postBeenAdded = true;
                        }
                    }

                    if (post.Description != null)
                    {
                        if (post.Description.Contains(KeyPhrase) && !postBeenAdded)
                        {
                            SearchResults.Add(post);
                            postBeenAdded = true;
                        }
                    }
                }
            }
        }

        public void Search(bool i_EventSearch, bool i_FriendSearch, List<string> i_SearchGroups, int i_StartAge, int i_EndAge, string i_KeyPhrase, eGender i_ChosenGender)
        {
            Gender = i_ChosenGender;
            StartAge = i_StartAge;
            EndAge = i_EndAge;
            KeyPhrase = i_KeyPhrase;
            
            if (i_SearchGroups != null)
            {
                SearchGroups(i_SearchGroups);
            }

            if (i_FriendSearch)
            {
                SearchFriends();
            }

            if (i_EventSearch)
            {
                SearchEvents();
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

        private void SearchGroups(List<string> i_SearchGroups)
        {
            foreach (Group group in LoggedInUser.Groups)
            {
                if (i_SearchGroups.Contains(group.Name))
                {                    
                    searchPosts(group.WallPosts);
                }
            }
        }

        private void SearchEvents()
        {
            foreach(Event userEvent in LoggedInUser.Events)
            {
                searchPosts(userEvent.WallPosts);                
            }
        }
    }
}
