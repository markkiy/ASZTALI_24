using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a paramétereket");

            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());



            int D = b * b - 4 * a * c;


            if (D > 0)
            {
                Console.WriteLine("2 valós megoldása van");

            }
            else if (D < 0)
            {
                Console.WriteLine("Nincs megoldása");
            }
            else
            {
                Console.WriteLine("1 valós megoldása van");
            }

            Console.ReadKey();
        }
    }
}
