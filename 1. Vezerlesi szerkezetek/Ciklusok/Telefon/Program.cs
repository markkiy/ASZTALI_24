using System;

namespace Telefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Irjuk ki n-szer, hogy nem mobilozunk az iskolában!
            Console.Write("N értéke: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) Console.WriteLine($"{i}. \t Ne mobilozz az iskolában!");

            int j = 0;
            while (j < n)
            {
                Console.WriteLine($"{j}. Ne mobilozz az iskolában!");
                j++;
            }
            

            Console.ReadKey();
        }
    }
}
