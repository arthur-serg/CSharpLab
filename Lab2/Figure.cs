namespace Lab2
{
    public abstract class Figure
    {
        public interface IPrint
        {
            void Print();
        }
        public virtual double GetArea()
        {
            return 0;
        }
        public abstract string GetName();
    }
}
