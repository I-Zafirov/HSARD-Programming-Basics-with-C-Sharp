using System;

namespace SumOfNumbersFrom1To50DivisibleBy3And4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for (int i = 1; i <= 50; i++)
            {
                if (i % 12 == 0)
                    sum = sum + 1; //sum++
            }
            Console.WriteLine("Sum= {0}", sum);
        }
    }
}
