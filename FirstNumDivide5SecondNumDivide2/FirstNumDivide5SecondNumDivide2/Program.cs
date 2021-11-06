using System;

namespace FirstNumDivide5SecondNumDivide2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number=");
            int num = int.Parse(Console.ReadLine());
            
            if ((num % 10) == 5)
            {
                Console.WriteLine("Цифрата на единиците се дели на 5");
            }
            else
            {
                Console.WriteLine("Цифрата на единиците не се дели на 5");
            }
            if (((num / 10) % 2) == 0)
            {
                Console.WriteLine("Цифрат на десетиците е четно число");
            }
            else
            {
                Console.WriteLine("Цифрите на десетиците е нечетно число");
            }
        }
    }
}
