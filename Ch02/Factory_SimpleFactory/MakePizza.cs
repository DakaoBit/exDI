using Ch02.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory_SimpleFactory
{
    interface IMakePizza
    {
        void cook(Pizza pizza);
    }
}
