using System;
using System.Collections.Generic;

namespace InterfaceExample.Core
{
    public class Post
    {
        private string _title;
        private string _url;
        private DateTime _date;
        private List<string> _tags = new List<string>();

        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        public DateTime Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public List<string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
    }
}
