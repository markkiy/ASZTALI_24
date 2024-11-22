using System;

namespace BeolvasKiir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0. Irjuk ki, hogy Halo
            //Console.WriteLine("Halo");


            //
            //1 1 1 1 11 1 1 1 1 1
            //
            /*
            string vnev, knev;
            Console.Write("Vezetéknév: ");
            vnev = Console.ReadLine();
            Console.Write("Keresztnév: ");
            knev = Console.ReadLine();

            Console.WriteLine("Szia " + vnev + " " + knev + "!");
            Console.WriteLine("Szia {0} {1}!", vnev, knev);
            Console.WriteLine($"Szia {vnev} {knev}!");
            */




            //double a, b;
            //Console.Write("a: ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b: ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Terület: {a*b}");


            // Implicit konverzió
            // double x = 1.4;


            // 3.Feladat(Hányados)

            int a,b;
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hányadosuk: {Convert.ToDouble(a) / Convert.ToDouble(b)}");
            Console.WriteLine($"Hányadosuk: {Convert.ToDouble(a) / b}");
            Console.WriteLine($"Hányadosuk: {(double)a / b}");
            Console.WriteLine($"Hányadosuk: {1.0 * a / b}");
            Console.WriteLine($"Hányadosuk: {1d * a / b:0.000}");

            Console.ReadKey();
        }
    }
}
