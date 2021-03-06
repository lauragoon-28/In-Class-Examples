using System;

namespace _4_13Example_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //first instance of the Rectangle
            Rectangle r1 = new Rectangle();
            r1.Length = 8;
            r1.Width = 8;
            double area = r1.CalculateArea();

            Console.WriteLine($"Rectangle 1 - L:{r1.Length}, W:{r1.Width}, A:{area}, P:{r1.CalculatePerimeter()}");

            //second instance of the Rectangle
            Rectangle r2 = new Rectangle(15, 11);

            Console.WriteLine($"Rectangle 2 - L:{r2.Length}, W:{r2.Width}, A:{r2.CalculateArea()}, P:{r2.CalculatePerimeter()}");

            //first instance of the Circle
            Circle c1 = new Circle();
            c1.Radius = 3.333;

            Console.WriteLine($"C1 - R:{c1.Radius}, A:{c1.CalculateArea()}, P:{c1.CalculatePerimeter()}");

            //Second instance of the Circle
            Circle c2 = new Circle();
            c2.Radius = 5.66;

            Console.WriteLine($"C2 - R:{c2.Radius}, A:{c2.CalculateArea()}, P:{c2.CalculatePerimeter()}");

        }
    }
}
