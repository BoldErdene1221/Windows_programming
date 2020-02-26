using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class User
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public User()
        {
            name = "Unknown";
        }
    }
}
