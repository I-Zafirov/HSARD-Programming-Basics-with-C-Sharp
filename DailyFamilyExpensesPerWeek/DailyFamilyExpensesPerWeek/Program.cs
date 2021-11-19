using System;

namespace DailyFamilyExpensesPerWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] M = new double[7];
            Console.WriteLine("Input daily family expenses per week:");

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine("Input expenses per day");
                M[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0.0d;

            for(int i = 0; i < 7; i++)
            {
                sum += M[i];
                Console.WriteLine("\n");
                Console.WriteLine(sum);
            }
        }
    }
}
