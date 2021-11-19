using System;

namespace NConsecutiveNnumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] M = new double[100];
            Console.WriteLine("Input the number of elements:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input element:");
                A[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Reverse order is:");
            Console.WriteLine("\n");

            for (int i = n - 1; i >= 0; i--)

            Console.WriteLine(A[i]);
        }
    }
}
