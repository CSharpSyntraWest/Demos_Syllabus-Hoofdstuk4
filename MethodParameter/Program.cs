using System;

namespace MethodParameter
{
    class Program
    {
        static void PrintFoutmelding(string melding)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(melding);
            Console.WriteLine();
            ResetConsoleKleuren();
        }
        static void Main()
        {
            ResetConsoleKleuren();
            do
            {
                PrintMenu();
                string menuOptie = Console.ReadLine();
                while ((menuOptie != "1") && (menuOptie != "2"))
                {
                    PrintFoutmelding("Gelieve een bestaande menu-optie uit te kiezen!");
                    PrintMenu();
                    menuOptie = Console.ReadLine();
                }

                Console.Write("Om-te-zetten waarde?: ");
                double getal;
                while (!double.TryParse(Console.ReadLine(), out getal))
                {
                    PrintFoutmelding("Gelieve een getal in te voeren!");
                    Console.Write("Om-te-zetten waarde?: ");
                }

                if (menuOptie == "1")
                { Console.WriteLine($"{getal} centimeter is {getal * 0.3937} inch.\n"); }
                else //if (menuOptie == "2")
                { Console.WriteLine($"{getal} inch is {getal * 2.54} centimeter.\n"); }
            } while (true);
        }
        static void PrintMenu()
        {
            Console.WriteLine("Omzetting:");
            Console.WriteLine("1) centimeter -> inch");
            Console.WriteLine("2) inch -> centimeter");
            Console.Write("Keuze (1/2)?: ");
        }
        static void ResetConsoleKleuren()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }

}

