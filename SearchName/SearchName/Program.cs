using System;

namespace SearchName
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] name = new String[5];
            String namex = " ";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input name:");
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("Input search name:");
            namex = Console.ReadLine();
            int n = -1;

            for (int i = 0; i < 5; i++)
            {
                if (name[i] == namex)
                    n = i;
            }
            if (n != -1)
                Console.WriteLine("The search name is in position: {0}", n + 1);
            else
                Console.WriteLine("The search name is not fount!");
        }
    }
}
