using System;

namespace NonVoidMethodReferentieOpleveren
{
    class Program
    {
        static void Main()
        {
            double[] veelvoudenVanVier = Veelvouden(4);
            Print(veelvoudenVanVier);

            double[] veelvoudenVan7EnHalf = Veelvouden(7.5);
            Print(veelvoudenVan7EnHalf);
        }

        static double[] Veelvouden(double getal)
        {
            double[] veelvouden = new double[10];
            for (int index = 0; index < veelvouden.Length; index++)
            {
                veelvouden[index] = getal * (index + 1);
            }
            return veelvouden;
        }
        static void Print(double[] reeks)
        {
            foreach (double element in reeks) Console.Write(element + " ");
            Console.WriteLine();
        }

    }
}
