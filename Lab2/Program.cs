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
            doubleSecondList.Print();


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




            debugList.CloneCollection().Print();
<<<<<<< HEAD
            foreach (var VARIABLE in debugList)
            {
                Console.Write(VARIABLE+" ");
            }

            Console.WriteLine();
            debugList.Print();
=======


            foreach (var VARIABLE in debugList)
            {
                Console.Write(VARIABLE + " ");
            }

            Console.WriteLine();

>>>>>>> master
            Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");
            debugList.CloneCollection().Print();
            Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");
            //debugList.CloneCollection().Print();
            //Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");
            //debugList.CloneCollection().Print();
            //Console.WriteLine($"count: {debugList.Count} cap: {debugList.Capacity}");

            

<<<<<<< HEAD
            var multiplyList = new MyList<int>();
            multiplyList.Add(1);
            multiplyList.Add(2);
            multiplyList.Add(3);

            //var res = multiplyList * 2;

            //foreach (var VARIABLE in res)
            //{
            //    Console.WriteLine(VARIABLE);
            //}
=======
            debugList.Print();
>>>>>>> master

            multiplyList.Shuffle();
            multiplyList.Print();
        }
    }
}