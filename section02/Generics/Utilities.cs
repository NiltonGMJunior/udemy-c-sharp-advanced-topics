using System;

namespace Generics
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : Class
    // where T : new()
    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}