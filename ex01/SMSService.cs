using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class SMSService : IMessageService
    {
        public void Send(User user, string msg)
        {
            Console.WriteLine($"寄送簡訊給使用者手機:{user.CellPhone}，訊息內容：" + msg);
        }
    }
}
