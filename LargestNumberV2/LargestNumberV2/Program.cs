using System;

namespace LargestNumberV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input number 2: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input number 2: ");
            int c = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Input number 3: ");
            int d = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Input number 4: ");
            int e = int.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine("The largest number is:{0}", a);
        }
    }
}
