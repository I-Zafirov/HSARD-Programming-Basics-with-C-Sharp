using System;

namespace SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            
            bool prime = true;
            int delitel = 2;
            int maxdelitel = (int)Math.Sqrt(num);

            while (prime && (delitel <= maxdelitel))
            {
                if (num % delitel == 0)
                {
                    prime = false;
                    delitel++;
                }
                Console.WriteLine("It is prime number? {0}", prime);
            }
        }
    }
}
