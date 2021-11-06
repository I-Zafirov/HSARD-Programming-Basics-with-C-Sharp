using System;

namespace CalculatorSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input 1 for Addition, 2 for Subtraction, 3 for Multiplication and 4 for Division");
            int oper = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input second number:");
            int num2 = int.Parse(Console.ReadLine());
            
            switch (oper)
            {
                case 1: Console.WriteLine("{0}+{1}={2}", num1, num2, (num1 + num2)); break;
                case 2: Console.WriteLine("{0}-{1}={2}", num1, num2, (num1 - num2)); break;
                case 3: Console.WriteLine("{0}*{1}={2}", num1, num2, (num1 * num2)); break;
                case 4: Console.WriteLine("{0}/{1}={2}", num1, num2, (num1 / num2)); break;
                default: Console.WriteLine("Error!"); break;
            }
        }
    }
}