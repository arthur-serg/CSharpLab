using System;
using System.Collections;


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
        private int count;
        private int positionIndex = -1;
        private int initialCapacity = 1;

        private static readonly Figure[] emptyArray = new Figure[0];

        
        public MyList(int capacity)
        {
            arr = new Figure[capacity];
            count = capacity;
        }

        public MyList()
        {
            arr = new Figure[initialCapacity];
            count = initialCapacity;
        }

        private bool IsInRange(int index)
        {
            return index >= 0 && index < Count;
        }


        public Figure this[int idx]
        {
            get => IsInRange(idx) ? arr[idx] : null;

            set => arr[idx] = value;
        }

        public int Capacity
        {
            get => arr.Length;
            set
            {
                
                if (value >0)
                {
                    Figure[] temp = new Figure[value];
                    if (count > 0)
                    {
                        Array.Copy(arr, temp,0);
                    }

                    arr = temp;
                }
                else
                {
                    arr = emptyArray;
                }
            }
        }

        
        public int Count => count;


        public void Add(Figure item)
        {
            MoveNext();
            if (count == arr.Length)
            {
                Capacity *= 2;
                arr[count++] = item;

            }
            
        }

        //TO DO: implement.
        public void Sort()
        {
        }

        public void RemoveAt(int index)
        {
            --count;
            if (index < count)
            {
                Array.Copy(arr,index+1,arr,index,count-index);
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

        // текущий элемент в контейнере
        public object? Current => arr[positionIndex];
    }
}