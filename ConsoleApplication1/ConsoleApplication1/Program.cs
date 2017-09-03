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
            Console.WriteLine("podaj wartość maksymalną");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("losowa suma to " + suma.add(a, b));

            Console.ReadLine();
        }
    }

    class suma
    {
        public static int add(int a, int b)
        {
            Random los = new Random();
            int al = los.Next(a, b);
            int bl = los.Next(a, b);
            return al + bl;

        }
        
    }
    
}
