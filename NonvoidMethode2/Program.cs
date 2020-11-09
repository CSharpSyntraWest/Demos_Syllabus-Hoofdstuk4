using System;

namespace NonvoidMethode2
{
    class Program
    {
        static void Main()
        {
            int kg = 47;
            int cm = 158;

            double bmi = BodyMassIndex(kg, cm);
            Console.WriteLine(bmi);

            //Of meteen:
            Console.WriteLine(BodyMassIndex(47, 158));

        }
        static double BodyMassIndex(int gewichtInKg, int lengteInCentimeter)
        {
            double lengteInMeter = lengteInCentimeter / 100d;
            return gewichtInKg / Math.Pow(lengteInMeter, 2);
        }

    }
}
