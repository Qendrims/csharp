using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n = ");
            string consoleInput = Console.ReadLine();
            int n = int.Parse(consoleInput);
            int number = 1;
            int sum = 1;

            Console.Write("The sum 1");
            while (number < n)
            {
                number++;
                sum += number;
                Console.Write("+{0}", number);
            }
            Console.WriteLine(" = {0}", sum);
            Console.ReadKey();
        }
    }
}
