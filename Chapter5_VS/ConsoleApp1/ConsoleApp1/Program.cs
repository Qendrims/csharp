using System;
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
            /*  Console.Write("Enter first number: ");
              int a = Int32.Parse(Console.ReadLine());
              Console.Write("Enter second number: ");
              int b = Int32.Parse(Console.ReadLine());
              Console.Write("Enter second number: ");
              int c = Int32.Parse(Console.ReadLine());

              if (a < b)
              {
                  if (a < c)
                  {
                      a = a + c;
                      c = a - c;
                      a = a - c;

                      if (b > c) ;
                      {
                          a = a + b;
                          b = a - b;
                          a = a - b;
                      }
                  }
                  else if (a >= c)
                  {
                      a = a + b;
                      b = a - b;
                      a = a - b;
                  }
              }
              else if (a == b)
              {
                  if ( a < c)
                  {
                      a = a + c;
                      c = a - c;
                      a = a - c;
                  }
              }
              else
              {
                  if (b < c)
                  {
                      b = b + c;
                      c = b - c;
                      b = b - c;
                  }
                  if (a < b)
                  {
                      a = a + b;
                      b = a - b;
                      a = a - b;
                  }
              }
              Console.WriteLine("{0}, {1}, {2}", a, b, c);
              Console.ReadLine();  

            Console.WriteLine("Add a number 0-9: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: Console.WriteLine("Null"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("Wrong input"); break;
            }
            Console.ReadLine(); 

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int e = Int32.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;
            Console.WriteLine("{0} is the biggest number.", a);
            Console.ReadKey();   


            Console.Write("Shkruaj nje numer: ");
            int numri1 = Int32.Parse(Console.ReadLine());
            Console.Write("Shkruaj nje numer: ");
            int numri2 = Int32.Parse(Console.ReadLine());

            if (numri1 > numri2)
            {
                numri1 = numri1 + numri2;
                numri2 = numri1 - numri2;
                numri1 = numri1 - numri2;
            }
            Console.WriteLine("Numri i pare: {0}, Numri i dyte: {1}", numri1, numri2);
            Console.ReadKey(); /


            Console.Write("Enter a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a < 0 && b < 0 && c < 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b < 0 && c >= 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c < 0) Console.WriteLine("+");
            else if (a >= 0 && b < 0 && c < 0) Console.WriteLine("+");
            else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine("-");
            else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine("-");

            Console.ReadKey();   


            Console.Write("Numri i pare: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Numri i dyte: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Numri i trete: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b)
                if (a > c) Console.WriteLine("Numri i pare eshte me i madhi");
                else if (a < c) Console.WriteLine("Numri i trete eshte me i madhi");
                else Console.WriteLine("Numri i pare dhe i trete jan me te medhenjt");

            else if (a < b)
                if (b > c) Console.WriteLine("Numri i dyte eshte me i madhi");
                else if (b < c) Console.WriteLine("Numri i trete eshte me i madhi");
                else Console.WriteLine("Numri i dyte dhe i trete jan me te medhenjt");

            else if (a == b)
                if (a == c) Console.WriteLine("Te tre numrat jane te barabart");
                else if (a < c) Console.WriteLine("Numri i trete eshte me i madhi");
                else Console.WriteLine("Numri i pare dhe i dyte jane me te medhenjt");
            Console.ReadKey(); 

            Console.Write("Input A (not 0): ");
            sbyte a = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input B: ");
            sbyte b = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input C: ");
            sbyte c = Convert.ToSByte(Console.ReadLine());

            sbyte d = (sbyte)(b * b - 4 * a * c);
            if (d < 0)
                Console.WriteLine("\nD={0}\nThere are no real roots.", d);
            else if (d == 0)
            {
                sbyte x1 = (sbyte)(-b / 2 * a);
                Console.WriteLine("\nX={0}", x1);
            }
            else
            {
                sbyte x1 = (sbyte)((-b + Math.Sqrt(d)) / (2 * a));
                sbyte x2 = (sbyte)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
            }
            Console.ReadLine();  


            Console.Write("Enter variable type(0-int, 1-double, 2-string): ");
            int intVar = Int32.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        intVar = Int32.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable + 1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable +* = {0}", stringVar);
                        break;
                    }
                default: Console.WriteLine("Wrong input"); break;
            }
            Console.ReadKey();   


            Console.Write("Shkruaj nje numer nga 1 deri ne 9: ");
            int numri = Int32.Parse(Console.ReadLine());

            if (numri >= 1 && numri <= 3)
                Console.WriteLine("Numri shumezohet me 10: {0}", numri * 10);
            else if (numri >= 4 && numri <= 6)
                Console.WriteLine("Numri shumezohet me 100: {0}", numri * 100);
            else if (numri >= 7 && numri <= 9)
                Console.WriteLine("Numri shumezohet me 1000: {0}", numri * 1000);
            else Console.WriteLine("Numri i gabuar");
            Console.ReadKey();   */


            Console.Write("Enter a number between 0 and 999: ");
            short number = Convert.ToInt16(Console.ReadLine());

            byte hundreds = (byte)(number / 100 | 0);
            byte tensAndOnes;

            if (number > 99) tensAndOnes = (byte)(number % 100);
            else tensAndOnes = (byte)(number * 1);

            byte ones = (byte)(number % 10);

            switch (hundreds)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }

            if (hundreds >= 1 && tensAndOnes >= 1) Console.Write("and ");

            if (tensAndOnes >= 20 && tensAndOnes < 30) Console.Write("Twenty");
            else if (tensAndOnes >= 30 && tensAndOnes < 40) Console.Write("Thirty");
            else if (tensAndOnes >= 40 && tensAndOnes < 50) Console.Write("Fourty");
            else if (tensAndOnes >= 50 && tensAndOnes < 60) Console.Write("Fifty");
            else if (tensAndOnes >= 60 && tensAndOnes < 70) Console.Write("Sixty");
            else if (tensAndOnes >= 70 && tensAndOnes < 80) Console.Write("Seventy");
            else if (tensAndOnes >= 80 && tensAndOnes < 90) Console.Write("Eighty");
            else if (tensAndOnes >= 90 && tensAndOnes < 100) Console.Write("Ninety");

            switch (tensAndOnes)
            {
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eight"); break;
                case 9: Console.Write("Nine"); break;
                case 10: Console.Write("Ten"); break;
                case 11: Console.Write("Eleven"); break;
                case 12: Console.Write("Twelve"); break;
                case 13: Console.Write("Thirteen"); break;
                case 14: Console.Write("Fourteen"); break;
                case 15: Console.Write("Fifteen"); break;
                case 16: Console.Write("Sixteen"); break;
                case 17: Console.Write("Seventeen"); break;
                case 18: Console.Write("Eighteen"); break;
                case 19: Console.Write("Nineteen"); break;
            }
            if (tensAndOnes > 20)
            {
                switch (ones)
                {
                    case 1: Console.Write("-one"); break;
                    case 2: Console.Write("-two"); break;
                    case 3: Console.Write("-three"); break;
                    case 4: Console.Write("-four"); break;
                    case 5: Console.Write("-five"); break;
                    case 6: Console.Write("-six"); break;
                    case 7: Console.Write("-seven"); break;
                    case 8: Console.Write("-eight"); break;
                    case 9: Console.Write("-nine"); break;
                }
            }
            if (number == 0) Console.Write("Zero");
            Console.ReadLine();
        }
    }
}
