using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Podaj swój wiek");
            string wiek;
            wiek = Console.ReadLine();

            Console.WriteLine("jak masz na imię");
            string imie;
            imie = Console.ReadLine();

            Console.WriteLine("Cześć " + imie + "fajnie że masz " + wiek + "lat.");
        }
    }
}