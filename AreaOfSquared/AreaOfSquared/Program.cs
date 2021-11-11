using System;

namespace AreaOfSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0;
            double b = 0.0;
            double S = a * b;
            
            Console.WriteLine("input a");
            a = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("input b");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine("S={0}", S);
        }
    }
}
