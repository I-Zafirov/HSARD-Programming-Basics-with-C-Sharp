using System;

namespace ParameterTransmissionMechanism
{
    class RefExample
    {
        static void Method(ref int i, int j)
        {
            i = i + 44;
            j = j + 44;
        }
        static void Main(string[] args)
        {
            {
                int val1 = 1;
                int val2 = 1;
                Method(ref val1, val2);     // val1 трябва да е инициализирана преди да се подаде
                
                Console.WriteLine("val1 = {0}; val2 = {1}", val1, val2);       // Output: val1=45; val2=1  
            }

        }
    }
}
