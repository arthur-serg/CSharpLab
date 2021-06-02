using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Rectangle : Figure
    {
        string Name { get; set; } = "Rectangle";

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
        public override double GetArea() => Height * Width;

        public override string GetName() => Name;

    }
}
