using System;

namespace kockadobás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            long n = Convert.ToInt64(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int a = r.Next(1, 7);
                Console.WriteLine($"{i}. szamu dobas: {a}");
                a = r.Next(1, 6);
            }
            


            Console.WriteLine("Dobások 6 ig:");

            int b;
            do
            {
                b = r.Next(1, 7);
                Console.Write(b + " ");
            } while (b != 6);



            Console.ReadKey();

        }
    }
}
