using System;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        private double width;
        private double height;

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative number.");
                }
                this.width = value;
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be negative number.");
                }
                this.height = value;
            }
        }

        public abstract double CalcSurface();
        public abstract double CalcPerimeter();
    }
}
