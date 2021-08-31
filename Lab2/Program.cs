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
            //Console.WriteLine($"doubleList cap: {doubleFirstList.Capacity} count: {doubleFirstList.Count}");
            //doubleFirstList.Print();

            var doubleSecondList = new MyList<double>();
            doubleSecondList.Add(1);
            doubleSecondList.Add(0);
            doubleSecondList.Add(-1);
            doubleSecondList.Add(-2);
            doubleSecondList.Add(-3);
            doubleSecondList.Add(0);
            //Console.WriteLine($"doubleList cap: {doubleSecondList.Capacity} count: {doubleSecondList.Count}");
            //doubleSecondList.Print();


            //var figureList = new MyList<Figure>();
            //figureList.Add(new Circle(1));
            //figureList.Add(new Square(6));
            //figureList.Add(new Rectangle(1,6));
            //figureList.Print();

            var list = new List<double>();
            list.Add(-1);
            list.Add(5);

            var toMyList = new MyList<double>(list);
            //toMyList.Print();

            MyList<int> debugList = new MyList<int>();
            debugList.Add(1);
            debugList.Add(2);
            debugList.Add(3);
            debugList.Add(4);
            //debugList.Print();
            //debugList.AddRange(0,debugList);
            //debugList.Print();


            //debugList.CloneCollection().Print();
            //foreach (var VARIABLE in debugList)
            //{
            //    Console.Write(VARIABLE + " ");
            //}

            //Console.WriteLine();
            //debugList.Print();


            //foreach (var VARIABLE in debugList)
            //{
            //    Console.Write(VARIABLE + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");
            //debugList.CloneCollection().Print();
            //Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");
            //debugList.CloneCollection().Print();
            //Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");
            //debugList.CloneCollection().Print();
            //Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");

            //var listDeb = new MyList<int>();
            //listDeb.Add(0);
            //listDeb.Add(1);
            //listDeb.Print();
            //listDeb.AddRange(0, listDeb);
            //listDeb.Print();
            //listDeb.Add(33);
            //listDeb.Print();
            //listDeb.AddRange(0,listDeb);
            //listDeb.Print();

            var listOne = new MyList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(-3);
            listOne.Add(100);
            listOne.Add(5000);
            listOne.Add(-74445);
            listOne.Add(6);
            listOne.Add(7);
            listOne.Add(25);

            var newList = new MyList<int>();

            //listOne.Shuffle();

            //listOne.Shuffle<int>();

            listOne.Print();

            listOne.Inverse().Print();


            Console.WriteLine(listOne.Find(x => x > 0));

            listOne.Inverse<int>(2, 4);
        }
    }
}