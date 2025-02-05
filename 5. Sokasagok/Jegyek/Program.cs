using System;
using System.Collections.Generic;

namespace Jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> halo = new List<List<int>>();
            Beolvas(halo);



            Kiir(halo);

            Console.Write("Tanulók átlagai: ");
            Atlag(halo);

        }

        private static void Atlag(List<List<int>> halo)
        {
            for (int i = 0; i < halo.Count; i++)
            {
                double osszeg = 0;
                double atlag = 0;
                for (int j = 0; j < halo[i].Count; j++)
                {
                    osszeg += halo[i][j];
                    atlag = osszeg / halo[i].Count;
                                        
                }
                Console.Write($"{Math.Round(atlag)} ");
            }
        }

        private static void Kiir(List<List<int>> halo)
        {
            for (int i = 0; i < halo.Count; i++)
            {
                Console.Write($"{i + 1}. tanuló: ");
                for (int j = 0; j < halo[i].Count; j++)
                {
                    Console.Write(halo[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Beolvas(List<List<int>> halo)
        {

             int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> tanulo = new List<int>();
                string[] sor = Console.ReadLine().Split(' ');
                foreach (string jegy in sor)
                {
                    tanulo.Add(int.Parse(jegy));
                }

                halo.Add(tanulo);

            }
        }
    }
}
    