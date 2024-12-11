using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljárások
{
    internal class Program
    {

        static void Kiir(string s)
        {

            Random r = new Random();
            int szam = r.Next(3, 10);

            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(s);
                
            }
        }

        static void Beolvas(out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
        }

        static void Duplaz(ref int a)
        {
            if (a % 2 != 0)
            {
                a += 2;
            }
        }


        static void Novel(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i]++;
            }
        }

        static void Kiir(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i] + " ");
            }
        }


        static void Main(string[] args)
        {
            Kiir("kifli");
            Kiir("alma");


            
            Beolvas(out int n);
            Console.WriteLine(n);


            int a = 7;
            Duplaz(ref a);
            Console.WriteLine($"Uj a érték{a}");




            int[] t = { 5, 7, -3 };
            Novel(t);
            Kiir(t);
        }
    }
}
