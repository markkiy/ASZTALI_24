using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromKocka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int a, b, c;

            do
            {
                a = r.Next(1, 6);
                b = r.Next(1, 6);
                c = r.Next(1, 6);
                Console.WriteLine($"{a} {b} {c} {a+b+c}");
            } while (!(a+b+c<6||a+b+c>15));
            // a+b+c>=6 && a+b+c<=15



            Console.ReadKey();
        }
    }
}
