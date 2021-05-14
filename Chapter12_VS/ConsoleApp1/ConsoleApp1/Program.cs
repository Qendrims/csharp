﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int n = -1;
            bool invalidNumber = false;

            try
            {
                n = Convert.ToInt32(input);
            }

            catch (FormatException e)
            {
                Console.WriteLine("Invalid number!");
                invalidNumber = true;
            }
            finally
            {
                if (n < 0)
                {
                    if (!invalidNumber) Console.WriteLine("Invalid number!");
                }
                else Console.WriteLine("Rrenja katrore e {0} = {1}", input, Math.Sqrt(n));
            }
            Console.WriteLine("Good Bye!");

            Console.ReadKey();
        }
    }
}
