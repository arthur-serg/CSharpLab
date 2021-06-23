using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Lab2
{
    internal class MyEnumerator<T> : IEnumerator<T>
    {
        private readonly MyList<T> myList;
        private int position;

        public MyEnumerator(MyList<T> myList) => this.myList = myList;

        //TO DO: review logic maybe.
        public MyEnumerator(List<T> collection) => myList = new MyList<T>(collection);
        

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