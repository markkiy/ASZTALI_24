using System;


namespace páratlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int szam;

            string szamok = "";


            for (int i = 0; i < 7; i++)
            {
                szam = r.Next(5);
                szam = (szam * 2) + 1;
                szamok += Convert.ToString(szam);
            }

            Console.Write($"Generált 7 jegyű szám: {szamok}");
            Console.ReadKey();

        }
    }
}
