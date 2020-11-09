using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main()
        {
            double getal1 = 12.345;
            Console.WriteLine(Math.Round(getal1, 2));
            Console.WriteLine(Math.Round(getal1));

            decimal getal2 = 67.89m;

            Console.WriteLine(Math.Round(getal2));
        }

    }
}
