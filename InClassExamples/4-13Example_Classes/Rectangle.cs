using System;
using System.Collections.Generic;
using System.Text;

namespace _4_13Example_Classes
{
    public class Rectangle
    {
        /* private double _Length;
        public double GetLength()
        {
            return Length;
        }
        
        public void SetLength(double width)
        {
            _Length = Length;
        }*/

        public double Width { get; set; }
        public double Length { get; set; }
        
        /// <summary>
        /// Overloaded constructor, where we know what values we want to start
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        /// <summary>
        /// Default/Empty constructor that sets this instance of a Rectangle to starting values
        /// </summary>
        public Rectangle()
        {
            Width = 5;
            Length = 5;
        }
        /// <summary>
        /// calculcates the area of this Rectangle
        /// </summary>
        /// <returns>The area of this Rectangle</returns>
        public double CalculateArea()
        {
            return Length * Width;

        }
        /// <summary>
        /// Calculates the perimeter of this Rectangle
        /// </summary>
        /// <returns>The perimeter of this rectangle</returns>
        public double CalculatePerimeter() 
        {
            return 2 * (Length + Width);

        }



    }
}
