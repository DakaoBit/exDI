using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch03.Common.Models;

namespace Ch03.Common.Services
{
    public class WordyEmailService : IMessageService
    {
        private IMessageService msgService;

        public WordyEmailService(IMessageService service)
        {
            this.msgService = service;
        }
 
        public void Send(User user, string msg)
        {
            msg += "\r\n此信件為系統自動發送，請勿回信。";
            this.msgService.Send(user, msg);
        }
    }
}
