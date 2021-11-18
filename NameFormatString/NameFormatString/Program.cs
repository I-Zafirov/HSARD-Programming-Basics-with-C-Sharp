using System;

namespace NameFormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Name:");
            String s = Console.ReadLine(); //Ivan Emov Ivanov
            
            int k1 = s.IndexOf(' '); //k1=4
            String r1 = s.Substring(0, k1); //Ivan
            String s1 = s.Substring(k1 + 1); //s1 = Emov Ivanov
            int k2 = s1.IndexOf(' '); //k2 = 11
            String s2 = s1.Substring(k2 + 1); //s2 = Ivanov
            String r = r1 + " " + s1[0] + ". " + s2; //s1[0] = E
            Console.WriteLine(r); //Ivan E. Ivanov
        }
    }
}
