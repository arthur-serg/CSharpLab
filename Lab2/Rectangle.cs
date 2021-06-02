﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Rectangle : Figure
    {
        private readonly string name;

        double Height { get; set; } = 0;
        double Width { get; set; } = 0;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double GetArea() => Height * Width;

        public override string GetName() => name;

    }
}
