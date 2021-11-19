using System;

namespace ArrayOf10ElementsMultipliedBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            for(int i = 0; i < 10; i++)
            {
                A[i] = i * 5;
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
