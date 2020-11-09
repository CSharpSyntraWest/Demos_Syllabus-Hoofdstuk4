using System;

namespace AllesInEénMethode
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            do
            {
                Console.WriteLine("Omzetting:");
                Console.WriteLine("1) centimeter -> inch");
                Console.WriteLine("2) inch -> centimeter");
                Console.Write("Keuze (1/2)?: ");
                string menuOptie = Console.ReadLine();
                while ((menuOptie != "1") && (menuOptie != "2"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Gelieve een bestaande menu-optie uit te kiezen!");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Omzetting:");
                    Console.WriteLine("1) centimeter -> inch");
                    Console.WriteLine("2) inch -> centimeter");
                    Console.Write("Keuze (1/2)?: ");
                    menuOptie = Console.ReadLine();
                }

                Console.Write("Om-te-zetten waarde?: ");
                double getal;
                while (!double.TryParse(Console.ReadLine(), out getal))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Gelieve een getal in te voeren!");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.Write("Om-te-zetten waarde?: ");
                }

                if (menuOptie == "1")
                { Console.WriteLine($"{getal} centimeter is {getal * 0.3937} inch.\n"); }
                else //if (menuOptie == "2")
                { Console.WriteLine($"{getal} inch is {getal * 2.54} centimeter.\n"); }
            } while (true);
        }

    }
}
