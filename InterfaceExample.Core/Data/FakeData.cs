using System;

namespace InterfaceExample.Core.Data
{
    public class FakeData : IData
    {
        public int FindData(string value, Blog blog)
        {
            for (int i = 0; i < blog.Posts.Count; i++)
            {
                if (value == blog.Posts[i].Title)
                {
                    return i;
                }
            }

            return 0;
        }

        public Blog LoadData(string connectionstring)
        {
            Blog blog = new Blog();
            Post post = new Post();
            post.Title = "Blame";
            post.Url = "https://www.funkysi1701.com/";
            post.Date = DateTime.UtcNow;
            blog.Posts.Add(post);
            post.Title = "Other";
            post.Url = "https://www.funkysi1701.com/";
            post.Date = DateTime.UtcNow;
            post.Tags.Add("Software Development");
            blog.Posts.Add(post);
            return blog;
        }
    }
}
