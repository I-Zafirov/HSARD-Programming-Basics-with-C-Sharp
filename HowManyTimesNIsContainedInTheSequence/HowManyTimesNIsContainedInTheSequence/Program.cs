using System;

namespace HowManyTimesNIsContainedInTheSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Console.WriteLine("Input number of elements (0 <= 100):");
            int m = int.Parse(Console.ReadLine());

            for(int k = 0; k < m; k++)
            {
                Console.WriteLine("Input element:");
                numbers[k] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input number N:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for(int j = 0; j < m; j++)
            {
                if (numbers[j] == n)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
