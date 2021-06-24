using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal static class MyListExtension
    {
        public static void Print<T>(this MyList<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}