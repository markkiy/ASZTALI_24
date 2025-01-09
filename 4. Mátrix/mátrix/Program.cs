using System;

namespace mátrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = { 
                { 8, 3, 21, 4 },
                { 1, -5, 7, 13 },
                { 3, 3, 10, -1 } 
            };



            Console.WriteLine(matrix[1,2]);

            Console.WriteLine($"Elemek száma: {matrix.Length}");
            Console.WriteLine($"Sorok száma: {matrix.GetLength(0)}");
            Console.WriteLine($"Oszlopok száma: {matrix.GetLength(1)}");



            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1); 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                


                Console.WriteLine();
            }




            int db = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    db += matrix[i, j];
                }
            }


            Console.WriteLine(db);

            int maxe = matrix[0, 0];

            int elso = 0;
            int masodik = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i,j] > maxe)
                    {
                        maxe = matrix[i, j];
                        elso = i + 1;
                        masodik = j + 1;
                    }
                }
            }

            Console.WriteLine(maxe);
            Console.WriteLine($"{elso},{masodik}");




            for (int i = 0; i < n; i++)
            {
                int sorosz = 0;
                for (int j = 0; j < m; j++)
                {
                    sorosz += matrix[i, j] ;
                }
                Console.Write(sorosz + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                int oszloposz = 0;

                for (int j = 0; j < n; j++)
                {
                    oszloposz += matrix[j, i];
                }
                Console.Write(oszloposz + " ");
            }

        }
    }
}
