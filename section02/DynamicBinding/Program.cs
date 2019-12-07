using System;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Reflection
            //object obj = "Mosh";
            ////obj.GetHashCode();

            //var methodInfo = obj.GetType().GetMethod("HetHashCode");
            //methodInfo.Invoke(null, null);

            //// Dynamic
            //dynamic excelObject = "mosh";
            //excelObject.Optimize();

            //dynamic name = "Mosh";
            //name = 10;

            //dynamic a = 10;
            //dynamic b = 5;
            //var c = a + b;

            int i = 5;
            dynamic d = i;
            long l = d;
        }
    }
}
