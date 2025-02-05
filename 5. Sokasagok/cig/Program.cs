using System;
using System.Collections.Generic;


namespace ConsoleApp1l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
        }

        static void feladat3()
        {
            List<List<int>> sza = new List<List<int>>();
            beolvas(sza);
            maximum(sza);
            Console.WriteLine(maximum(sza));
        }

        static int maximum(List<List<int>> sza)
        {
            int maxi = 0;
            int maxj = 0;
            for (int i = 0; i < sza.Count; i++)
            {

                for (int j = 0; j < sza[i].Count; j++)
                {
                    if (sza[i][j] > sza[maxi][maxj])
                    {
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            return sza[maxi][maxj];
        }

        private static void beolvas(List<List<int>> sza)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> szamok = new List<int>();
                string[] sor = Console.ReadLine().Split(' ');
                foreach (string szam in sor)
                {
                    szamok.Add(int.Parse(szam));
                }
                sza.Add(szamok);
            }
        }

        private static void feladat2()
        {
            List<string> gyumolcsok = new List<string> {"alma", "körte", "banán", "alma", "barack", "szőlő", "körte", "alma",
                "narancs", "banán", "citrom", "szilva", "barack", "alma", "mangó",
                "körte", "narancs", "szőlő", "cseresznye", "málna", "eper", "mangó",
                "kivi", "citrom", "alma", "banán", "eper", "körte", "narancs", "barack"  };
            megszamol(gyumolcsok);
            kiir(megszamol(gyumolcsok));
        }

        static void kiir<TKey, TValue>(Dictionary<TKey, TValue> szo)
        {
            Console.WriteLine();
            foreach (TKey elem in szo.Keys)
            {
                Console.WriteLine($"{elem}: {szo[elem]}");

            }
            Console.WriteLine();
        }


        

        static Dictionary<string, int> megszamol(List<string> gyumolcsok)
        {
            Dictionary<string, int> gyumi = new Dictionary<string, int>();
            foreach (string gyumolcs in gyumolcsok)
            {
                if (!gyumi.ContainsKey(gyumolcs))
                {
                    gyumi.Add(gyumolcs, 1);
                }
                else
                {
                    gyumi[gyumolcs]++;
                }
            }
            return gyumi;
        }



        static void feladat1()
        {
            HashSet<string> v1 = new HashSet<string> { "Bence", "Réka", "Máté", "Pisti", "Johanna", "Kata" };
            HashSet<string> v2 = new HashSet<string> { "Máté", "Zalán", "Csaba", "Kata", "Bence" };
            metszet(v1, v2);
            különb(v1, v2);
            kiir(különb(v1, v2));
            Console.WriteLine();
            kiir(metszet(v1, v2));

        }

        static void kiir<T>(HashSet<T> has)
        {
            foreach (T elem in has)
            {
                Console.WriteLine(elem);
            }


            

        }

        static HashSet<string> különb(HashSet<string> v1, HashSet<string> v2)
        {
            HashSet<string> kulonb = new HashSet<string>(v1);
            kulonb.ExceptWith(v2);
            return kulonb;
        }


        static HashSet<string> metszet(HashSet<string> v1, HashSet<string> v2)
        {
            HashSet<string> metsz = new HashSet<string>();
            foreach (string elem in v1)
            {
                if (v2.Contains(elem))
                {
                    metsz.Add(elem);
                }
            }
            return metsz;
        }


    }
}
