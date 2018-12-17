using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class SearchParameters
    {
        public bool FriendSearch { get; private set; }

        public bool EventSearch { get; private set; }

        public bool GroupSearch { get; private set; }

        public List<string> ChosenGroups { get; private set; }

        public eGender ChosenGender { get; private set; }

        public int StartAge { get; private set; }

        public int EndAge { get; private set; }

        public string KeyPhrase { get; private set; }

        public SearchParameters(
                                bool i_FemaleChecked, 
                                bool i_MaleChecked, 
                                List<string> i_CheckedUserGroups, 
                                int i_StartAge,
                                int i_EndAge,
                                string i_KeyPhrase,
                                bool i_FriendSearch,
                                bool i_GroupSearch,
                                bool i_EventSearch)
        {
            genderRestrictions(i_FemaleChecked, i_MaleChecked);
            ChosenGroups = i_CheckedUserGroups;
            StartAge = i_StartAge;
            EndAge = i_EndAge;
            KeyPhrase = i_KeyPhrase;
            FriendSearch = i_FriendSearch;
            GroupSearch = i_GroupSearch;
            EventSearch = i_EventSearch;
        }

        private void genderRestrictions(bool i_FemaleChecked, bool i_MaleChecked)
        {
            if (i_FemaleChecked && !i_MaleChecked)
            {
                ChosenGender = eGender.female;
            }
            else if (!i_FemaleChecked && i_MaleChecked)
            {
                ChosenGender = eGender.male;
            }
            else
            {
                ChosenGender = eGender.both;
            }
        }
    }
}
