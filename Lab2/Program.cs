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

            //listOne.Shuffle();

            //listOne.Shuffle<int>();

            listOne.Print();

            //Console.WriteLine(listOne.Find(x => x > 0));

            //listOne.Inverse<int>(4, 7);
            //listOne.Print();

            var listTwo = new MyList<int>();
            listTwo.Add(666);
            listTwo.Add(667);
            listTwo.Add(668);
            listTwo.Add(669);

            
            listOne.AddRange(listOne.Count, listTwo);
            Console.WriteLine("after addrange:");
            listOne.Print();

            var multiplier = 2;
            Console.WriteLine($"overload multiplying by {multiplier}");
            listTwo *= multiplier;
            listTwo.Print();
            int counter = 0;
            foreach (var item in listTwo)
            {
                if (item == 666)
                {
                    ++counter;
                }
            }
            Console.WriteLine($"{counter}");

            listOne.Print();
            (listOne + new List<int> {1, 2, 3, 4}).Print();
            listOne.Print();


        }
    }
}