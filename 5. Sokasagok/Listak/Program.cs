using System;

namespace Listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tomb
            int[] tomb = { 3, 12, -7, 1, 5 };
            Kiir(tomb);


            string[] autok = { "Audi", "Nissan", "Honda", "Toyota" };

            Kiir(autok);
        }

        static void Kiir(string[] autok)
        {
            foreach (string auto in autok)
            {
                Console.WriteLine(auto);
            }
        }

        static void Kiir(int[] tomb)
        {
            foreach (int elem in tomb)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
