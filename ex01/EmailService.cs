using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class EmailService : IMessageService
    {
        public void Send(User user, string msg)
        {
            Console.WriteLine($"寄送電子郵件給使用者:{user.UserID}，訊息內容：" + msg);
        }
    }
}
