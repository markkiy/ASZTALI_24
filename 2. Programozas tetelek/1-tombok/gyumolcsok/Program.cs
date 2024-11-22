using System;

namespace gyumolcsok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gyümölcsök: ");

            string[] gyumolcsok = { "alma", "banán", "citrom", "mangó" };

            Console.WriteLine(gyumolcsok[0]);
            Console.WriteLine(gyumolcsok[1]);
            Console.WriteLine(gyumolcsok[2]);
            Console.WriteLine(gyumolcsok[3]);




            //b)
            Console.WriteLine("B feladat: ");


            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                Console.WriteLine(gyumolcsok[i]);
            }

            Console.ReadKey();
        }
    }
}
