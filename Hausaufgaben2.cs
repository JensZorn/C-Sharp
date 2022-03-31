using System;

namespace ZweiDimArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ein-Dim-Array
            // string[] fruechte = { "Bananen", "Äpfel", "Aprikosen", "Birnen" };

            // Zwei-Dim-Array
            // string[,] p = new string[4, 3];
            // string[,] personen =
            // {
            //    { "Axel", "Müller", "Elektriker" },
            //    { "Sabine", "Sauer", "Buchhaltung" },
            //    { "Anton", "Müller", "Busfahrer" },
            //    { "Silke", "Braun", "Programmiererin" }
            //};

            //Console.WriteLine(personen[3, 2]);

            // Ausgabe der Elemente von personen
            //Console.WriteLine(personen.GetLength(0));

            // Mit der äußeren Schleife wird das Array zeilenweise durchlaufen
            //for (int zeile = 0; zeile < personen.GetLength(0); zeile++)
            //{
            //    // Mit der inneren Schleife wird das Array spaltenweise durchlaufen
            //    for (int spalte = 0; spalte < personen.GetLength(1); spalte++)
            //    {
            //        Console.Write(personen[zeile, spalte] + "\t");
            //    }
            //    // Zeilenumbruch
            //    Console.WriteLine();
            //}

            // Übung:
            // Folgendes Array sein gegeben:
            string[,] laender = {
                { "Deutschland", "Berlin", "Steinmeyer"},
                { "Frankreich", "Paris", "Macron"},
                { "Spanien", "Madrid", "Phillipe"},
                { "Dänemark", "Kopenhagen", "Mette"}
                };

            // Gebt das Array zeilenweise mit einer while-Schleife aus
            // Sucht nach dem Begriff "Frankreich" und ersetzt ihn durch "Grand Nation"
            //

            int mrow = laender.GetLength(0);
            int mcol = laender.GetLength(1);
            int row = 0;
            while (row<mrow)
            {
              int col = 0;
              while(col<mcol)
              {
                if(laender[row,col]=="Frankreich")
                {
                  Console.Write("Grand Nation ");
                } else {
                  Console.Write(laender[row,col]+" ");
                }
                col++;
              }
              Console.WriteLine("");
              row++;
            }

        }
    }
}
