using System;

namespace Fuggvenyek
{
    internal class Program

    {

        static void Main(string[] args)
        {
            // F1
            Console.WriteLine("1. feladat:");
            Console.WriteLine(Atfogo(5, 12));
            Console.WriteLine($"{Atfogo(2, 7):0.00}");

            // F2
            Console.WriteLine("\n2. feladat:");
            int n = 5;
            Modosit(ref n);
            Console.WriteLine(n);

            //// F3
            Console.WriteLine("\n3. feladat:");

            Console.WriteLine(VanBenneA("labda"));
            Console.WriteLine(VanBenneA("Alex"));
            Console.WriteLine(VanBenneA("fekete"));

            //// F4
            string[] szavak = { "Arany", "bauxit", "vese", "kisegér", "Réka", "Baranya", "rendszergazda", "vödör" };
            string[] abetusek = KivalogatAbetusek(szavak, out int db);

            //// F5
            Console.WriteLine("\n5. feladat:");
            Kiir(abetusek, db);
        }

         static double Atfogo(double v1, double v2)
        {
            double n = Math.Sqrt(v1 * v1 + v2 * v2);

            return n;
        }

        static void Modosit(ref int n)
        {
            Random r = new Random();

            if (r.Next(0, 2) == 0)
            {
                n++;
            }
            else n--;
        }

        static void Kiir(string[] abetusek, int db)
        {
            for (int i = 0; i < db - 1; i++)
            {
                Console.Write(abetusek[i] + " - ");
            }

            Console.Write(abetusek[db - 1]);
        }

        static string[] KivalogatAbetusek(string[] szavak, out int db)
        {
            string[] szav = new string[1000];

            db = 0;

            for (int i = 0; i < szavak.Length; i++)
            {
                if (VanBenneA(szavak[i]))
                {
                    szav[db] = szavak[i];
                    db++;
                }
            }

            return szav;
        }


        static bool VanBenneA(string v)
        {
            
            int i = 0;

            while (i< v.Length && !(v[i] == 'a' || v[i] == 'A'))
            {
                i++;
            }

            if (i < v.Length)
            {
                return true;

            }
            else return false;
            
        }
    }
}