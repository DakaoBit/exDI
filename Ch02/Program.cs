using Ch02.Decorator;
using Ch02.NullObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    class Program
    {
        static void Main(string[] args)
        {
            //NullObject Pattern
            //ILogger log = new ConsoleLogger();
            //var demo = new Ch02.NullObject.MainApp();
            //demo.DoSomething(log);

            //Decorator Pattern
            ILogger logger = new DecoratedLogger(new ConsoleLogger());
            logger.Log("Hello, 裝飾模式!");
        }

    }
}
