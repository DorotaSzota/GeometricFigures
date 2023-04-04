using GeometricFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Circle : GeometricFigure
    {
        private double radius;

        public Circle(ConsoleColor color, double radius) : base(color)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return base.ToString() + $"Circle radius {radius}.\nCircle area: {Area():F2}.\n";
        }
    }
}
