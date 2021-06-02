using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Circle : Figure
    {
        string Name { get; set; } = "Circle";

        double Radius
        {
            get => Radius;
            set
            {
                if (Radius < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }
                Radius = value;
            }
        }
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public override string GetName() => Name;
    }
}
