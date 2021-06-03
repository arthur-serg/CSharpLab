using System;

namespace Lab2
{
    internal class Square : Rectangle, Figure.IPrint
    {
        private double length;
        public string Name { get; } = "Square";
        public double Length
        {
            get => length;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Incorrect value. expected more than zero.");
                }
                length = value;
            }
        }
        public Square(double length) : base(0, 0)
        {
            Length = length;
        }
        public override double GetArea() => Length * Length;
        public override string ToString() => $"{Name} : {GetArea()}";
        public override string GetName() => Name;
        void IPrint.Print() => Console.WriteLine(this.ToString());
    }
}
