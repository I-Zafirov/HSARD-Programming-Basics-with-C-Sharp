using System;

namespace NumbersFrom1ToNDivisibleBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 21) == 0)
                {
                    Console.WriteLine("Number= {0}", i);
                }
            }
        }
    }
}
