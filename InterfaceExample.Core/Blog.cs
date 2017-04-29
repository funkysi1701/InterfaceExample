using System.Collections.Generic;

namespace InterfaceExample.Core
{
    public class Blog
    {
        private List<Post> _posts = new List<Post>();

        public List<Post> Posts
        {
            get { return this._posts; }
            set { this._posts = value; }
        }
    }
}
