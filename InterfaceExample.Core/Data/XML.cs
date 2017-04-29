using System;
using System.Xml;

namespace InterfaceExample.Core
{
    public class XML : IData
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
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(connectionstring);
            Blog blog = new Blog();
            foreach (XmlNode rootNode in xmlDocument.ChildNodes)
            {
                if (rootNode.Name == "rss")
                {
                    foreach (XmlNode node in rootNode.ChildNodes)
                    {
                        if (node.Name == "channel")
                        {
                            foreach (XmlNode subnode in node.ChildNodes)
                            {
                                if (subnode.Name == "item")
                                {
                                    Post post = new Post();
                                    foreach (XmlNode item in subnode.ChildNodes)
                                    {
                                        if (item.Name == "title")
                                        {
                                            post.Title = item.InnerText;
                                        }

                                        if (item.Name == "link")
                                        {
                                            post.Url = item.InnerText;
                                        }

                                        if (item.Name == "pubDate")
                                        {
                                            post.Date = Convert.ToDateTime(item.InnerText);
                                        }

                                        if (item.Name == "category")
                                        {
                                            post.Tags.Add(item.InnerText);
                                        }
                                    }

                                    blog.Posts.Add(post);
                                }
                            }
                        }
                    }
                }
            }

            return blog;
        }
    }
}
