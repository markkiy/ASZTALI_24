using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ne = 22;
            string eredmeny = "";
            while(ne != 0)
            {
                int maradek = ne % 2;
                ne /= 2;
                eredmeny = maradek + eredmeny;

                

            }

            Console.WriteLine($"2-es számrendszerben: {eredmeny}");

            Console.ReadKey();
        }
    }

}
