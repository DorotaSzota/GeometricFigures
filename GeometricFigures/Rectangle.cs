using GeometricFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle : GeometricFigure
    {
        private double length { get; set; }
        private double width { get; set; }

        public Rectangle(double length, double width) : base(ConsoleColor.DarkCyan)
        {
            this.length = width;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }
        public override string ToString()
        {
            return ($"Rectangle dimensions: {length} x {width}.\nArea: {Area():F2}.\n");
        }
    }
    class Countertop : Rectangle
    {

        public enum Kind { granite = 600, wooden = 250 }
        private Kind kind;

        public Countertop(double length, double width, Kind r) : base(length, width)
        {
            kind = r;
        }
        public double Cost()
        {
            double price = (double)kind;

            return price * Area();
        }
        public override string ToString()
        {
            return base.ToString() + $"Cost of the countertop: {Cost():F2}.\n";
        }


    }
}
