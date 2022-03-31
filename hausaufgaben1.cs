///////////////////////////////////////////////////////////////////////////////
// -*- coding: UTF-8 -*-
//
//
//               Main menu for my small projects
//
//               by Jens Zorn
//
//
//               Additional information can be found in tmps.py
//
//
//
// <°))))><
///////////////////////////////////////////////////////////////////////////////
using System;

namespace Hausaufgaben
{
  class test
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine(
@"Willkommen im Menü des Hausaufgaben-Programm!

Bitte wähle aus folgenden Hausaufgaben aus:

1. For-Schleife, die von 20 bis 50 zählt.
2. Programm zur Ausgabe der Himmelsrichtungen (Switch-Statement)
3. Programm zur Ausgabe von Farben (If-Else-Statement)

Bitte um Verzeihung, dass ich Nummer 2. & 3. jeweils nur mit einer Methode erstellt habe.
Bitte Auswahl eingeben (1, 2, 3, oder exit):");
        string Eingabe = Console.ReadLine();

        if(Eingabe=="exit")
        {
          break;
        } else if(Eingabe=="1")
        {
          for (int i = 0; i < 31; i++)
          {
            Console.WriteLine(i + 20);
          }
        } else if(Eingabe=="2")
        {
          while(true){
            Console.WriteLine("Alles klar, dann gib mal ein, welche Himmelsrichtung es sein darf (N, S, O, W, oder exit):");
            string hr = Console.ReadLine();
            if (hr == "exit")
            {
              break;
            }
            switch (hr)
            {
              case "N":
                Console.WriteLine("Du magst den Norden!");
                break;
              case "S":
                Console.WriteLine("Du magst den Süden!");
                break;
              case "O":
                Console.WriteLine("Du magst den Osten!");
                break;
              case "W":
                Console.WriteLine("Du magst den Westen!");
                break;
              default:
                Console.WriteLine("Da war was falsch. Nochmal!");
                break;
              }
          }
        } else if(Eingabe=="3")
        {
          while(true)
          {
            Console.WriteLine("Farben sollen es sein. Dann leg mal los! blau, grau, grün, weiß, rot oder beige (oder exit)?");
            string farbe = Console.ReadLine();
            if(farbe=="exit")
            {
              break;
            } else if (farbe == "blau")
            {
              Console.WriteLine("Du magst blau!");
            } else if (farbe == "grau")
            {
              Console.WriteLine("Du magst grau!");
            } else if (farbe == "grün")
            {
              Console.WriteLine("Du magst grün!");
            } else if (farbe == "weiß")
            {
              Console.WriteLine("Du magst weiß!");
            } else if (farbe == "rot")
            {
              Console.WriteLine("Du magst rot!");
            } else if (farbe == "beige")
            {
              Console.WriteLine("Du magst beige!");
            } else
            {
              Console.WriteLine("Das war nichts, neuer Versuch.");
            }
          }
        } else
        {
          Console.WriteLine("");
          Console.WriteLine("Eingabe nicht verstanden, neuer Versuch!");
        }
      }
    }
  }
}
