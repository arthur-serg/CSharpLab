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
        private Random seed = new Random();
        private T[] myArray;
        private IEnumerable<T> ie;

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

        public void AddRange(MyList<T> collection) => AddRange(Count, collection);


        public void AddRange(int index, MyList<T> collection)
        {
            T[] tempArray = new T[Count > collection.Count ? (collection.Count + Count) : Count * InitialCapacity];
            Array.Copy(myArray, 0, tempArray, 0, index);
            Array.Copy(collection.myArray, 0, tempArray, index, collection.Count);
            Array.Copy(myArray, index, tempArray, collection.Count + index, Count - index);
            Capacity = Count + collection.Count;
            Array.Copy(tempArray, 0, myArray, 0, Count + collection.Count);
            Count = Capacity;
        }


        private void CheckCapacity(int value)
        {
            if (myArray.Length < value)
            {
                int capacity = myArray.Length == 0 ? InitialCapacity : myArray.Length * 2;
                if (capacity < value)
                {
                    capacity = value;
                }

                Capacity = capacity;
            }
        }


        //Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает первое найденное вхождение в пределах всего списка List<T>.
        public T Find(Func<T, bool> match)
        {
            for (int i = 0; i < Count; ++i)
            {
                if (match(myArray[i]))
                {
                    return myArray[i];
                }
            }

            return default;
        }

        //Изменяет порядок элементов во всем списке List<T> на обратный.
        public MyList<T> Inverse()
        {
            var result = new MyList<T>();
            for (int i = Count - 1; i >= 0; --i)
            {
                result.Add(this[i]);
            }

            return result;
        }

        public void Inverse<T>() => Inverse<T>(0, Count);

        //Изменяет порядок элементов в указанном диапазоне.
        public void Inverse<T>(int startIndex, int stopIndex)
        {
            T[] tempArray = new T[Count];
            Array.Copy(myArray, tempArray, startIndex);
            Array.Reverse(myArray, startIndex, stopIndex - startIndex + 1);
            Array.Copy(myArray, stopIndex + 1, tempArray, Count - stopIndex + 1, Count - stopIndex);
        }

        public void Shuffle()
        {
            for (int i = Count; i > 0; --i)
            {
                int tempIndex = seed.Next(i);
                Add(this[tempIndex]);
                RemoveAt(tempIndex);
            }
        }

        public void Shuffle<T>()
        {
            var tempArray = new T[Count];
            Array.Copy(myArray, tempArray, Count);
            var result = tempArray.OrderBy(item => seed.Next());
            Array.Copy(result.ToArray(), myArray, Count);
        }

        public void CopyTo(T[] destinationArray, int index)
        {
            Array.Copy(myArray, 0, destinationArray, index, Count);
        }

        public void CopyTo(MyList<T> destinationList)
        {
            Array.Copy(myArray, destinationList.myArray, Count);
        }


        public static MyList<T> operator +(MyList<T> lhs, IEnumerable<T> ie)
        {
            var result = new MyList<T>();
            var rhs = new MyList<T>(ie);
            lhs.AddRange(lhs.Count, rhs);
            foreach (var item in lhs)
            {
                result.Add(item);
            }

            return result;
        }

        public static MyList<T> operator *(MyList<T> list, int x)
        {
            var result = new MyList<T>();

            if (x <= 1)
            {
                return list;
            }

            for (int i = 0; i < x; ++i)
            {
                foreach (var item in list)
                {
                    result.Add(item);
                }
            }

            return result;
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

        public void RemoveAll() => Count = 0;

        public void RemoveRange(int startIndex, int stopIndex)
        {
            if (startIndex == 0 && stopIndex == Count)
            {
                RemoveAll();
            }

            else if (IsInRange(stopIndex - startIndex))
            {
                Count = stopIndex - startIndex;
                Array.Copy(myArray, startIndex, myArray, stopIndex - Count, Count - startIndex);
            }
        }

        public IEnumerator<T> GetEnumerator() => new MyEnumerator<T>(this);


        int IComparer<T>.Compare(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}