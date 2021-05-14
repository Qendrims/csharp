using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Shkruaj vitin: ");
             int viti = Int32.Parse(Console.ReadLine());

             if (DateTime.IsLeapYear(viti))
             {
                 Console.WriteLine("Viti {0} eshte viti i brisht.", viti);
             }
             else Console.WriteLine("Viti {0} nuk eshte vit i brisht.", viti); 


            Random iliili = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(iliili.Next(100, 201));
            }
            


            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek); 

            Console.WriteLine("- three sides");
            Console.WriteLine("- side and the altitude to it");
            Console.WriteLine("- two sides and the angle between them in degrees.");
            Console.Write("Cilen formule doni ta zgjedhni: ");
            int zgjidhja = Int32.Parse(Console.ReadLine());


            switch (zgjidhja)
            {
                case 1:
                    Console.Write("a: ");
                    float a = Int32.Parse(Console.ReadLine());
                    Console.Write("b: ");
                    float b = Int32.Parse(Console.ReadLine());
                    Console.Write("c: ");
                    float c = Int32.Parse(Console.ReadLine());

                    float p = (a + b + c) / 2;
                    Console.WriteLine("S ={0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                    break;

                case 2:
                    Console.Write("a: ");
                    float a1 = Int32.Parse(Console.ReadLine());
                    Console.Write("h: ");
                    float h = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("S={0}", (a1 * h) / 2);
                    break;

                case 3:
                    Console.Write("a: ");
                    int a2 = Int32.Parse(Console.ReadLine());
                    Console.Write("b: ");
                    int b2 = Int32.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    int y = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("S = {0}", a2 * b2 * Math.Sin(y));
                    break;
            } */




            int result = 0;
            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');

            for (int i = 0; i < splitNumbers.Length; i++)
                result += Convert.ToInt32(splitNumbers[i]);

            Console.WriteLine("Result is: {0}", result);

        }
    }
}
