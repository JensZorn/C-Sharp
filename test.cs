using System;

namespace Hausaufgaben
{
    class test
    {
        static void Main(string[] args)
        {
          while (true)
          {
            Console.WriteLine("Test");
            string Eingabe = Console.ReadLine();
            if(Eingabe.Equals("exit"))
            {
              break;
            }
          }


        }
    }
}
