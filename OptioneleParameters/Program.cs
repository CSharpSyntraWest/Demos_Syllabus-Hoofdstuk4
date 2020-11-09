using System;

namespace OptioneleParameters
{
    class Program
    {
        static void Main()
        {
            string tekst1 = "Hallo";

            PrintHerhaald(tekst1);
            PrintHerhaald(tekst1, 5);

        }
        //static void PrintHerhaald(string tekst)  // overbodig geworden
        //{
        //    PrintHerhaald(tekst, 2);
        //}
        static void PrintHerhaald(string tekst, int aantal = 2)
        {
            string herhaaldeTekst = "";
            for (int teller = 1; teller <= aantal; teller++)
            {
                herhaaldeTekst += tekst;
            }
            Console.WriteLine(herhaaldeTekst);
        }

    }
}
