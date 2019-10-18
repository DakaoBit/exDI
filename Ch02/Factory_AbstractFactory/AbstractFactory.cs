using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory_AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Color getColor(string color);
        public abstract Shape getShape(string shape);
    }

    /// <summary>
    /// 具體工廠 - ShapeFactory
    /// </summary>
    class ShapeFactory : AbstractFactory
    {
 
        public override Color getColor(string color)
        {
            return null;
        }

        public override Shape getShape(string shape)
        {
            switch (shape)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                default:
                    throw new ArgumentException("Unknown shape!");
            }
        }
    }

    /// <summary>
    /// 具體工廠 - ColorFactory
    /// </summary>
    class ColorFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            switch (color)
            {
                case "Red":
                    return new Red();

                case "White":
                    return new White();

                default:
                    throw new ArgumentException("Unknown shape!");
            }
        }

        public override Shape getShape(string shape)
        {
            return null;
        }
    }
}
