using System;

namespace PassingParametersByName2
{
    class Program
    {
        static void Main()
        {
            string[] steden = { "Gent", "Antwerpen", "Brussel", "Hasselt" };
            Print(steden);
            Print(steden, 2, true);
            Print(steden, 1);
            Print(steden, hoofdletters: true);

            Console.ReadLine();
        }
        static void Print(string[] reeks, int startIndex = 0, bool hoofdletters = false)
        {
            for (int index = startIndex; index <= reeks.Length - 1; index++)
            {
                string element = reeks[index];
                if (hoofdletters) element = element.ToUpper();
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
