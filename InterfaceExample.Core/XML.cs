using System;
using System.Xml;

namespace Promotion.Core
{
    public class XML : IData
    {
        public Blog LoadData(string Connectionstring)
        {
            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(Connectionstring);
            Blog blog = new Blog();
            foreach (XmlNode RootNode in myXmlDocument.ChildNodes)
            {
                if(RootNode.Name == "rss")
                {
                    foreach(XmlNode node in RootNode.ChildNodes)
                    {
                        if(node.Name == "channel")
                        {
                            foreach (XmlNode subnode in node.ChildNodes)
                            {
                                if(subnode.Name == "item")
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
                                            post.date = Convert.ToDateTime(item.InnerText);
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
