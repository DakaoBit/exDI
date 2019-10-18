using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory_FactoryMethod
{
    public class Pizza
    {
        public string Branch;
        public string Flavor;
        public int Quantity;

        public Pizza(string branch, string flavor, int quantity)
        {
            Branch = branch;
            Flavor = flavor;
            Quantity = quantity;
        }

        public void cook() {
            Console.WriteLine( $"Sotre:{Branch}, Flavor:{Flavor}, Quantity:{Quantity}");
        }
    }
}
