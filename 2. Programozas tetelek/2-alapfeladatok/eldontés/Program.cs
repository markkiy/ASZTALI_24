﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 5, 7, 2, 2, 9, -1, 4, -3, 9, 3, 2, 1 };
            int n = x.Length;

            int i = 0;
            while (i < n && !(x[i] < 0))
            {
                i++;
            }

            if (i < n)
            {
                Console.WriteLine("Van benne negatív elem");
            }
            else
            {
                Console.WriteLine("Nincs benne negatív elem");
            }

            Console.ReadKey();
        }
    }
}
