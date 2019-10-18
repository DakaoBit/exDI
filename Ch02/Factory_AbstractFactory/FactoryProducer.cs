using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory_AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice) {
            switch (choice)
            {
                case "SHAPE":
                    return new ShapeFactory();

                case "COLOR":
                    return new ColorFactory();

                default:
                    throw new ArgumentException("Unknown choice!");
            }
        }
    }
}
