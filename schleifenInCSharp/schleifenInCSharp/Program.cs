using System;

namespace schleifenInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!");

            // Inkrement- / Dekrement-Operatoren ++ / -- (heißt jedesmal um eins erhöen / reduzieren)
            // Kurzform dieses Statements
            int a = 5;
            a++; // a wird um eins erhöht (inkrementiert)
            Console.WriteLine(a);
            a = a + 1;
            a += 1;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World!");
            //}

            // Ausgabe der Zahlen 1 bis 10:

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            // Ausgabe der Zahlen von 10 bis 1:
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // Übung: Gebt die Zahlen 20 bis einschließlich 50 mit einer Schleife aus.

        }
    }
}
