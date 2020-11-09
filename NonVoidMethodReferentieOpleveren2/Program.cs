using System;

namespace NonVoidMethodReferentieOpleveren2
{
    class Program
    {
        static void Main()
        {
            string[] namen = { "Jan", "Piet", "Pol" };
            do
            {
                Print(namen);

                Console.Write("Naam?: ");
                string naam = Console.ReadLine();

                namen = Uitbreiding(naam, namen);

                Console.WriteLine();
            } while (true);
        }
        static string[] Uitbreiding(string waarde, string[] reeks)
        {
            int index = 0;
            while (index < reeks.Length && reeks[index] != null) index++;
            if (index == reeks.Length) Array.Resize(ref reeks, reeks.Length * 2);
            reeks[index] = waarde;
            return reeks;
        }
        static void Print(string[] reeks)
        {
            Console.Write($"({reeks.Length} elementen): ");
            foreach (string element in reeks) Console.Write(element + " ");
            Console.WriteLine();
        }

    }
}
