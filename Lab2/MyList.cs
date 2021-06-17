using System;
using System.Collections;
using System.Diagnostics;


namespace Lab2
{
    internal class MyNode
    {
        private MyNode nextMyNode;
        private MyNode elem;
    }

    internal class MyList : IEnumerator, IEnumerable
    {
        private Figure[] arr;
        private int positionIndex = -1;


        public MyList(int capacity)
        {
            arr = new Figure[capacity];
            Capacity = capacity;
        }

        public MyList()
        {
            Capacity = 1;
        }

        private bool IsInRange(int index) => index >= 0 && index < Count;


        public Figure this[int index]
        {
            get => IsInRange(index) ? arr[index] : null;

            set => arr[index] = value;
        }

        public int Capacity
        {
            get => arr.Length;
            set
            {

                if (value > 0)
                {
                    Figure[] temp = new Figure[value];
                    Debug.WriteLine($"{Count}");
                    if (Count > 0)
                    {
                        Array.Copy(arr, temp, arr.Length);
                    }

                    arr = temp;
                }
                else
                {
                    arr = new Figure[0];
                }
            }
        }

        public int Count { get; set; }

        public void Add(Figure item)
        {
            arr[arr.Length - 1] = item;
            ++Count;
            MoveNext();
            if (!MoveNext()) Capacity *= 2;
        }

        //TO DO: implement.
        public void Sort()
        {
        }

        public void RemoveAt(int index)
        {
            --Count;
            if (index < Count)
            {
                Array.Copy(arr, index + 1, arr, index, Count - index);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // перемещение на одну позицию вперед в контейнере элементов
        public bool MoveNext()
        {
            ++positionIndex;
            return IsInRange(positionIndex);
        }

        // перемещение в начало контейнера  
        public void Reset()
        {
            positionIndex = -1;
        }


        object IEnumerator.Current => Current;

        // текущий элемент в контейнере
        public Figure Current => arr[positionIndex];
    }
}