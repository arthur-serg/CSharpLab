using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Rectangle : Figure
    {
        private readonly string name;
        private double height;
        private double width;

        double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }

        public override string GetName()
        {
            return name;
        }

    }
}
