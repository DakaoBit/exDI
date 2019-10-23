using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03.MyDIContainerV1
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Ch03.MyDIContainerV1.MainApp();
            demo.Login("nick", "1234", "EmailService");
            //demo.Login("michael", "1234", ConfigurationManager.AppSettings["MessageServiceType"]);
        }
    }
}
