using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class MyList<T> : IComparer<T>
    {
        private const int InitialCapacity = 2;
        private T[] myArray;
        private int positionIndex;
        private int capacity;

        public MyList(int capacity = InitialCapacity)
        {
            Capacity = capacity;
            myArray = new T[capacity];
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

            set
            {
                if (myArray == null)
                {
                    capacity = InitialCapacity;
                }
                else if (positionIndex == myArray.Length - 1)
                {
                    capacity *= InitialCapacity;
                    myArray = new T[capacity];
                }
                else
                {
                    capacity = value;
                }
            }
        }

        public void Add(T item)
        {
            if (positionIndex < Capacity - 1)
            {
                myArray[positionIndex] = item;
            }
            else if (positionIndex >= Capacity - 1)
            {
                var tempArray = new T[myArray.Length * 2];
                Array.Copy(myArray, tempArray, myArray.Length);
                tempArray[myArray.Length - 1] = item;
                Capacity *= 2;
                myArray = tempArray;
            }

            Count = positionIndex + 1;
            ++positionIndex;
        }

        //TO DO: implement Sort

        public void RemoveAt(int index)
        {
            --Count;
            if (index < Count)
            {
                Array.Copy(myArray, index + 1, myArray, index, Count - index);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }

        int IComparer<T>.Compare(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}