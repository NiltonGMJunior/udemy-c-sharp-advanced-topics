using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //  LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            //  LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book);
            }
            
            Console.WriteLine();
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }
            
            Console.WriteLine();
            var singleBook = books.Single(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(singleBook.Title);
            
            Console.WriteLine();
            var singleOrDefaultBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVS++");
            Console.WriteLine(singleOrDefaultBook == null);

            Console.WriteLine();
            var firstBook = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(firstBook.Title + " " + firstBook.Price);

            Console.WriteLine();
            var skipAndTakeBooks = books.Skip(2).Take(3);
            foreach (var book in skipAndTakeBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }

            Console.WriteLine();
            var count = books.Count();
            Console.WriteLine(count);

            Console.WriteLine();
            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            Console.WriteLine();
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            Console.WriteLine();
            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);
        }
    }
}
