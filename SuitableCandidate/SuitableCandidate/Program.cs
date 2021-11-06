using System;

namespace SuitableCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter gender (M or W): ");
            string gender = (Console.ReadLine());
            
            int bank = 0;
            int bust = 0;

            if (gender == "M")
            {
                Console.WriteLine("Enter Bank availability: ");
                bank = int.Parse(Console.ReadLine());
            }
            else if (gender == "W")
            {
                Console.WriteLine("Enter bust: ");
                bust = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Error!");
            }
            if (bank >= 250000 || bust >= 100)
            {
                Console.WriteLine("Suitable Candidate!");
            }
            else
            {
                Console.WriteLine("Unsuitable Candidate!");
            }
        }
    }
}
