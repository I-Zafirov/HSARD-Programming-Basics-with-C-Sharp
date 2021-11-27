using System;

namespace BookSearchPublicStruct
{
    class Program
    {
        public struct Book
        {
            public string Name;
            public string Author;
            public int Year;
            public double Price;
        };
        static void BookIn(Book[] b)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input Book Name:");
                b[i].Name = Console.ReadLine();

                Console.WriteLine("Input Book Author:");
                b[i].Author = Console.ReadLine();

                Console.WriteLine("Input Book Year:");
                b[i].Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Input Book Price:");
                b[i].Price = double.Parse(Console.ReadLine());
            }
        }
        static void Names(Book[] b)
        {
            for (int i = 0; i < 10; i++)
            {
                if (b[i].Year > 2005)
                {
                    Console.WriteLine(b[i].Name, b[i].Author, b[i].Year, b[i].Price);
                }
                else
                    Console.WriteLine("Not existing book!");
            }
        }
        static void Main(string[] args)
        {
            Book[] b = new Book[10];
            BookIn(b);
            Names(b);
        }
    }
}
