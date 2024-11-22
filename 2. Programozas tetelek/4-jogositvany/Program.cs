using System;

namespace _4_jogositvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Statikus tömbök: fordítási időben tudnunk kell a méretét!
            // EZ ÍGY NEM JÓ!!!
            // string[] nevek = new string[n];
            string[] nevek = new string[100];
            int[] korok = new int[100];
            bool[] jogsik = new bool[100]; // jogsik[i]: az i. adatnak van-e jogsija?

            // F1 - Beolvasás
            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine();
                string[] adatok = sor.Split(' ');
                nevek[i] = adatok[0];
                korok[i] = Convert.ToInt32(adatok[1]);
                jogsik[i] = adatok[2] == "I" ? true : false;

            }





            int emberek = 0;
            for (int j = 0; j < n; j++)
            {
                if (jogsik[j] == true)
                {
                    emberek++;
                } 
            }

            Console.WriteLine($"{(double)emberek / n * 100}%");

                
       

            int k = 0;
            while (!(k > n) && korok[k] <= 30 || jogsik[k] == true)
            {
                k++;
            }



            Console.WriteLine(nevek[k]);

            int fiatal = korok[0];
            int idos = korok[0];

            for (int f = 1; f < n; f++)
            {
                if (korok[f] > idos)
                {
                    idos = korok[f];
                }

                if (korok[f] < fiatal)
                {
                    fiatal = korok[f];
                }


            }


            int kulonbseg = 0;

            if (fiatal > idos)
            {
                kulonbseg = fiatal - idos;
            }
            else
            {
                kulonbseg = idos - fiatal;
            }

            Console.WriteLine(kulonbseg);


            int huszfel = 0;
            int huszle = 0;


            for (int h = 0; h < n; h++)
            {
                if (korok[h] >= 20)
                {
                    huszfel++;
                }
                else
                {
                    huszle++;
                }
            }

            if (huszfel > huszle)
            {
                Console.WriteLine("Igaz");
            }
            else
            {
                Console.WriteLine("Nem igaz");
            }




         
                
            string nev = nevek[i];
            while (i < n && !(nev[0] == 'F'))
                {
                    i++;
                }
            if (i < n)
            {
                Console.WriteLine($"Van ilyen ember: {nevek[i]}");
            }


            double osszeg = 0;
            int db = 0;

            for (i = 0; i <= n-1; i++)
            {
                osszeg += korok[i];
                db++;
            }
            Console.WriteLine($"Az utolso 10 embernek az atlag életkora: {(double)osszeg / db}");

            //Console.ReadKey();
        }
    }
}
