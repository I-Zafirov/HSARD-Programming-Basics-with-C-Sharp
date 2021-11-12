using System;

namespace AreaAndPerimetarOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, S, P;

            Console.WriteLine("input a");
            a = Double.Parse(Console.ReadLine());

            S = a * a;
            P = 4 * a;

            Console.WriteLine("Area = {0}; Perimetar = {1}", S, P);
        }
    }
}
