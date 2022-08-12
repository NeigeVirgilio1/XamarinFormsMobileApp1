using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsMobileApp1
{
    public class Chat
    {

        private string _name;
        private string _seen;
        private string _image;
        private string _time;


        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Seen
        {
            get { return _seen; }
            set { _seen = value; }
        }

    }
}

