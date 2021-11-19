using System;

namespace SumNumberArray
{
    class Program
    {
        static void input(int[]a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Input number:");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Sum(int[]b, int a)
        {
            int s = 0;

            for(int i = 0; i < a; i++)
            {
                s += b[i];
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            int[] c = new int[10];
            input(c, 10);

            Sum(c, 10);
        }
    }
}
