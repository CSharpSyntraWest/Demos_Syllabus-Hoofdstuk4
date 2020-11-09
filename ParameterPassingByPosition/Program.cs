using System;

namespace ParameterPassingByPosition
{
    class Program
    {
        static void Main()
        {
            double afstandInCm = 183d;
            PrintQuotient(afstandInCm, 100);

            Console.ReadLine();
        }
        static void PrintQuotient(double deeltal, double deler)
        {
            Console.WriteLine(deeltal / deler);
        }

    }
}
