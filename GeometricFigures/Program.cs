using GeometricFigures;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we can either create instances of our geometric figures one by one
            Rectangle p1 = new Rectangle(3, 4);
            Rectangle p2 = new Rectangle(5, 8);
            Countertop b1 = new Countertop(13, 10, Countertop.Kind.granite);
            Countertop b2 = new Countertop(15, 8, Countertop.Kind.wooden);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(b1.ToString());

            //or we can crate an array of geometric figures
            GeometricFigure[] geometricFigures = new GeometricFigure[3];
            geometricFigures[0] = new Rectangle(2.4, 16.2);
            geometricFigures[1] = new Countertop(11.1, 10, Countertop.Kind.wooden);
            geometricFigures[2] = new Circle(ConsoleColor.Cyan, 5.5);

            foreach (GeometricFigure g in geometricFigures)
            {
                Console.WriteLine(g.ToString());
            }

        }
    }
}
