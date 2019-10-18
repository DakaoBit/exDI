using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory_AbstractFactory
{
    public interface Color
    {
        void fill();
    }

    class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("塗上紅色");
        }
    }

    class White : Color
    {
        public void fill()
        {
            Console.WriteLine("塗上白色");
        }
    }
}
