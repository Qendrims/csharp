using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            /*
            string binar = "1111010110011110";
            var hexnr = Convert.ToInt32(binar, 2).ToString("X");
            int deciaml = Convert.ToInt32(binar, 2);
            Console.WriteLine("Numri {0} ne hexadeciaml eshte {1} dhe ne deciamle eshte {2}", binar, hexnr, deciaml); 



            string hex1 = "FA";
            int nrHex1 = Convert.ToInt32(hex1, 16);
            string binar1 = Convert.ToString(nrHex1, 2);
            Console.WriteLine("Numri hex {0} ne binar eshte {1}.", hex1, binar1);
            string hex2 = "2A3E";
            int nrHex2 = Convert.ToInt32(hex2, 16);
            string binar2 = Convert.ToString(nrHex2, 2);
            Console.WriteLine("Numri hex {0} ne binar eshte {1}.", hex2, binar2);
            string hex3 = "FFFF";
            int nrHex3 = Convert.ToInt32(hex3, 16);
            string binar3 = Convert.ToString(nrHex3, 2);
            Console.WriteLine("Numri hex {0} ne binar eshte {1}.", hex3, binar3);
            string hex4 = "5A0E9";
            int nrHex4 = Convert.ToInt32(hex4, 16);
            string binar4 = Convert.ToString(nrHex4, 2);
            Console.WriteLine("Numri hex {0} ne binar eshte {1}.", hex4, binar4);  */






            /*
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
             Console.WriteLine("Numri hexadecimal {0} ne decimal eshte {1}", nrHexa, nrDecimal); 


            Console.Write("Shkruaj nje numer hexadecimal: ");
            string nrHexa = Console.ReadLine();
            int hex = Convert.ToInt32(nrHexa, 16);
            string nrBinar = Convert.ToString(hex, 2);
            Console.WriteLine("Numri hexadecimal {0} ne numer binare eshte {1}", nrHexa, nrBinar);




           
            Console.Write("Shkruaj ne numer binar: ");
            string nrBinar = Console.ReadLine();
            var nrHexa = Convert.ToInt32(nrBinar, 2).ToString("X");
            Console.WriteLine("Numri binar {0} ne Hexadecimal eshte {1}", nrBinar, nrHexa);   


            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}.", deci, deci.ToString("X")); 


            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.", hexa, Convert.ToInt32(hexa, 16));  



            int deci = 0;

            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                deci += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("Result is {0}.", deci); 



            int result = 0;
            Console.Write("Enter Roman number: ");
            String s = Console.ReadLine();
            string[] chars = s.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == "m" || chars[i] == "M") result += 1000;
                if (chars[i] == "d" || chars[i] == "D") result += 500;
                if (chars[i] == "c" || chars[i] == "C")
                {
                    result += 100;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "d" || chars[i + 1] == "D") result -= 200;
                        if (chars[i + 1] == "m" || chars[i + 1] == "M") result -= 200;
                    }
                }
                if (chars[i] == "l" || chars[i] == "L") result += 50;
                if (chars[i] == "x" || chars[i] == "X")
                {
                    result += 10;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "l" || chars[i + 1] == "L") result -= 20;
                        if (chars[i + 1] == "c" || chars[i + 1] == "C") result -= 20;
                    }
                }
                if (chars[i] == "v" || chars[i] == "V") result += 5;
                if (chars[i] == "i" || chars[i] == "I")
                {
                    result++;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "v" || chars[i + 1] == "V") result -= 2;
                        if (chars[i + 1] == "x" || chars[i + 1] == "X") result -= 2;
                    }
                }
            }

            Console.WriteLine("Arabic number is " + result);  */




            String result = "";
            Console.Write("Enter Arabic number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int thousands = i / 1000, hundreds = (i / 100) % 10, tens = (i / 10) % 10, ones = i % 10;

            switch (thousands)
            {
                case 1: result += "M"; break;
                case 2: result += "MM"; break;
                case 3: result += "MMM"; break;
            }

            switch (hundreds)
            {
                case 1: result += "C"; break;
                case 2: result += "CC"; break;
                case 3: result += "CCC"; break;
                case 4: result += "CD"; break;
                case 5: result += "D"; break;
                case 6: result += "DC"; break;
                case 7: result += "DCC"; break;
                case 8: result += "DCCC"; break;
                case 9: result += "CM"; break;
            }

            switch (tens)
            {
                case 1: result += "X"; break;
                case 2: result += "XX"; break;
                case 3: result += "XXX"; break;
                case 4: result += "XL"; break;
                case 5: result += "L"; break;
                case 6: result += "LX"; break;
                case 7: result += "LXX"; break;
                case 8: result += "LXXX"; break;
                case 9: result += "XC"; break;
            }

            switch (ones)
            {
                case 1: result += "I"; break;
                case 2: result += "II"; break;
                case 3: result += "III"; break;
                case 4: result += "IV"; break;
                case 5: result += "V"; break;
                case 6: result += "VI"; break;
                case 7: result += "VII"; break;
                case 8: result += "VIII"; break;
                case 9: result += "IX"; break;
            }

            Console.WriteLine("Roman number is " + result);

        }
    }
}
