using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boldogszamok
{
    internal class Program
    {


        static int NegyzetOsszeg(int n)
        {
            int osszeg = 0;

            while (n > 0)
            {
                int jegy = n % 10;
                osszeg += jegy * jegy;
                n = n / 10;
            }

            return osszeg;
        }


        static bool BoldogE(int n)
        {
            while (n >= 10) n = NegyzetOsszeg(n);

            return n == 7 || n == 1;
        }



        static void Main(string[] args)
        {

            string[] sor = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(sor[0]);
            int b = Convert.ToInt32(sor[1]);


            for (int i = a; i < b; i++)
            {
                if (BoldogE(i)) Console.WriteLine(i + "");

            }

        }
    }
}
