using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] values;

            values = new Int32[3];
            values[0] = 1;
            values[1] = 2;
            values[2] = 3;

            Console.WriteLine(values[0]);
            Console.WriteLine(values[1]);
            Console.WriteLine(values[2]);
        }        
    }
}
