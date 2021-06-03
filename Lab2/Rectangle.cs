using System;

namespace Lab2
{
    internal class Rectangle : Figure, IPrint
    {
        private double width;
        private double height;
        public string Name { get; } = "Rectangle";
        public double Height
        {
            get => height;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }
                height = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (Width < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }
                width = value;
            }
        }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double GetArea() => Height * Width;
        public override string GetName() => Name;
        public override string ToString() => $"{GetArea()} : {Name}";
        void IPrint.Print() => Console.WriteLine(ToString());
    }
}
