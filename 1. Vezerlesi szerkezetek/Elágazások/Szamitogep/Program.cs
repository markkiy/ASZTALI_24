using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamitogep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termek;
            Random r = new Random();
            termek = r.Next(230, 371);
            termek = termek * 1000;
            

            int sajatpenz;
            Console.Write("Add meg mennyi pénzed van: ");
            sajatpenz = Convert.ToInt32(Console.ReadLine());

            if(sajatpenz >= termek) Console.WriteLine("Sikeres gyüjtés!");
            else
            {
                double szazalek = ((double)sajatpenz / termek) * 100;

                Console.WriteLine($"A szükséges pénz {(int)szazalek} százaléka van meg");
            }


        




            Console.ReadKey();
        }
    }
}
