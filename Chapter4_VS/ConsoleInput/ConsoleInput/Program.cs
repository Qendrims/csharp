using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Console.Write("r= ");
               int r = Int32.Parse(Console.ReadLine());
               Console.WriteLine("P ={0} and S= {1}", 2 * Math.PI * r, Math.PI * r * r);  

            Console.Write("Emri: ");
            string emri = Console.ReadLine();
            Console.Write("Mbiemri: ");
            string mbiembri = Console.ReadLine();
            Console.Write("Kompania: ");
            string komp = Console.ReadLine();
            Console.Write("Numri: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Addresa: ");
            string addresa = Console.ReadLine();

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Emri i menaxherit eshte: {0}", emri);
            Console.WriteLine("Mbiemri i menaxherit eshte {0}", mbiembri);
            Console.WriteLine("Emri i kompanis eshte {0}", komp);
            Console.WriteLine("Numri i telefonit eshte {0}", num);
            Console.WriteLine("Addresa e kompanise eshte {0}", addresa);  

            int hexNum = 2015;
            Console.WriteLine("|0x{0,-8:X|", hexNum);
            double fractNum = -1.856;
            Console.WriteLine("|0,-10:f2}|", fractNum);  

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;
            }

            Console.WriteLine("{0} numbers found.", counter); 

            int a, b, c, d, e;
            bool parseSucceed = false;

            do
            {
                Console.Write("Enter first number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out a);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter second number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter third number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fourth number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fiffth number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed); 

            Console.Write("Numri i pare: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Numri i dyte: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Numri i tret: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Numri i katert: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Numri i peste: ");
            int e = Int32.Parse(Console.ReadLine());

            if (b > a) a = b;
            if (c > a) a = c;
            if (d > a) a = d;
            if (e > a) a = e;
             
            Console.WriteLine("The greater number is {0}", a);

            
            int sum = 0;

            Console.Write("Enter number count: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                sum += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of all numbers is {0}.", sum); 

            int sum = 0;

            Console.Write("Enter number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);  

            uint numri1 = 0;
            uint numri2 = 1;
            uint shuma = 1;
            uint count = 0;

            Console.Write(" " + numri1);

            while(count < 100)
            {
                shuma = numri1 + numri2;
                numri1 = numri2;
                numri2 = shuma;
                Console.Write(numri2 + " ");
                count++;  */

            Console.Write("Enter last number: ");
            int length = Int32.Parse(Console.ReadLine());
            double sum = 1.0;

            for (int i = 2; i <= length; i++)
            {
                sum += (1.0 / i);
            }
            Console.WriteLine("{0:F3}", sum);
        }

    }
}
