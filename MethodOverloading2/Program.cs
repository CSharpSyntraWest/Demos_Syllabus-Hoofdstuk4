using System;

namespace MethodOverloading2
{
    class Program
    {
        static void Main()
        {
            char karakter1 = 'X';

            PrintHerhaald(karakter1);

            string tekst1 = "Hallo";

            PrintHerhaald(tekst1);
            PrintHerhaald(tekst1, 5);

            Console.ReadLine();
        }
        static void PrintHerhaald(char karakter)
        {
            PrintHerhaald(karakter.ToString());
        }
        static void PrintHerhaald(string tekst)
        {
            Console.WriteLine(tekst + tekst);
        }
        static void PrintHerhaald(string tekst, int aantal)
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
