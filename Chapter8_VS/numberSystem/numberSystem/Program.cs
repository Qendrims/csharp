using System;

namespace numberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int nr1 = 150;
             string nr1Binar = Convert.ToString(nr1, 2);
             Console.WriteLine("Numri {1} ne binare eshte: {0}", nr1Binar, nr1);

             int nr2 = 35;
             string nr2Binar = Convert.ToString(nr2, 2);
             Console.WriteLine("Numri i dyte ne binare eshte: {0}", nr2Binar);

             int nr3 = 43;
             string nr3Binar = Convert.ToString(nr3, 2);
             Console.WriteLine("Numri i trete ne binare eshte: {0}", nr3Binar);

             int nr4 = 251;
             string nr4Binar = Convert.ToString(nr4, 2);
             Console.WriteLine("Numri i katert ne binare eshte: {0}", nr4Binar);

             int nr5 = 1023;
             string nr5Binar = Convert.ToString(nr5, 2);
             Console.WriteLine("Numri i peste ne binare eshte: {0}", nr5Binar);

             int nr6 = 1024;
             string nr6Binar = Convert.ToString(nr6, 2);
             Console.WriteLine("Numri i gjashte ne binare eshte: {0}", nr6Binar);

            
                        Console.Write("Shkruaj nje numer: ");
                        int nrDecimal = Int32.Parse(Console.ReadLine());
                        string nrBinar = Convert.ToString(nrDecimal, 2);
                        Console.WriteLine("Numri decimal {0} ne binare eshte {1}", nrDecimal, nrBinar); 


                        Console.Write("Shkruaj numrin Binar: ");
                        string nrBinar = Console.ReadLine();
                        int nrDecimal = Convert.ToInt32(nrBinar, 2);
                        Console.WriteLine("Numri binar {0} ne deciaml eshte {1}", nrBinar, nrDecimal);


                        Console.Write("Enter decimal number: ");
                        int deci = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("{0} to hexadecimal is {1}.", deci, deci.ToString("X"));  


                        Console.Write("Shkruaj nje numer hexadecimal: ");
                        string nrHexa = Console.ReadLine();
                        int nrDecimal = Convert.ToInt32(nrHexa, 16);
                        Console.WriteLine("Numri hexadecimal {0} ne decimal eshte {1}", nrHexa, nrDecimal); */


            Console.Write("Shkruaj nje numer hexadecimal: ");
            string nrHexa = Console.ReadLine();
            int hex = Convert.ToInt32(nrHexa, 16);
            string nrBinar = Convert.ToString(hex, 2);
            Console.WriteLine("Numri hexadecimal {0} ne numer binare eshte {1}", nrHexa, nrBinar);
            
            
            
            
            
           /* Console.Write("Shkruaj ne numer binar: ");
            string nrBinar = Console.ReadLine();
            var nrHexa = Convert.ToInt32(nrBinar, 2).ToString("X");
            Console.WriteLine("Numri binar {0} ne Hexadecimal eshte {1}", nrBinar, nrHexa);   */


        }
    }
}
