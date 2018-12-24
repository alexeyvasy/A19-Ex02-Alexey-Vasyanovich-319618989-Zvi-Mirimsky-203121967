using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostWrapper
    {
        public Post m_Post { get; }

        public PostWrapper(Post i_Post)
        {
            m_Post = i_Post;
        }

        

        public override string ToString()
        {
            string result = string.Empty;

            if (m_Post.Message != null)
            {
                result = m_Post.Message;
            }
            else if (m_Post.Name != null)
            {
                result = m_Post.Name;
            }
            else if (m_Post.Link != null)
            {
                result = m_Post.Link;
            }

            return result;
        }
    }
}
