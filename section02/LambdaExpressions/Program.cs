using System;
using System.Runtime.InteropServices.ComTypes;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //  args => expression
            //  number => number * number;
            //Func<int, int> square = Square;
            //Console.WriteLine(square(5));

            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));

            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;

            //var result = multiplier(10);
            //Console.WriteLine(result);

            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
