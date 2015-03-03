using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        /// <summary>
        /// Method calculates surface of rectangle
        /// </summary>
        /// <returns>Returns double surface of rectangle</returns>
        public override double CalcSurface()
        {
            var surface = this.Width * this.Height;
            return surface;
        }

        /// <summary>
        /// Method calculate perimeter of rectangle
        /// </summary>
        /// <returns>Returns double perimeter of rectangle</returns>
        public override double CalcPerimeter()
        {
            var perimeter = (this.Width + this.Height) * 2;
            return perimeter;
        }
    }
}
