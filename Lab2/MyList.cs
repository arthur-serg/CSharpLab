using System.Collections;
using System.Runtime.InteropServices.ComTypes;

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

        //TO DO: not sure.
        public MyList(int capacity)
        {
            arr = new Figure[capacity];
            count = capacity;
        }

        private bool IsInRange(int index)
        {
            return index >= 0 && index < Count;
        }


        private Figure this[int idx]
        {
            get => IsInRange(idx) ? arr[idx] : null;

            set => arr[idx] = value;
        }

        public int Capacity
        {
            get => arr.Length;
            set
            {
                //TO DO: логика мутатора.
                if (arr.Length == 0)
                {
                }
            }
        }

        //TO DO: ну и тут тоже.
        public int Count { get; set; }


        public void Add(Figure item)
        {
        }

        public void Sort()
        {
        }

        public void RemoveAt(int index)
        {
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