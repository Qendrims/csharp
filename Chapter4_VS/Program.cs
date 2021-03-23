using System;

namespace Console_Input_and_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Console.WriteLine("Enter a number");
               int a = Int32.Parse(Console.ReadLine());

               Console.WriteLine("Enter second number");
               int b = Int32.Parse(Console.ReadLine());

               Console.WriteLine("Enter third number");
               int c = Int32.Parse(Console.ReadLine());

               int sum = a + b + c;
               Console.WriteLine("The sum is:{0}", sum); */


            /*  Console.WriteLine("Add a number ");
            int r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("P is {0} and S= {1}", 2 * Math.PI * r, Math.PI * r * r); 

            Console.WriteLine("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} >= {1}", Math.Max(num1, num2), Math.Min(num1, num2)); */

            Console.WriteLine("Emri: ");
            string emri = Console.ReadLine();
            Console.WriteLine("Mbiemri: ");
            string mbiembri = Console.ReadLine();
            Console.WriteLine("Kompania: ");
            string komp = Console.ReadLine();
            Console.WriteLine("Numri: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addresa: ");
            string addresa = Console.ReadLine();

            Console.WriteLine("Emri i menaxherit eshte: {0}" / n "Mbiemri i menaxherit eshte: {1}" / n, emri, mbiembri);
        }
    }
}
