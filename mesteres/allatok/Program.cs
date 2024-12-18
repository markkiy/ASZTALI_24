using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace allatok
{
    internal class Program
    {

        static void Beolvas(string[] bal, string[] jobb, out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                bal[i] = sor[0];
                jobb[i] = sor[1];
                
            }
        }



        static bool Eleme(string s, string[] bal)
        {
            int i = 0;
            while (i < bal.Length && !(bal[i] == s))
            {
                i++;
            }
            return i < bal.Length;
        }

        static void Kivalogat(string[] bal, string[] jobb, int n, string[] allatok, out int db)
        {
            db = 0;
            for (int i = 0; i < n; i++)
            {

                if (Eleme(jobb[i], bal) && !Eleme(bal[i], allatok))
                {
                    allatok[db] = bal[i];
                    db++;
                }
            }
        }


        static void Kiir(string[] allatok, int db)
        {
            Console.WriteLine(db);
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine(allatok[i]);
            }
        }


        static void Main(string[] args)
        {
            int n;
            int db;

            string[] bal = new string[30];
            string[] jobb = new string[30];


            Beolvas(bal, jobb, out n);


            string[] allatok = new string[30];
            Kivalogat(bal, jobb, n, allatok, out db);


            Kiir(allatok, db);
        }
    }
}
