using System;

namespace Lab2
{
    internal class Circle : Figure, IPrint
    {
        private double radius;
        public string Name => "Circle";
        public double Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }

                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
        public override string GetName() => Name;
        public override string ToString() => $"{Name} : {GetArea()}";
        void IPrint.Print() => Console.WriteLine(this.ToString());
    }
}