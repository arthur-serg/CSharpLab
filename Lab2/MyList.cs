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
            arr = new Figure[Capacity];
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
                //пиздёж где-то тут.
                if (value > 0)
                {
                    Debug.WriteLine($"value: {value}");
                    Figure[] temp = new Figure[value];
                    Debug.WriteLine($"{Count}");
                    if (Count >= 0)
                    {
                        Array.Copy(arr, 0, temp, 0, arr.Length);
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


        //добавляет элемент в конец контейнера, увеличивает его размер на 1. если Capacity==arr.Length, то увеличиваем Capacity вдвое.
        public void Add(Figure item)
        {
            int lastElementIndex = Count;
            if (lastElementIndex < arr.Length)
            {
                Count = lastElementIndex++;
                arr[lastElementIndex] = item;
            }

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