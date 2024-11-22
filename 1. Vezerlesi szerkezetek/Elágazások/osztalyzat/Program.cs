using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyzat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int oszt = r.Next(1, 6);

            Console.WriteLine($"Az osztályzat: {oszt}");
            /*
                    if (oszt == 1) Console.WriteLine("Elégtelen");
                    else if (oszt == 2) Console.WriteLine("Elégséges");
                    else if (oszt == 3) Console.WriteLine("Közepes");
                    else if (oszt == 4) Console.WriteLine("Jó");
                    else if (oszt == 5) Console.WriteLine("Jeles");
            */

            switch (oszt)
            {
                case 1:
                    Console.WriteLine("Elégtelen");
                    break;
                case 2:
                    Console.WriteLine("Elégséges");
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    break;
                case 4:
                    Console.WriteLine("Jó");
                    break;
                case 5:
                    Console.WriteLine("Jeles");
                    break;
            }

            Console.ReadKey();
        }
    }
}
