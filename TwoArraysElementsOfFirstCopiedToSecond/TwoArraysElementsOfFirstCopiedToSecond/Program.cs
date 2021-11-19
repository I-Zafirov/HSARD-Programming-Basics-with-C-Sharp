using System;

namespace TwoArraysElementsOfFirstCopiedToSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("[A{0},{1}] = {2}", i, j, A[i, j]);
                }
            }
        }
    }
}
