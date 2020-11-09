using System;

namespace NonVoidMethode3
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                if (IsSchrikkeljaar(jaar))
                {
                    Console.WriteLine(jaar + " is een schrikkeljaar.");
                }
            } while (true);
        }
        static bool IsSchrikkeljaar(int jaartal)
        {
            return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
        }

    }
}
