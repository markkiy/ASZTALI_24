using System;

namespace osztók
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n:");
            int szam = Convert.ToInt32(Console.ReadLine());

            /*
            while (szam <= 0)
            {
                Console.Write("nemjo add meg ujra: :");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            */

            do
            {
                Console.Write("n:");
                szam = Convert.ToInt32(Console.ReadLine());
            } while(szam <= 0);


            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
