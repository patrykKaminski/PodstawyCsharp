using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class przedzial
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj minimalną wartość");
            a = int.Parse(Console.ReadLine());
            while (!(int.TryParse(Console.ReadLine(), out a) && (int.TryParse(Console.ReadLine(), out b)))) //do poprawy
                Console.WriteLine("zle");
            Console.WriteLine("podaj wartość maksymalną");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("losowa suma to " + suma.add(a, b)); // przy pomocy add. odwołuję się do classy suma

            Console.ReadLine(); 
        }
    }

    class suma4

    {
        public static int add(int a, int b)  // ograniczam klasę do int a i b podanych w konsoli
        {
            Random los = new Random();
            int al = los.Next(a, b); // odwołuję się to int a i b podanych do konsoli przez użytkownika
            int bl = los.Next(a, b);
            return al + bl;

           
        }
        
    }
    
}
