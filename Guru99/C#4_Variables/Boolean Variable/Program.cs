using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 val1 = 10, val2 = 20;
            bool status = true;

            Console.WriteLine(val1 + val2);
            Console.WriteLine(val1 < val2);
            Console.WriteLine(!(status));
            Console.ReadKey();
        }
    }
}
