using System;
using System.Collections.Generic;
using System.Text;

namespace _4_13Example_Classes
{
    public class Circle
    {
        public double Radius { get; set; }

        /// <summary>
        /// Defult/Empty constructor setting our program
        /// </summary>
        public Circle()
        {
            Radius = 0;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
