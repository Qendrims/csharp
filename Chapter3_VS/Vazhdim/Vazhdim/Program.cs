using System;

namespace Vazhdim
{
    class Program
    {
        static void Main(string[] args)
        {
            /* det2  
             int num = Convert.ToInt32(Console.ReadLine());
             bool perpjestueshem = num % 35 == 0 ? true : false;
             Console.WriteLine("{0} eshte i perpjestushem me 5 dhe 7? {1}", num, perpjestueshem); 

            det3
            int num = Convert.ToInt32(Console.ReadLine());
            bool isSeven = (num / 100) % 10 == 7 ? true : false;
            Console.WriteLine("digit i trete i {0} eshte 7? {1}", num, isSeven);  

            Det8
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool isInside = (x * x + y * y <= 5) ? true : false;
            Console.WriteLine("The point O ({0}, {1}) is inside K ((0,0),5)?: {2}", x, y, isInside); 

            det9
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool Circle = (x * x + y * y <= 5) ? true : false;
            bool Rectangle = (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, Circle);
            Console.WriteLine("The point O({0},{1}) is outside the rectangle ((-1,1), (5, 5))?: {2}", x, y, Rectangle); 
            
            detyra11
            int n = 35;
            int p = 6;
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0"); 

            detyra12
            int v = 350;
            int p = 350;
            int mask = 1 << p;
            bool isOne = (v & mask) != 0 ? true : false;
            Console.WriteLine("The bit at position {0} of number {1} is 1? {2}", p, v, isOne); 
            
            det13
            int n = 58;
            int v = 0;
            int p = 3;
            n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine(n); 

            Console.WriteLine("Add a number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (num > 2)
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(num)); ++i)
                {
                    if (num % i == 0) isPrime = false;
                }
            Console.WriteLine("{0} is prime?: {1}", num, isPrime); 

            Console.WriteLine("Enter a number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << 3;
            int bitAt3 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 4;
            int bitAt4 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 5;
            int bitAt5 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 24;
            int bitAt24 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 25;
            int bitAt25 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 26;
            int bitAt26 = (v & mask) != 0 ? 1 : 0;

            v = (bitAt3 == 0) ? v = v & (~(1 << 24)) : v = v | (1 << 24);
            v = (bitAt4 == 0) ? v = v & (~(1 << 25)) : v = v | (1 << 25);
            v = (bitAt5 == 0) ? v = v & (~(1 << 26)) : v = v | (1 << 26);
            v = (bitAt24 == 0) ? v = v & (~(1 << 3)) : v = v | (1 << 3);
            v = (bitAt25 == 0) ? v = v & (~(1 << 4)) : v = v | (1 << 4);
            v = (bitAt26 == 0) ? v = v & (~(1 << 5)) : v = v | (1 << 5);
            Console.WriteLine(v); */




        }
    }
}
