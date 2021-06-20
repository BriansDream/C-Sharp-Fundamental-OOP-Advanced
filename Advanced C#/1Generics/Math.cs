using System;
namespace _1Generics
{
    public class Math<T> where T : IComparable
    {
        // Method mencari nilai max
        // public int Max(int x, int y)

        // Generic 
        public T Max(T x, T y)
        {
            return x.CompareTo(y) > 0 ? x : y;
        }
    }
}