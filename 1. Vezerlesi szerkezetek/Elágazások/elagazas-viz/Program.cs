using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazas_viz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hömérséklet: ");
            double homerseklet = Convert.ToDouble(Console.ReadLine());


            string halmazallapot;

            if (homerseklet <= 0)
            {
                halmazallapot = "szilárd";
            }
            else if (homerseklet <= 100)
            {
                halmazallapot = "folyékony";
            }
            else
            {
                halmazallapot = "gáz";
            }

            Console.WriteLine($"A víz {halmazallapot} halmazállapotú");

            Console.ReadKey();
        }
    }
}
