using System;

namespace SumOfFractionalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            
            for (int i = 2, j = 3; i <= 19; i++, j++)
                sum = sum + (1 / (double)(i * j));
            {
                Console.WriteLine("Sum= {0}", sum);
            }
        }
    }
}
