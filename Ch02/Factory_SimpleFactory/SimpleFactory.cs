using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch02.Factory_SimpleFactory;

namespace Ch02.Factory.Factory_SimpleFactory
{
    class SimpleFactory
    {
        public void Order(string branch, string flavor, int quantity)
        {
            IMakePizza pizza = null;
            switch (branch)
            {
                case "NYStore":
                    pizza = new NYStore();
                    pizza.cook(new Pizza() {Branch = branch, Flavor = flavor, Quantity = quantity});
                    break;

                case "LAStore":
                    pizza = new LAStore();
                    pizza.cook(new Pizza() { Branch = branch, Flavor = flavor, Quantity = quantity });
                    break;

                default:
                    throw new ArgumentException("Unknown Store!"); ;
            }
        }
    }
}
