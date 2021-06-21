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
        private const int InitialCapacity = 2;
        private Figure[] myArray;
        private int positionIndex = 0;
        private int capacity;

        public MyList(int capacity = InitialCapacity)
        {
            Capacity = capacity;
            myArray = new Figure[capacity];
        }

        private bool IsInRange(int index) => index >= 0 && index <= Count;


        public Figure this[int index]
        {
            get => IsInRange(index) ? myArray[index] : null;

            set => myArray[index] = value;
        }

        public int Count { get; set; } = 0;

        //переделать
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
                }
                else
                {
                    capacity = value;
                }
            }
        }

        //добавляет элемент в конец контейнера, увеличивает его размер на 1. если Capacity==myArray.Length, то увеличиваем Capacity вдвое.

        public void Add(Figure item)
        {
            if (positionIndex < Capacity - 1)
            {
                myArray[positionIndex] = item;
            }
            else if (positionIndex >= Capacity - 1)
            {
                Figure[] tempArray = new Figure[myArray.Length * 2];
                Array.Copy(myArray, tempArray, myArray.Length);
                tempArray[myArray.Length - 1] = item;
                Capacity *= 2;
                myArray = tempArray;
            }

            Count = positionIndex + 1;
            ++positionIndex;
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
                Array.Copy(myArray, index + 1, myArray, index, Count - index);
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
        public Figure Current => myArray[positionIndex - 1];
    }
}