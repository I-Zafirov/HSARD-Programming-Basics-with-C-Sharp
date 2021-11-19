using System;

namespace TextInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            string text1 = " ";

            Console.WriteLine("Text in reverse order:");

            for(int i = text.Length - 1; i >= 0; i--)
            {
                text1 += text[i];
            }
            Console.WriteLine(text1);
        }
    }
}
