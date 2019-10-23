using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch03.Common.Models;

namespace Ch03.Common.Services
{
    public class EmailService : IMessageService
    {
        public void Send(User user, string msg)
        {
            Console.WriteLine($"寄送電子郵件給使用者:{user.UserID}，訊息內容：" + msg);
        }
    }
}
