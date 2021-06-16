using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab2
{
    internal class Program
    {
        private static void Main()
        {
            //Random rnd = new Random();
            //Square square = new Square(rnd.Next(0, 10));
            //Circle circle = new Circle(rnd.Next(0, 10));
            //Rectangle rectangle = new Rectangle(rnd.Next(0, 10), rnd.Next(0, 10));
            //List<Figure> figures = new List<Figure>
            //{
            //    square,
            //    circle,
            //    rectangle
            //};
            //Console.WriteLine($"List.Count: {figures.Count}");

            //Console.WriteLine($"overrided ToString():");
            //Console.WriteLine(square.ToString());
            //Console.WriteLine(circle.ToString());
            //Console.WriteLine(rectangle.ToString());
            //Console.WriteLine();
            //Console.WriteLine($"IPrint:");
            //Console.WriteLine(square);
            //Console.WriteLine(circle);
            //Console.WriteLine(rectangle);

            //Console.WriteLine(square.GetName());

            //foreach (var item in figures)
            //{
            //    if (item.GetArea() == 0)
            //    {
            //        Console.WriteLine($"Area = 0: {item.ToString()}");
            //    }
            //    if (item.GetName().StartsWith('S'))
            //    {
            //        Console.WriteLine($"name of {item.GetName()} starts with: {item.GetName()[0]}. {item.ToString()}");
            //    }
            //}

            MyList list = new MyList();
            Console.WriteLine($"init capacity: {list.Capacity} count: {list.Count}");
            list.Add(new Rectangle(3,2));
            list.Add(new Rectangle(3,5));
            list.Add(new Square(3));
            list.Add(new Circle(3));
            Console.WriteLine($"then capacity: {list.Capacity} count: {list.Count}");
            Debug.WriteLine($"{list[0]}");
            
            //Console.WriteLine($"then capacity: {list.Capacity} count: {list.Count}");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
