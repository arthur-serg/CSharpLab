using System;

namespace Lab2
{
    internal class Program
    {
        private static void Main()
        {
            var doubleList = new MyList<double>();
            doubleList.Add(3.0);
            doubleList.Add(4.0);
            doubleList.Add(0.0);
            doubleList.Add(6.0);
            doubleList.Add(7.0);
            doubleList.Add(8.0);
            doubleList.Add(9.0);
            doubleList.Add(10.0);
            doubleList.Add(11);
            Console.WriteLine($"doubleList cap: {doubleList.Capacity} count: {doubleList.Count}");

            foreach (var item in doubleList)
            {
                Console.WriteLine(item);
            }
        }
    }
}