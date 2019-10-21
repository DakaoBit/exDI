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
using Ch02.Factory_FactoryMethod;
using Ch02.Factory_AbstractFactory;
using Ch02.AmbientContext.ex01;
using Ch02.AmbientContext.ex02;

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
            //var user1 = new SimpleFactory();
            //user1.Order("NYStore", "pepperoni", 2);
            //var user2 = new SimpleFactory();
            //user2.Order("LAStore", "greek", 3);

            //Factory Pattern - FactoryMethod
            //PizzaStore nyStore = new Factory_FactoryMethod.NYStore();
            //var msg1 = nyStore.orderPizza(new Ch02.Factory_FactoryMethod.Pizza("NYStore", "pepperoni", 2));
            //Console.WriteLine(msg1);

            //PizzaStore laStore = new Factory_FactoryMethod.LAStore();
            //var msg2 = laStore.orderPizza(new Ch02.Factory_FactoryMethod.Pizza("LAStore", "cheese", 2));
            //Console.WriteLine(msg2);



            //Factory Pattern - AbstractFactory
            #region 抽象工廠模式
            /*
            優點：
            1.抽象工廠模式可以實現高內聚低耦合的設計目的，因此抽象工廠模式被廣泛的應用。
            2.當一個產品族中的多個對象被設計成一起工作時，它能保證客戶端始終使用同一個產品族中的對象。
            3.增加新的具體工廠和產品族很方便，不需要修改已有的系統，符合“開閉原則”。
            缺點：
            1.在產品族中擴充功能新的產品是很困難的，它需要修改抽象工廠的介面。
            2.增加新的工廠和產品族容易，增加新的產品等級結構麻煩(開閉原則的傾斜性)。*/
            #endregion

            //AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");
            //Shape shape1 = shapeFactory.getShape("Circle");
            //shape1.draw();

            //Shape shape2 = shapeFactory.getShape("Square");
            //shape2.draw();

            //AbstractFactory coloFactory = FactoryProducer.getFactory("COLOR");
            //Color color1 = coloFactory.getColor("Red");
            //color1.fill();

            //Color color2 = coloFactory.getColor("White");
            //color2.fill();

            //Ambient Context - example 1
            //AppShared.Logger.Log("使用 Ambient Context Pattern ");

            //Ambient Context - example 2
            Console.WriteLine("<<< Ambient Context 範例 >>>");
            TestContext.Run();
        }

    }
}
