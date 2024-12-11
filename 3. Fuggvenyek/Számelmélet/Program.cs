using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számelmélet
{
    internal class Program
    {




        /*
        if (i <= n - 1)
        {
            return false;
        }
        else return true;
        */

        static bool PrimE(int n)
        {
            if (n < 2)
            {
                return false;
            }


            int i = 2;
            while (i <= Math.Sqrt(n) && !(n % i == 0))
            {
                i++;
            }
            return i > Math.Sqrt(n);
        }

        static int[] Primszamok(int[] x, out int db)
        {
            db = 0;
            int[] y = new int[1000];
            for (int i = 0; i < x.Length; i++)
            {
                if (PrimE(x[i]))
                { 
                    y[db] = x[i];
                    db++;
                }

                
            }
            return y;

        }



        static void Kiir(int[] x, int db)
        {
            Console.WriteLine("Primszámok: ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }


        static int OsztokSzama(int n)
        {

            int db = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    db++;
                }
                
            }

            return db;
        }

        static int Legalabb(int n)
        {
            int i = 0;
            while (i < n && n > 20)
            {
                i++
            }
            if (i < n)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("nincs");
            }
        } 


        static void Main(string[] args)
        {
            Console.WriteLine(PrimE(17)); // True vagy False
            Console.WriteLine(PrimE(35));
            int[] primek = Primszamok(new int[] { 7, 23, 6, 42, 73, 2, 3, 9, 1, 5 }, out int db);
            Kiir(primek, db);

            //F9 - Sokosztós
            /*
            Console.WriteLine(OsztokSzama(6)); // 4
            Console.WriteLine(OsztokSzama(1001)); // 8
            Console.WriteLine(OsztokSzama(360)); // 24
            */

            OsztokSzama(Legalabb(Primszamok()));
        }

    }
}
