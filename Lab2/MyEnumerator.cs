using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab2
{
    internal class MyEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] myArray;
        private int positionIndex = -1;

        public MyEnumerator(T[] myArray)
        {
            this.myArray = myArray;
        }

        public T Current
        {
            get
            {
                if (positionIndex >= 0 && positionIndex <= myArray.Length)
                    return myArray[positionIndex];
                throw new InvalidOperationException();
            }
        }

        T IEnumerator<T>.Current => myArray[positionIndex - 1];

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
            
        }

         public bool MoveNext()
        {
            
            if (positionIndex >= 0 && positionIndex < myArray.Length)
            {
                ++positionIndex;
                return true;
            }

            return false;
        }

        void IEnumerator.Reset()
        {
            positionIndex = -1;
        }
    }
}
