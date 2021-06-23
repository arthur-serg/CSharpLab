using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab2
{
    internal class MyEnumerator<T> : IEnumerator<T>
    {
        private readonly MyList<T> myList;
        private int position = 0;

        public MyEnumerator(MyList<T> myList)
        {
            this.myList = myList;
        }

        public T Current
        {
            get
            {
                if (position >= 0 && position <= myList.Count - 1)
                    return myList[position];
                throw new InvalidOperationException();
            }
        }

        T IEnumerator<T>.Current => myList[position - 1];

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
        }

        public bool MoveNext()
        {
            if (position >= 0 && position <= myList.Count - 1)
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