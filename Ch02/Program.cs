using Ch02.Decorator;
using Ch02.NullObject;
using Ch02.Composite;
using Ch02.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch02.Factory_SimpleFactory;

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
            //ILogger logger = new DecoratedLogger(new ConsoleLogger());
            //logger.Log("Hello, 裝飾模式!");

            //Composite Pattern
            //CompositeLogger com1 = new CompositeLogger("手機");
            //com1.Show();
            //com1.Log("插入時間為");


            //CompositeLogger com2 = new CompositeLogger("電腦");
            //com2.Show();
            //com2.Log("插入時間為");

            //Adapter Pattern
            //ILogger logger = new CommonLogger();
            //logger.Log(DateTime.Now.ToString());

            //Factory Pattern - SimpleFactory
            var user1 = new SimpleFactory();
            user1.Order("NYStore", "pepperoni", 2);
            var user2 = new SimpleFactory();
            user2.Order("LAStore", "greek", 3);
        }

    }
}
