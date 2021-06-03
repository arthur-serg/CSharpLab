using System.Collections;

namespace Lab2
{
    internal class MyList : Figure, IEnumerator, IEnumerable
    {
        
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public object? Current { get; }
        public override string GetName()
        {
            throw new System.NotImplementedException();
        }
    }
}