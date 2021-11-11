using System;

namespace AreaAndPerimeterOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double S;
            double P;
            
            Console.WriteLine("input a");
            a = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("input b");
            b = Double.Parse(Console.ReadLine());
           
            Console.WriteLine("Area(S)={0}; Perimeter(P)={1}", S = (a * b), P = (2 * (a + b)));
        }
    }
}
