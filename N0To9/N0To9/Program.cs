using System;

namespace N0To9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
             for(int i = 0; i < 10; i++)
            {
                A[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
