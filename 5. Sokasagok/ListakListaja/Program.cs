using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListakListaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gyumolcsok = new List<string> { "Alma", "Avokádó", "Mangó"};
            List<string> zoldsegek = new List<string> { "Zeller", "Kalarábé", "Retek", "Répa" };

            List<List<string>> etelek = new List<List<string>> { gyumolcsok, zoldsegek};


            Kiir(etelek[1]);
            Kiir(etelek);

        }
        
        private static void Kiir(List<List<string>> etelek)
        {
            for (int i = 0; i < etelek.Count; i++)
            {
                for (int j = 0; j < etelek[i].Count; j++)
                {
                    Console.WriteLine(etelek[i][j]);
                }
            }
        }

        private static void Kiir(List<string> list)
        {
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
