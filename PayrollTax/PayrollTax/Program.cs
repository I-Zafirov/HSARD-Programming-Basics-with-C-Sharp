using System;

namespace PayrollTax
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            
            Console.WriteLine("input Paymand");
            z = Double.Parse(Console.ReadLine());
            
            if (z >= 650)
            {
                Console.WriteLine("Payroll tax:{0}BGN", z * 0.1);
            }
            else
            {
                Console.WriteLine("NO Payroll tax");
            }
        }
    }
}
