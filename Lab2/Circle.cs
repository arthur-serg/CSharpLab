using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Circle : Figure
    {
        private readonly string name;

        double Radius
        {
            get => Radius;
            set
            {
                if (Radius < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }
            }
        }
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public override string GetName() => name;
    }
}
