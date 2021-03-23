using System;

namespace If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Int32 value = 11;

               if(value<10)
               { 
                  Console.WriteLine("Value is less than 10");
               }
               else
               {
                   Console.WriteLine("Value is greater than 10");
               }*/
            Int32 value = 11;
            switch(value)
            {
                case 1: Console.WriteLine("Value is 1");
                break;
                case 2: Console.WriteLine("Value is 2");
                break;
                default: Console.WriteLine("value is different");
                break;

            }
        }
    }
}
