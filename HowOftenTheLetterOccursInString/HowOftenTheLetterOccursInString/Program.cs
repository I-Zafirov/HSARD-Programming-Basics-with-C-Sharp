using System;

namespace HowOftenTheLetterOccursInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            String s = Console.ReadLine();
            
            int[] br = new int[26];
            
            for (int i = 0; i < 26; i++) br[i] = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                int k = (int) s[i] - (int)'a';
                br[k]++;
            }
            for (int i = 0; i < 26; i++)
                Console.WriteLine("{0}:{1}", (char)(i + (int)'a'), br[i]);
        }
    }
}
