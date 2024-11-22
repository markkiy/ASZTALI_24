using System;

namespace négyzetszám
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A feladat: ");
            for (int i= 0; i < n; i++) Console.Write($"{i*i} ");





            Console.WriteLine("\nB feladat:");
            int j = 0;

            while (j*j < n)
            {
                Console.Write($"{j * j} ");
                j++;
            }


            Console.WriteLine("\nC feladat:");
            int k = 0;
            int negyzet = k * k;

            while (negyzet < n)
            {
                Console.Write($"{j * j} ");
                k++;
                negyzet = k * k;
            }

            Console.ReadKey();
        }
    }
}
