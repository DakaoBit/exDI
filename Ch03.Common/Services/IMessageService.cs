using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch03.Common.Models;

namespace Ch03.Common.Services
{
    public interface IMessageService
    {
        void Send(User user, string msg);
    }
}
