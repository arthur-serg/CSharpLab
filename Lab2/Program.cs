using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab2
{
    internal class Program
    {
        private static void Main()
        {
            var doubleFirstList = new MyList<double>();
            doubleFirstList.Add(-1.0);
            doubleFirstList.Add(0.0);
            doubleFirstList.Add(1.0);
            doubleFirstList.Add(2.0);
            doubleFirstList.Add(3.0);
            Console.WriteLine($"doubleList cap: {doubleFirstList.Capacity} count: {doubleFirstList.Count}");
            doubleFirstList.Print();

            var doubleSecondList = new MyList<double>();
            doubleSecondList.Add(1);
            doubleSecondList.Add(0);
            doubleSecondList.Add(-1);
            doubleSecondList.Add(-2);
            doubleSecondList.Add(-3);
            Console.WriteLine($"doubleList cap: {doubleSecondList.Capacity} count: {doubleSecondList.Count}");
            doubleSecondList.Print();


            var figureList = new MyList<Figure>();
            figureList.Add(new Circle(1));
            figureList.Add(new Square(6));
            figureList.Add(new Rectangle(1,6));
            figureList.Print();

            var list = new List<double>();
            list.Add(-1);
            list.Add(5);

            var toMyList = new MyList<double>(list);
            //toMyList.Print();

            MyList<int> debugList = new MyList<int>();
            debugList.Add(1);
            debugList.Add(2);
            debugList.Add(3);
            //debugList.Print();
            debugList.AddRange(0,debugList);
            debugList.Print();

            //debugList.CloneCollection().CloneCollection().Print();




        }
    }
}