using System;

namespace ParametersPassingByName
{
    class Program
    {
        static void Main()
        {
            double afstandInCm = 183d;
            PrintQuotient(deler: 100, deeltal: afstandInCm);
            PrintQuotient(afstandInCm, deler: 100);
        }
        static void PrintQuotient(double deeltal, double deler)
        {
            Console.WriteLine(deeltal / deler);
        }
    }

}

