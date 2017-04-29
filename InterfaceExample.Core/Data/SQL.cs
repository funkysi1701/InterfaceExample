using System;
using System.Data.SqlClient;

namespace InterfaceExample.Core
{
    public class SQL : IData
    {
        public int FindData(string value, Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog LoadData(string Connectionstring)
        {
            Blog blog = new Blog();
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Posts", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Post post = new Post();
                        post.Title = reader.GetString(0);
                        blog.Posts.Add(post);
                    }
                }
            }

            return blog;
        }
    }
}
