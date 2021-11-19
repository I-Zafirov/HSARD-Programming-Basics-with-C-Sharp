using System;

namespace NameFormatString1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Name:");
            String name = Console.ReadLine();
            int k1 = name.IndexOf(' ');
            String r1 = name.Substring(0, k1);
            String name1 = name.Substring(k1 + 1);
            int k2 = name1.IndexOf(' ');
            String name2 = name1.Substring(k2 + 1);
            String r = r1[0] + ". " + name1[0] + name1[1] + ". " + name2;
            Console.WriteLine(r);
        }
    }
}
