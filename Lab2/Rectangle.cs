using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Rectangle : Figure
    {
        private readonly string name;

        double Height
        {
            get => Height;
            set
            {
                if (Height < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }
                Height = value;
            }
        }
        double Width
        {
            get => Width;
            set
            {
                if (Width < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }
                Width = value;
            }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }
        public override double GetArea() => Height * Width;

        public override string GetName() => name;

    }
}
