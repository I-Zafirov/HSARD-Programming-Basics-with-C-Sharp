using System;

namespace SearchNumberInArray
{
    class Program
    {
        static int broi(int[] a, int n, int x)
        {
            int count = 0;

            for(int i = 0; i < n; i++)
            {
                if (a[i] == x)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] M = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input number:");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input search number:");
            int x = int.Parse(Console.ReadLine());
            int f = broi(M, 10, x);

            if (f == 0)
                Console.WriteLine("Search number is not fount!");
            else
                Console.WriteLine("The number is contained {0} times", f);
        }
    }
}
