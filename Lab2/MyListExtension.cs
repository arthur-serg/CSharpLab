using System;

namespace Lab2
{
    internal static class MyListExtension
    {
        public static void Print<T>(this MyList<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}