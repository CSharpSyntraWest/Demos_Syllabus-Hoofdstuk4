using System;

namespace VoidMethode
{
    class Program
    {
        static void Main()
        {
            int[] afmetingen = { 20, 8, 13, 17, 6 };
            Print(afmetingen);
            Spiegel(afmetingen);
            Print(afmetingen);

        }
        static void Print(int[] getallen)
        {
            foreach (int getal in getallen)
            {
                Console.Write(getal + " ");
            }
            Console.WriteLine();
        }
        static void Spiegel(int[] getallen)
        {
            for (int index = 0; index < getallen.Length / 2; index++)
            {
                int backup = getallen[index];
                getallen[index] = getallen[getallen.Length - index - 1];
                getallen[getallen.Length - index - 1] = backup;
            }
        }

    }
}
