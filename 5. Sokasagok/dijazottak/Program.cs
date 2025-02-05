using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijazottak
{
    internal class Program
    {

        static void Beolvas(List<string> nevek, List<int> pontok, out int maxpont)
        {
            string[] sor = Console.ReadLine().Split(' ');
            maxpont = int.Parse(sor[1]);
            int n = int.Parse(sor[0]);
            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(';');
                nevek.Add(sor[0]);
                pontok.Add(int.Parse(sor[1]));
            }
        }


        static void Szetvalogatas(List<string> nevek, List<int> pontok, int maxpont, List<string> a, List<string> b, List<string> c, List<string> d)
        {
            for (int i = 0; i < pontok.Count; i++)
            {
                double szazalek = (double)pontok[i] / maxpont * 100;
                if (szazalek >= 90)
                {
                    a.Add(nevek[i]);
                }
                else if (szazalek >= 80)
                {
                    b.Add(nevek[i]);
                }
                else if (szazalek >= 70)
                {
                    c.Add(nevek[i]);
                }
                else
                {
                    d.Add(nevek[i]);
                }
            }
        }


        static void Kiir(List<string> nevek)
        {
            Console.Write(nevek.Count + ";");
            foreach (string nev in nevek)
            {
                Console.Write(nev + ";");
            }
            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<int> pontok = new List<int>();
            Beolvas(nevek, pontok, out int maxpont);

            List<string> a = new List<string>(); // I. díjasok
            List<string> b = new List<string>(); // II. díjasok
            List<string> c = new List<string>(); // III. díjasok
            List<string> d = new List<string>(); // nem díjasok
            Szetvalogatas(nevek, pontok, maxpont, a, b, c, d);

            Kiir(a);
            Kiir(b);
            Kiir(c);
            Kiir(d);
        }
    }
}
