using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filePath =
            //    @"C:\Users\Nilton\Documents\GitHub\udemy-c-sharp-advanced-topics\section02\ExceptionHandling\file.txt";
            //var streamReader = new StreamReader(filePath);
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by 0.");
            //}
            //catch (ArithmeticException ex)
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occured.");
            //}
            //finally
            //{
            //    streamReader.Dispose();
            //}

            //StreamReader streamReader = null;
            //var filePath =
            //    @"C:\Users\Nilton\Documents\GitHub\udemy-c-sharp-advanced-topics\section02\ExceptionHandling\file.txt";
            //try
            //{
            //    streamReader = new StreamReader(filePath);
            //    var content = streamReader.ReadToEnd();
            //    throw new Exception("Oops");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occured.");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}

            //var filePath =
            //    @"C:\Users\Nilton\Documents\GitHub\udemy-c-sharp-advanced-topics\section02\ExceptionHandling\file.txt";
            //try
            //{
            //    using (var streamReader = new StreamReader(filePath))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occured.");
            //}


            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
