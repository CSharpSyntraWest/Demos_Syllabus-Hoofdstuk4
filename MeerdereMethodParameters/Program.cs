using System;

namespace MeerdereMethodParameters
{
    class Program
    {
        static void Main()
        {
            int[] temperaturen = { 32, 10, 27, 21 };
            Print("Orginele lijst", temperaturen);

            Array.Sort(temperaturen);
            Print("Gesorteerde lijst", temperaturen);

            Console.ReadLine();
        }
        static void Print(string label, int[] getallen)
        {
            Console.Write(label + ": ");
            int index;
            for (index = 0; index < getallen.Length - 1; index++)
            {
                Console.Write(getallen[index] + "|");
            }
            Console.WriteLine(getallen[index]);
        }
    }

}
