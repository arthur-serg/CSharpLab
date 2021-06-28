﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Lab2
{
    internal class MyList<T> : IComparer<T>
    {
        private const int InitialCapacity = 2;
        private T[] myArray;

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





        /*
           // Adds the elements of the given collection to the end of this list. If
           // required, the capacity of the list is increased to twice the previous
           // capacity or the new size, whichever is larger.
           //
           //AddRange will be useful for overloading of * operator.
         
          Порядок элементов в коллекции сохраняется в List<T> .
          Если новый Count (текущий Count плюс размер коллекции) будет больше Capacity ,
          емкость List<T> увеличивается путем автоматического повторного выделения внутреннего массива для размещения новых элементов, 
          а существующие элементы копируются в новый массив перед добавлением новых элементов.
         */

        //TO DO: check Array borders. 
        // maybe AddRange(int index, IEnumerable<T> collection) ????
        public void AddRange(int index, MyList<T> collection)
        {
            T[] temp = new T[myArray.Length-1];
            if (this == collection)
            {
                Capacity += Count;
                Array.Copy(temp,0,myArray,index,Count);
                Array.Copy(temp,index+Count,myArray,index*2,Count-index);
            }
        }

        //Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает первое найденное вхождение в пределах всего списка List<T>.
        public void Find()
        {

        }

        //Изменяет порядок элементов во всем списке List<T> на обратный.
        public void Inverse()
        {

        }

        //Изменяет порядок элементов в указанном диапазоне.
        public void Inverse(int index, int count)
        {

        }

        public void Shuffle()
        {

        }


        //TO DO: implement overloading

        


        public static MyList<T> operator +(List<T> lhs, MyList<T> rhs)
        {
            var result = new MyList<T>((lhs));

            if (lhs.Count == rhs.Count)
            {
                
            }

            throw new Exception("arguments has different Count.");

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

        public IEnumerator<T> GetEnumerator() => new MyEnumerator<T>(this);


        int IComparer<T>.Compare(T x, T y)
        {
            throw new NotImplementedException();
        }
    }
}