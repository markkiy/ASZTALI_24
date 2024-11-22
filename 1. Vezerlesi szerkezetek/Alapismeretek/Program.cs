using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idokonverzio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int ora = r.Next(24);
            int perc = r.Next(60);
            int mp = r.Next(60);
            Console.WriteLine($"Idö: {ora:00}:{perc:00}:{mp:00}");

            int masodperc = ora * 3600 + perc * 60 + mp;
            Console.WriteLine($"A nap eleje ota {masodperc} mp telt el");

            int hour = masodperc / 3600;
            int maradek = masodperc % 3600;
            int minute = maradek / 60;
            int second = maradek % 60;

            Console.WriteLine($"Visszaváltva: {hour} óra {minute} perc {second} masodperc.");

            Console.ReadKey();
        }
    }
}
