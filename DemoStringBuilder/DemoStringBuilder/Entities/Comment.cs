using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStringBuilder.Entities
{
    class Comment
    {
        internal string Text;

        public string Name { get; set; }

        public Comment()
        {

        }

        public Comment(string name)
        {
            Name = name;
        }
    }

}
