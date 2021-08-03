using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static T[] ToArray<T>(this MyList<T> collection)
        {
            var arr = new T[collection.Count];
            for (var i = 0; i < arr.Length; ++i)
            {
                arr[i] = collection[i];
            }

            return arr;
        }
    }
}