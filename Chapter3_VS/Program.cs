
using System;

namespace chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int num = 20;
                bool even = num % 2 == 0 ? true : false;
                Console.WriteLine("{0} is even ? {1}", num, even); 

               int num = Convert.ToInt32(Console.ReadLine());
               bool perpjestueshem = num % 35 == 0 ? true : false;
               Console.WriteLine("{0} eshte i perpjestushem me 5 dhe 7? {1}", num, perpjestueshem); */

              int num = Convert.ToInt32(Console.ReadLine());
              bool isSeven = (num / 100) % 10 == 7 ? true : false;
              Console.WriteLine("digit i trete i {0} eshte 7? {1}", num, isSeven); 
            /*
               int a = Convert.ToInt32(Console.ReadLine());
               int b = Convert.ToInt32(Console.ReadLine());
               int h = Convert.ToInt32(Console.ReadLine());

               int S = (a + b) * h / 2;
               Console.WriteLine("a={0}, b={1}, h={2}, S={3}", a, b, h, S); */

            /*  Console.WriteLine("Enter a: ");
              int a = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Enter b: ");
              int b = Convert.ToInt32(Console.ReadLine());

              int shuma = a * b;
              int p = a + b;
              Console.WriteLine("Syprina={0} Perimetri={1}", shuma, p); 

              Console.WriteLine("Pesha ne Toke: ");
              int P = Convert.ToInt32(Console.ReadLine());

              int neHane = P * 17 / 100;
              Console.WriteLine("Pesha juaj ne Toke eshte {0}, ndersa ne hane eshte {1}", P, neHane); */

            /* Console.Write("Enter number: ");
             int number = Convert.ToInt32(Console.ReadLine());
             int a = number / 1000;
             int b = (number / 100) % 10;
             int c = (number / 10) % 10;
             int d = number % 10;

             Console.WriteLine("1.Sum of digits = {0}", a + b + c + d);
             Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", a, b, c, d);
             Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
             Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", a, b, c, d); */

            


        }
    }
}
