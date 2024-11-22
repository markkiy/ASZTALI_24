using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace érmedobás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 50;

            Random r = new Random();

            int dbFdb = 0, dbIdb = 0;


            for (int i = 0; i < n; i++)
            {
                int a = r.Next(1, 3);
                
                if(a == 1)
                {
                    Console.Write($"F, ");
                    dbFdb++;
                }
                else
                {
                    Console.Write($"I, ");
                    dbIdb++;
                }
            }


            Console.WriteLine($"Fejek száma: {dbFdb}");
            Console.WriteLine($"Fejek száma: {dbIdb}");

            // B feladat:

            Console.WriteLine("B feladat: ");

            int db = 0;

            do
            {
                int dobas = r.Next(1, 3);
                if (dobas == 1)
                {
                    Console.Write($"F, ");
                    db = 0;
                }
                else
                {
                    Console.Write($"I, ");
                    db++;
                }
            } while (db != 0);



            Console.ReadKey();
        }
    }
}
