using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace repter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nevek = {
                "Kovács Anna", "Nagy Péter", "Szabó Éva", "Tóth Márk",
                "Kiss Júlia", "Molnár Tamás", "Farkas Dóra", "Horváth István",
                "Varga Krisztina", "Simon Balázs", "Lukács Zoltán", "Takács Emese" };
            double[] tomegek = { 22.3, 12, 7.5, 18.44, 35, 28, 14.12, 8, 16.9, 5.8, 30, 24 };

            int i;

            // F1 - Minimum kiválasztás

            int mini = 0;

            for (i = 1; i < tomegek.Length; i++)
            {
                if (tomegek[i] < tomegek[mini])
                {
                    mini = i;
                }

            }


            Console.WriteLine($"{nevek[mini]} utas csomagja a legkönnyebb!");


            // F2 - Keresés = Eldontés + kiválasztás

            i = 0;
            while (i < tomegek.Length && !(tomegek[i] > 30));
            {
                i++;
            }
            if (i < tomegek.Length)
            {
                Console.WriteLine($"2.{nevek[i]}");
            }
            else Console.WriteLine("Nincs ilyen csomag");


            Console.ReadKey();

        }
    }
}
