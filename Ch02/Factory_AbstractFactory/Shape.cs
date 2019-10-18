using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory_AbstractFactory
{
    public interface Shape
    {
        void draw();
    }

    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("畫一個圓形");
        }
    }

    class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("畫一個正方形");
        }
    }
}
