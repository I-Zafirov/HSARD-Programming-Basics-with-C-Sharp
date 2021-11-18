using System;

namespace NextDayOfTheWeekEnum
{
    class Program
    {
        enum Days {Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun,};
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1-7:");
            String s = Console.ReadLine();
            byte d = Byte.Parse(s);

            if (d == 7) d = 1;
            else d++;

            Days y = (Days)d;
            
            Console.WriteLine(y);
        }
    }
}
