using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inora, inperc, erora, erperc;
            Console.Write("Indulás óra: ");
            inora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indulás perc: ");
            inperc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Érkezés óra: ");
            erora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Érkezés perc: ");
            erperc = Convert.ToInt32(Console.ReadLine());


            int indulas = inora * 60 + inperc;

            int erkezes = erora * 60 + erperc;

            int kulonbsege = erkezes - indulas;

            int visszaora = kulonbsege / 60;
            int visszaperc = kulonbsege % 60;

            Console.WriteLine($"Utazási odő: {visszaora} óra {visszaperc} perc.");
            
            //B feladat


            int biciklivel = 4 * 60 + 3;

            if (biciklivel <= kulonbsege)
            {
                Console.WriteLine("Bickilivel gyorsabb az út!");
            }
            else
            {
                Console.WriteLine("Biciklivel nem gyorsabb az út!");
            }

            Console.ReadKey();
        }
    }
}
