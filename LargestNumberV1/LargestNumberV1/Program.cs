using System;

namespace LargestNumberV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number 1:");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("input number 2:");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("input number 3:");
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine("input number 4:");
            int d = int.Parse(Console.ReadLine());
            
            Console.WriteLine("input number 5");
            int e = int.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
                Console.WriteLine("The largest number is:{0}", a);
            else
                if (b > a && b > c && b > d && b > e)
                Console.WriteLine("The largest number is:{0}", b);
            else
                if (c > a && c > b && c > d && c > e)
                Console.WriteLine("The largest number is:{0}", c);
            else
                if (d > a && d > b && d > c && d > e)
                Console.WriteLine("The largest number is:{0}", d);
            else
                if (e > a && e > b && e > c && e > d)
                Console.WriteLine("The largest number is:", e);
        }
    }
}
