using System;

namespace AreaAndPerimeterOfSquareAndRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: 1 for Square or 2 for Rectangle");
            byte num = byte.Parse(Console.ReadLine());
            
            if (num == 1)
            {
                Console.WriteLine("side length =");
                byte side = byte.Parse(Console.ReadLine());
                
                Console.WriteLine("Perimeter P = {0}; Area S = {1}", (4 * side), (side * side));
            }
            else if (num == 2)
            {
                Console.WriteLine("Input length side a =");
                byte sidea = byte.Parse(Console.ReadLine());
                
                Console.WriteLine("Input lenght side b =");
                byte sideb = byte.Parse(Console.ReadLine());
                
                Console.WriteLine("Area S = {0}; Perimeter P = {1}", (sidea * sideb), (2 * sidea + 2 * sideb));
            }
            else
            {
                Console.WriteLine("Error!!!");
            }
        }
    }
}
