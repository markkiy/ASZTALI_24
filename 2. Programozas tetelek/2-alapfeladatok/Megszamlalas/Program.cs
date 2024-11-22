using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megszamlalas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 5, 7, 2, 2, 9, -1, 4, -3, 9, 3, 2, 1 };

            int osszeg = 1;
            int db = 0;

            for (int i = 0; i < x.Length; i++)
            {

                if (x[i] % 2 == 0)
                {
                    db++;
                    osszeg *= x[i];
                }
            }

            Console.WriteLine($"{db} páros szám van!");
            Console.WriteLine($"Páros számok összege: {osszeg}");


 

            int maxe = x[0];
            int maxi = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > maxe)
                {
                    maxi = i;
                    maxe = x[i];
                }
            }

            Console.WriteLine($"A legnagyobb elem: {maxe}");
            Console.WriteLine($"A legnagyobb érték sorszáma: {maxi + 1}");




            //Legnagyobb elem hátulrol


            int maxertek = x[x.Length -1];
            int maxindex = x.Length-1;

            for (int i = x.Length -2; i >=0; i--)
            {
                if (x[i] > maxertek)
                {
                    maxindex = i;
                    maxertek = x[i];
                }
            }

            Console.WriteLine($"A legnagyobb elem: {maxertek}");
            Console.WriteLine($"A legnagyobb érték sorszáma: {maxindex + 1}");



            Console.ReadKey();
        }
    }
}
