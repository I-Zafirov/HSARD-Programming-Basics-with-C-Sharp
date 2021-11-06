using System;

namespace AverangeNumbersDivide3Of7To70
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int aver = 0;
            
            for (int i = 7; i <= 70; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + 1;
                    count++;
                }
            }
            aver = sum / count;
            Console.WriteLine("Averange={0}", aver);
        }
    }
}
