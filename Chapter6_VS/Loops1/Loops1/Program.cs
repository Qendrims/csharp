using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int lowest = 0, highest = 0, input;

              Console.Write("Enter numbers length: ");
              int lenght = Int32.Parse(Console.ReadLine());

              for (int i = 0; i < lenght; i++)
              {
                  Console.Write("Enter number: ");
                  input = Int32.Parse(Console.ReadLine());
                  if (i == 0) lowest = highest = input;
                  else
                  {
                      if (lowest > input) lowest = input;
                      if (highest < input) highest = input;
                  }
              }
              Console.WriteLine("Lowest: {0}, Highest: {1}", lowest, highest);
            
                for (int i = 0; i < 4; i++)
                {
                    if (i != 0) Console.WriteLine();

                    for (int j = 0; j < 13; j++)
                    {
                        switch (i)
                        {
                            case 0: Console.Write("Zemer "); break;
                            case 1: Console.Write("Diamant "); break;
                            case 2: Console.Write("Flete "); break;
                            case 3: Console.Write("Rrush "); break;
                        }
                        switch (j)
                        {
                            case 0: Console.WriteLine("A"); break;
                            case 1: Console.WriteLine("2"); break;
                            case 2: Console.WriteLine("3"); break;
                            case 3: Console.WriteLine("4"); break;
                            case 4: Console.WriteLine("5"); break;
                            case 5: Console.WriteLine("6"); break;
                            case 6: Console.WriteLine("7"); break;
                            case 7: Console.WriteLine("8"); break;
                            case 8: Console.WriteLine("9"); break;
                            case 9: Console.WriteLine("10"); break;
                            case 10: Console.WriteLine("J"); break;
                            case 11: Console.WriteLine("Q"); break;
                            case 12: Console.WriteLine("K"); break;

                        }
                    }
                }
                Console.ReadLine();    

                Console.Write("Shkruaj nje numer: ");
                int length = Int32.Parse(Console.ReadLine());
                for (int i = 1; i < length; i++)
                    Console.WriteLine(i); 

                Console.Write("Enter N: ");
                int length = Int32.Parse(Console.ReadLine());

                for (int i = 1; i < length; i++)
                {
                    if (i % (3 * 7) != 0) Console.WriteLine(i);
                }  


                ulong nr1 = 0;  
                ulong nr2 = 1;  
                ulong nr3 = 0;

                Console.Write("N: ");
                int length = Int32.Parse(Console.ReadLine());

                Console.Write("0, 1,");

                for (int i = 2; i < length; i++)
                {
                    nr3 = nr1 + nr2;
                    Console.Write(" {0},", nr3);
                    nr1 = nr2;
                    nr2 = nr3;
                }
                Console.ReadKey();    


              Console.WriteLine("Enter N: (1<K<N) ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter K: (1<K<N) ");
                int k = Int32.Parse(Console.ReadLine());

                for (int i = n - 1; i > 0; i--) 
                {
                    n *= i;
                }
                for (int i = k - 1; i > 0; i--)
                {
                    k *= i;
                }

                n /= k;
                Console.WriteLine("Result is {0}", n); 


            /*      Console.WriteLine("Enter N: (1<K<N) ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter K: (1<K<N) ");
                int k = Int32.Parse(Console.ReadLine());
                int nMinusK = n - k;

                for (int i = n - 1; i > 0; i--) n *= i;
                for (int i = k - 1; i > 0; i--) k *= i;
                for (int i = nMinusK - 1; i > 0; i--) nMinusK *= i;
                Console.WriteLine("Result is {0}", n * k / nMinusK);   

                Console.Write("Enter N: (N >=0) ");
                int n = Int32.Parse(Console.ReadLine());

                int fact2N = 2 * n, factNplus1 = n + 1;

                for (int i = fact2N - 1; i > 0; i--) fact2N *= i;
                for (int i = factNplus1 - 1; i > 0; i--) factNplus1 *= i;
                for (int i = n - 1; i > 0; i--) n *= i;

                Console.WriteLine("The result is {0}", fact2N / (factNplus1 * n)); */


            Console.WriteLine("Shkruaj numrin: ");
            int n = Int32.Parse(Console.ReadLine());
            string binar = Convert.ToString(n, 2);
            Console.WriteLine("Nmuri ne binare eshte : {0}", binar);

        }
    }
}
