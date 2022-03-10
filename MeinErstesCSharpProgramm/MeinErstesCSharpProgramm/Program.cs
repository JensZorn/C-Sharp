using System;

namespace MeinErstesCSharpProgramm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Einige Variablen definieren mit gleichzeitiger Initialisierung
            string vorname = "Axel bekannt als \"Ax\" ";
            string name = "Meier";
            int alter = 27;

            // Def.
            string beruf;

            // Initialisierung
            beruf = "Bäcker";

            // Einfache Datentypen:
            // Numerische
            int i = 5;
            float zinssatz = 5.3f; // einfache Dezimalzahl
            double temperatur = 25.6; // zweifach genau
            decimal preis = 99.1M;

            bool jaNein = false;
            char einZeichen = 'c';

            Console.WriteLine();
            Console.WriteLine($"temperatur: {temperatur / 3}");
            Console.WriteLine($"zinssatz: {zinssatz / 3}");
            Console.WriteLine($"preis: {preis / 3}");
            Console.WriteLine();


            Console.Write("{0} {1} wird heute {2} Jahre alt.", vorname, name, alter);
            //Console.WriteLine($"{vorname} {name} wird heute {alter} Jahre alt.");
        }
    }
}
