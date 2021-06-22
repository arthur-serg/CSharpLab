using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab2
{
    internal class MyEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] myArray;
        private int position = 0;

        public MyEnumerator(T[] myArray)
        {
            this.myArray = myArray;
        }

        public T Current
        {
            get
            {
                if (position >= 0 && position <= myArray.Length)
                    return myArray[position];
                throw new InvalidOperationException();
            }
        }

        T IEnumerator<T>.Current => myArray[position - 1];

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
            
        }

         public bool MoveNext()
        {
            
            if (position >= 0 && position <= myArray.Length-1)
            {
                ++position;
                return true;
            }

            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
