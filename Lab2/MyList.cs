using System;
using System.Collections;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Lab2
{
    internal class MyList<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 2;
        private T[] myArray;
        private int positionIndex = 0;
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


        //TO DO: implement Sort by GetArea()
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

        public bool MoveNext()
        {
            ++positionIndex;
            return IsInRange(positionIndex);
        }

        public void Reset()
        {
            positionIndex = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>) this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        // текущий элемент в контейнере
        public object? Current => myArray[positionIndex - 1];
    }


    #region MyList collection as non-generic. Deprecated

    /*
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
                var tempArray = new Figure[myArray.Length * 2];
                Array.Copy(myArray, tempArray, myArray.Length);
                tempArray[myArray.Length - 1] = item;
                Capacity *= 2;
                myArray = tempArray;
            }

            Count = positionIndex + 1;
            ++positionIndex;
        }



        //TO DO: implement Sort by GetArea()
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
            positionIndex = 0;
        }


        object IEnumerator.Current => Current;

        // текущий элемент в контейнере
        public Figure Current => myArray[positionIndex - 1];
    }
    */

    #endregion
}