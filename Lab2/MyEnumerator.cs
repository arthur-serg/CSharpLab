using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab2
{
    internal class MyEnumerator<T> : IEnumerator<T>
    {
        private readonly MyList<T> myList;
        private int position;

        public MyEnumerator(MyList<T> myList) => this.myList = myList;

        T IEnumerator<T>.Current => myList[position - 1];

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
        }

        public bool MoveNext()
        {
            if (position <= myList.Count - 1)
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