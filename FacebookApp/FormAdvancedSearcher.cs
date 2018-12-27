using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class FormAdvancedSearcher : Form
    {
        private User m_LoggedInUser;
        private AdvancedSearcher m_NewSearch;
        private List<Group> m_CheckedGroups;
        private ListBox m_ListBoxSearchResults;
        private PictureBox m_PictureBoxPostPicture;
        private TextBox m_TextBoxPostMassage;
        private Label m_LabelPostOwnerInfo;

        private void showSearchResults()
        {
            Controls.Clear();

            Controls.Add(m_ListBoxSearchResults);
            Controls.Add(m_PictureBoxPostPicture);
            Controls.Add(m_TextBoxPostMassage);
            Controls.Add(m_LabelPostOwnerInfo);

            m_ListBoxSearchResults.SelectedIndexChanged += new EventHandler(ListBoxSearchResults_SelectedIndexChanged);
            m_ListBoxSearchResults.Size = new Size(500, 300);

            m_PictureBoxPostPicture.Location = new Point(m_ListBoxSearchResults.Left + 10, m_ListBoxSearchResults.Bottom + 30);
            m_PictureBoxPostPicture.Size = new Size(400, 300);
            m_PictureBoxPostPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            
            m_TextBoxPostMassage.Size = m_ListBoxSearchResults.Size;
            m_TextBoxPostMassage.Location = new Point(m_PictureBoxPostPicture.Right + 30, m_ListBoxSearchResults.Bottom + 30); 
            m_TextBoxPostMassage.Multiline = true;
            m_TextBoxPostMassage.ReadOnly = true;

            m_LabelPostOwnerInfo.Location = new Point(m_ListBoxSearchResults.Right + 20, 20);
            m_LabelPostOwnerInfo.Font = new Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            m_LabelPostOwnerInfo.AutoSize = true;

            // return posts array with all the relevant posts
            foreach (PostWrapper post in m_NewSearch.SearchResults)   
            {
                m_ListBoxSearchResults.Items.Add(post);
            }
        }

        private void ListBoxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostWrapper selectedPost = ((sender as ListBox).SelectedItem as PostWrapper);
            string userName = "unknown"; 
            string userAge = "unknown"; 

            m_TextBoxPostMassage.Clear();
            m_PictureBoxPostPicture.Image = null;

            if (selectedPost.Post.PictureURL != null)
            {
                m_PictureBoxPostPicture.LoadAsync(selectedPost.Post.PictureURL);
            }

            if (selectedPost.Post.From != null)
            {
                m_PictureBoxPostPicture.LoadAsync(selectedPost.Post.From.PictureNormalURL);
                userAge = AdvancedSearcher.UserAge(selectedPost.Post.From).ToString();
                userName = selectedPost.Post.From.Name;
            }

            m_LabelPostOwnerInfo.Text = string.Format(
@"Post Owner Name: {0}
Post Owner Age: {1}",
userName,
userAge);

            m_TextBoxPostMassage.Text = selectedPost.CreateTextForPost();
        }

        public FormAdvancedSearcher(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_CheckedGroups = new List<Group>();
            m_ListBoxSearchResults = new ListBox();
            m_PictureBoxPostPicture = new PictureBox();
            m_TextBoxPostMassage = new TextBox();
            m_LabelPostOwnerInfo = new Label();
            this.AutoSize = true; 

            InitializeComponent();
        }

        private void buttonSeearch_Click(object sender, EventArgs e)
        {
            foreach (Group group in checkedListBoxUserGroups.Items)
            {
                m_CheckedGroups.Add(group);
            }

            SearchParameters searchParameters = new SearchParameters(
                                                                        checkBoxFemale.Checked,
                                                                        checkBoxMale.Checked,
                                                                        m_CheckedGroups,
                                                                        (int)numericUpDownStartAge.Value,
                                                                        (int)numericUpDownEndAge.Value,
                                                                        textBoxKeyPhrase.Text,
                                                                        checkBoxFriends.Checked,
                                                                        checkBoxGroups.Checked,
                                                                        checkBoxEvents.Checked);

            m_NewSearch = new AdvancedSearcher(m_LoggedInUser, searchParameters);

            try
            {
                m_NewSearch.Search();
                showSearchResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show("API restrictions: \n" + ex.Message);
            }             
        }

        private void checkBoxGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGroups.Checked)
            {
                try
                {
                    foreach (Group group in m_LoggedInUser.Groups)
                    {
                        checkedListBoxUserGroups.Items.Add(group);
                    }

                    checkedListBoxUserGroups.Visible = true;
                }
                catch (Exception ex)
                {
                    checkBoxGroups.Checked = false;
                    MessageBox.Show(string.Format(
@"not active due to Graph API Groups restrictions

{0}", ex)); // catching GRAPH API restrictions
                }
            }
            else
            {
                checkedListBoxUserGroups.Visible = false;
            }
        }
    }
}
