using System;

namespace Lab2
{
    internal class Program
    {
        private static void Main()
        {
            var doubleList = new MyList<double>();
            doubleList.Add(-1.0);
            doubleList.Add(0.0);
            doubleList.Add(1.0);
            doubleList.Add(2.0);
            doubleList.Add(3.0);
            doubleList.Add(4.0);
            doubleList.Add(5.0);
            doubleList.Add(6.0);
            doubleList.Add(7.0);
            doubleList.Add(8.0);
            Console.WriteLine($"doubleList cap: {doubleList.Capacity} count: {doubleList.Count}");

            foreach (var item in doubleList)
            {
                Console.WriteLine(item);
            }

            var figureList = new MyList<Figure>();
            figureList.Add(new Circle(1));
            figureList.Add(new Square(6));
            figureList.Add(new Rectangle(1,6));
            foreach (var item in figureList)
            {
                Console.WriteLine(item);
            }
        }
    }
}