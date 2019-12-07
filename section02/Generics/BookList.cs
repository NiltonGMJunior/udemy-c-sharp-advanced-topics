using System;

namespace Generics
{
    public class BookList
    {
        public void Add(BookList book)
        {
            throw new NotImplementedException();
        }

        public BookList this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}