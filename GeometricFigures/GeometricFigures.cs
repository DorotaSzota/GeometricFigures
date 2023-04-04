using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class GeometricFigure
    {
        private ConsoleColor color { get; set; }
        public GeometricFigure(ConsoleColor color)
        {
            this.color = color;
        }
        public abstract double Area();

    }
}
