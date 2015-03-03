using System;

namespace Abstraction
{
    class Circle : Figure
    {
        public Circle(double radius)
            : base(radius, 1)
        {
        }

        /// <summary>
        /// Method calculate surface of circle
        /// </summary>
        /// <returns>Returns double surface of circle</returns>
        public override double CalcSurface()
        {
            var radius = this.Width;
            var surface = Math.PI * radius * radius;
            return surface;
        }

        /// <summary>
        /// Method calculate perimeter of circle
        /// </summary>
        /// <returns>Returns double perimeter of circle</returns>
        public override double CalcPerimeter()
        {
            var radius = this.Width;
            var perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
    }
}
