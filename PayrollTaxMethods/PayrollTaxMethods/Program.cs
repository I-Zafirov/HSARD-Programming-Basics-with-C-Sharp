using System;

namespace PayrollTaxMethods
{
    class Program
    {
        static public double dan(double z)
        {
            return z * 0.1;
        }
        static void Main(string[] args)
        {
            int P = 1;
            for (int i = 1; i <= 100; i++)
                P *= i;
            Console.WriteLine("P = {0}", P);
        }
    }
}
