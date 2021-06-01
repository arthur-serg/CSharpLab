using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Circle : Figure
    {
        private readonly string name;
        private double radius;

        double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string GetName()
        {
            return name;
        }
    }
}
