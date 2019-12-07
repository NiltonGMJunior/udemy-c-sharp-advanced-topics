using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            //DateTime? date = null;
            //Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);

            DateTime? date = new DateTime(2014, 1, 1);
            DateTime date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;

            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;

            date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            date2 = date ?? DateTime.Today;
        }
    }
}
