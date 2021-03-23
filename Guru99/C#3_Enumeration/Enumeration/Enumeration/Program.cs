using System;

namespace Enumeration
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sun);

            Console.ReadKey();
        }
    }
}
