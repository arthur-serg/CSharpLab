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
        private Figure[] myArray = new Figure[1];
        private int positionIndex = -1;


        public MyList(int capacity)
        {
            myArray = new Figure[capacity];
            Capacity = capacity;
        }

        public MyList()
        {
            myArray = new Figure[1];
            Capacity = 1;
        }

        private bool IsInRange(int index) => index >= 0 && index <= Count;


        public Figure this[int index]
        {
            get => IsInRange(index) ? myArray[index] : null;

            set => myArray[index] = value;
        }

        //переделать
        public int Capacity
        {
            get => myArray.Length;
            set
            {
                if (value <= 0) return;
                Figure[] temp = new Figure[value * 2];
                if (Count > 0)
                {
                    Array.Copy(myArray,temp,0);
                }

                myArray = temp;
            }
        }


        public int Count { get; set; } 


        //добавляет элемент в конец контейнера, увеличивает его размер на 1. если Capacity==myArray.Length, то увеличиваем Capacity вдвое.
        public void Add(Figure item)
        {
            int lastElemIndex = myArray.Length-1;
            if (Count < Capacity)
            {
                myArray[lastElemIndex] = item;

                //++positionIndex;
            }

            else if (Count == Capacity)
            {
                Capacity *= 2;
                Figure[] temp = new Figure[Capacity];
                Array.Copy(myArray, temp, 0);
                temp[myArray.Length] = item;
                //++Count;
                //++positionIndex;
            }

            
            ++Count;
            ++positionIndex;
            //else if(Count>=Capacity)
            //{
            //    Figure[] temp = new Figure[myArray.Length*2];
            //    Array.Copy(myArray, temp, myArray.Length);
            //    Array.Resize(ref myArray, myArray.Length * 2);

            //    temp[^1] = item;
            //    Count = myArray.Length + 1;
            //    ++positionIndex;
            //}

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
        public Figure Current => myArray[positionIndex];
    }
}