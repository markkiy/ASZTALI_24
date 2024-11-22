using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitevő
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double a = 2;
            const int n = 10;


            double eredmeny = 1;

            for (int i = 0; i < n; i++)
            {
                eredmeny *= a;
            }

            Console.WriteLine($"{a}^{n} = {eredmeny}");



            Console.ReadKey();
        }
    }
}
