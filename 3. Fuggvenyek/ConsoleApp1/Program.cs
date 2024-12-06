using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static double Kerulet(double a, double b)
        {
            return 2 * (a + b);
        }

        static bool Parose(int szam)
        {
            return szam % 2 == 0;
        }

        
        static int Max(int[] t)
        {

        }



        static void Main(string[] args)
        {
            // F1 - Kerulet
            Console.WriteLine(Kerulet(1.25,4));


            //F2 - Paros e
            Console.WriteLine(Parose(4));

            //F3 - Maximum
            Console.WriteLine(Max(new int[] { 4, 7, -3, 12, 7, 14, -1 }));
        }
    }
}
