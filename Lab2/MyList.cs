using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Lab2
{
    internal class MyList<T> : IComparer<T>
    {
        private const int InitialCapacity = 2;
        private T[] myArray;

        public MyList(int capacity = InitialCapacity)
        {
            Capacity = capacity;
            myArray = new T[capacity];
        }

        public MyList(IEnumerable<T> ie, int capacity = InitialCapacity)
        {
            Capacity = capacity;
            myArray = new T[capacity];
            foreach (var item in ie)
            {
                Add(item);
            }
        }


        private bool IsInRange(int index) => index >= 0 && index <= Count;

        public T this[int index]
        {
            get => IsInRange(index) ? myArray[index] : default;

            set => myArray[index] = value;
        }

        public int Count { get; set; }

        public int Capacity
        {
            get => myArray?.Length ?? 0;

            set => myArray = new T[value];
        }

        public void Add(T item)
        {
            if (Count < Capacity - 1)
            {
                myArray[Count] = item;
            }
            else if (Count >= Capacity - 1)
            {
                var tempArray = new T[myArray.Length * 2];
                Array.Copy(myArray, tempArray, myArray.Length);
                tempArray[myArray.Length - 1] = item;
                Capacity *= 2;
                myArray = tempArray;
            }

            Count++;
        }

        //TO DO: implement overloading

        //public static MyList<T> operator +(MyList<T> lhs, MyList<T> rhs)
        //{
        //    MyList<T> result = new MyList<T>(lhs.Count);
        //    if (lhs.Count == rhs.Count)
        //    {
        //        (MyList<T> first, MyList<T> second) = (lhs, rhs);
        //    }
        //    else
        //    {
        //        throw new ArgumentException($"Element count of lists are not equal");
        //    }
        //}


        //TO DO: implement Sort

        public void RemoveAt(int index)
        {
            --Count;
            if (index < Count)
            {
                Array.Copy(myArray, index + 1, myArray, index, Count - index);
            }
        }

        public IEnumerator<T> GetEnumerator() => new MyEnumerator<T>(this);


        int IComparer<T>.Compare(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}