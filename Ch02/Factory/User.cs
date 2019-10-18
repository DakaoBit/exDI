using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory
{
    public class User
    {
        public int Id;
        public string Title;
        public string Name;

        public User(int id, string title, string name)
        {
            Id = id;
            Title = title;
            Name = name;
        }
    }
}
