using System;

namespace OperatorenUndBedingteAnweisungen
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Gib bitte dein Alter ein:");
            int alter = Convert.ToByte(Console.ReadLine());

            if (alter >= 18)
            {
                // Dieser Zweig wird dann ausgeführt, wenn der Ausdruck am if-Kopf true (wahr) ist
                Console.WriteLine("Du bist schon volljährig");
            }
            else
            {
                Console.WriteLine("Du bist noch minderjährig");
            }
            */

            // Bsp. eines Rechenprogramms (Grundrechenarten)

            Console.WriteLine("Gib die erste Zahl ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib die zweite Zahl ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib die Rechenart in Form von +, -, * oder / ein:");
            char op = Convert.ToChar(Console.ReadLine());

            /*
            if (op == '+')
            {
                Console.WriteLine($"Summe: {zahl1 + zahl2}");
            }
            else if (op == '-')
            {
                Console.WriteLine($"Differenz: {zahl1 - zahl2}");
            }
            else if (op == '*')
            {
                Console.WriteLine($"Produkt: {zahl1 * zahl2}");
            }
            else if (op == '/')
            {
                if (zahl2 != 0)
                {
                    Console.WriteLine($"Quotient: {zahl1 / zahl2}");
                }
                else
                {
                    Console.WriteLine("Division durch 0 nicht erlaubt.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }

            */

            // Realisierung mit switch:

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Summe: {zahl1 + zahl2}");
                    break;
                case '-':
                    Console.WriteLine($"Differenz: {zahl1 - zahl2}");
                    break;
                case '*':
                    Console.WriteLine($"Produkt: {zahl1 * zahl2}");
                    break;
                case '/':
                    if (zahl2 != 0)
                    {
                        Console.WriteLine($"Quotient: {zahl1 / zahl2}");
                    }
                    else
                    {
                        Console.WriteLine("Division durch 0 nicht erlaubt.");
                    }
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }

            // Übung:
            // Schreibt ein Programm, das euch die Himmelsrichtung ausgibt. Lest die Himmelsrichtung von der Tastatur ein.
            // Realisiert dies sowohl mit if-else-, als auch mit einem switch-Statement

            // Schreibt ein Programm zur Ausgabe der Farben ( blau, grau, grün, weiß, rot und beige). Lest die Farbe von der Tasatur ein.
            // Aus dies soll mit if-else- u. switch-Statement realisiert werden.
        }
    }
}
