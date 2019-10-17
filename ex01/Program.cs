using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new ex01.MainApp();
            //demo.Login("nick", "1234", "EmailService");
            demo.Login("michael", "1234", "SMSService");
        }
    }
}
