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
        }
    }
}
