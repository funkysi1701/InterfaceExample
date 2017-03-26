using System;
using System.Collections.Generic;

namespace Promotion.Core
{
    public class Post
    {
        public string Title;
        public string Url;
        public DateTime date;
        public List<string> Tags = new List<string>();
    }
}
