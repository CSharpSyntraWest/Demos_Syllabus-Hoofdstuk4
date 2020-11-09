using System;
using System.Collections.Generic;

namespace NonVoidMethodReferentieOpleveren3
{
    class Program
    {
        static void Main()
        {
            List<string> belangrijkeDagen = Feestdagen();
            belangrijkeDagen.Add("Mijn verjaardag");
            belangrijkeDagen.Sort();
            Print(belangrijkeDagen);

            Console.ReadLine();
        }
        static List<string> Feestdagen()
        {
            List<string> feestdagen = new List<string> { "Pasen", "Paasmaandag", "Dag vd Arbeid", "OLH Hemelvaart",
                                                     "Pinksteren", "Pinkstermaandag", "Nationale Feestdag",
                                                     "OLV Hemelvaart", "Allerheiligen", "Wapenstilstand", "Kerstdag" };
            return feestdagen;
        }
        static void Print(List<string> lijst)
        {
            foreach (string element in lijst) Console.WriteLine(element);
        }

    }
}
