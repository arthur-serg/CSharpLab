using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab2
{
    internal class Program
    {
        private static void Main()
        {
            var listOne = new MyList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(-3);
            listOne.Add(4);
            listOne.Add(5);
            listOne.Add(-6);
            listOne.Add(7);
            listOne.Add(-8);
            listOne.Add(9);

            var newList = new MyList<int>();


            var listTwo = new MyList<int>();
            listTwo.Add(1);
            listTwo.Add(7);
            
            //listOne.AddRange(listOne.Count, listTwo);
            //Console.WriteLine("after addrange:");
            //listOne.Print();

            

            listOne.Print();
            (listOne + new List<int> {1, 2, 3, 4}).Print();
            listOne.Print();



            var multiplier = 5;
            listTwo.Print();
            Console.WriteLine($"overload multiplying by {multiplier}");


            //listTwo.RemoveRange(1, listTwo.Count / 2);
            
            //listTwo.Print();
            Console.WriteLine($"Count before : {listTwo.Count}");
            (listTwo * multiplier).Print();
            int counter = 0;
            foreach (var item in listTwo)
            {
                if (item == 7)
                {
                    ++counter;
                }
            }
            Console.WriteLine($"{counter}");
            Console.WriteLine($"Count after : {listTwo.Count}");
        }
    }
}