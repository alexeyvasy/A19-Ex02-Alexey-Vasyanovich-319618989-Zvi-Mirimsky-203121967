using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostWrapper
    {
        public Post Post { get; }

        public PostWrapper(Post i_Post)
        {
            Post = i_Post;
            
        }

        public string createTextForPost()
        {
            StringBuilder PostText = new StringBuilder();

            if (Post.Name != null)
            {
                PostText.Append(Post.Name);
                PostText.Append(Environment.NewLine);
            }

            if (Post.Message != null)
            {
                PostText.Append(Post.Message);
                PostText.Append(Environment.NewLine);
            }

            if (Post.Link != null)
            {
                PostText.Append(Post.Link);
                PostText.Append(Environment.NewLine);
            }

            if (Post.Description != null)
            {
                PostText.Append(Post.Description);
                PostText.Append(Environment.NewLine);
            }

            return PostText.ToString();
        }

        public override string ToString()
        {
            string result = string.Empty;

            if (Post.Message != null)
            {
                result = Post.Message;
            }
            else if (Post.Name != null)
            {
                result = Post.Name;
            }
            else if (Post.Link != null)
            {
                result = Post.Link;
            }

            return result;
        }
    }
}
