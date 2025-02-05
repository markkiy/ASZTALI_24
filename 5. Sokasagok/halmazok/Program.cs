using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmazok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 4, 0, 1, 2, 2, 1, 2 };



            HashSet<string> v1 = new HashSet<string> { "Bence", "Réka", "Máté", "Pisti", "Johanna", "Kata" };
            HashSet<string> v2 = new HashSet<string> { "Máté", "Zalán", "Csaba", "Kata", "Bence" };



            kiir("1. verseny: ", v1);
            kiir("2. verseny: ",v2);
            kiir("Minkettő: ", Metszet(v1, v2));


        }

        private static HashSet<string> Metszet(HashSet<string> v1, HashSet<string> v2)
        {
            HashSet<string> metszet = new HashSet<string>();

            foreach (string elem in v1)
            {
                if (v2.Contains(elem))
                {
                    metszet.Add(elem);
                }
            }


            return metszet;
        }

        static void kiir(string szöveg, HashSet<string> nevek)
        {
                Console.Write(szöveg);
                foreach (string elem in nevek)
                {
                    Console.Write(elem + " ");
                }
            Console.WriteLine();
                
        }
    }
}
