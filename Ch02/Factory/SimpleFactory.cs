using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory
{
    public static class SimpleFactory
    {
        public static User CreateAdministrator( int id, string title, string name)
        {  
            return new User(id, title, name);
        }

        public static User CreateEmployee(int id, string title, string name)
        {
            return new User(id, title, name);
        }
    }
}
