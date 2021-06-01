using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Rectangle : Figure
    {
        private readonly string name;


        double Height { get; set; }
        double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
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
