using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    interface IMessageService
    {
        // send user date and msg
        void Send(User user, string msg);
    }
}
