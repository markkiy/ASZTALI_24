using System;


namespace Elozonelhuvosebb
{
    internal class Program
    {

        static void Beolvas(int[,] h, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' '); 
            n = Convert.ToInt32(sor[0]); 
            m = Convert.ToInt32(sor[1]); 
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine(); 
                sor = s.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    h[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }

        static void Main(string[] args)
        {
            int n, m;
            int[,] h = new int[1000, 1000];
            Beolvas(h, out n, out m);

            Eldont(h, n, m);
        }

        private static void Eldont(int[,] h, int n, int m)
        {
            int i = 0;
            while (i < m && h[n,i] < h[n,i-1])
            {

            }
        }
    }
}
