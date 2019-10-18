using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch02.Factory;
using Ch02.Factory_SimpleFactory;

namespace Ch02.Factory_SimpleFactory
{
    class NYStore : IMakePizza
    {
        public void cook(Pizza pizza)
        {
            Console.WriteLine($"Sotre:{pizza.Branch}, Flavor:{pizza.Flavor}, Quantity:{pizza.Quantity}");
        }
    }

    class LAStore : IMakePizza
    {
        public void cook(Pizza pizza)
        {
            Console.WriteLine($"Sotre:{pizza.Branch}, Flavor:{pizza.Flavor}, Quantity:{pizza.Quantity}");
        }
    }
}
