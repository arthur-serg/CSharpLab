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
        private int index = -1;

        public MyList(int capacity)
        {
            arr = new Figure[capacity];
            count = capacity;
        }

        private bool IsInRange(int index)
        {
            if (index >= 0 && index < Count)
                return true;

            return false;
        }

        //TO DO: логика индексатора
        private Figure this[int index]
        {
            get { }
            set { }
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
            throw new System.NotImplementedException();
        }

        // перемещение в начало контейнера  
        public void Reset()
        {
            index = -1;
        }

        // текущий элемент в контейнере
        public object? Current { get; }
    }
}