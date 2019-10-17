using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.NullObject
{
    class MainApp
    {
        public void DoSomething(string Type, string msg)
        {
            ILogger log = null;

            switch (Type)
            {
                case "NullLogger":
                    log = new NullLogger();
                    log.Log(msg);
                    break;

                case "ConsoleLogger":       
                    log = new ConsoleLogger();
                    log.Log(msg);
                    break;

                default:
                    throw new ArgumentException("Unknown message service type!");
            }

           
        }
    }
}
