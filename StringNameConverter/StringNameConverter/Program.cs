using System;

namespace StringNameConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string(Name): ");
            String s = Console.ReadLine();
            int k1 = s.IndexOf(" ");
            String r1 = s.Substring(0, k1);
            String s1 = s.Substring(k1 + 1);
            int k2 = s1.IndexOf(" ");
            String s2 = s1.Substring(k2 + 1);
            String r = r1 + " " + s1[0] + ". " + s2;
            Console.WriteLine(r);
        }
    }
}
