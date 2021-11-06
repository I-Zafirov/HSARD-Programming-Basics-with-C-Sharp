using System;

namespace NumbersInIntervalNToMDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter m (m>n): ");
            int m = int.Parse(Console.ReadLine());

            int p = 1;

            do
            {
                p = p * n;
                n++;
            }
            while (n <= m);
            Console.WriteLine("Произведение= {0}", p);
        }
    }
}
