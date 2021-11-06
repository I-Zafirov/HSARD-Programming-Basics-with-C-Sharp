using System;

namespace NextData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Data:");
            int date = int.Parse(Console.ReadLine());
            
            int year = date % 10000;
            int month = (date / 10000) % 100;
            int day = (date / 10000) / 100;

            switch (day)
            {
                case 28:
                    {
                        if (month == 2)
                        {
                            day = 1;
                            month = 3;
                            Console.WriteLine("{0} {1} {2}", day, month, year);
                        }
                        else
                        {
                            day++;
                            Console.WriteLine("{0} {1} {2}", day, month, year);
                        }
                        break;

                    }
                case 30:
                    {
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            day = 1;
                            month++;
                            Console.WriteLine("{0} {1} {2}", day, month, year);
                        }
                        else
                        {
                            day++;
                            Console.WriteLine("{0} {1} {2}", day, month, year);
                        }
                        break;
                    }
                case 31:
                    {
                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10)
                        {
                            day = 1;
                            month++;
                            Console.WriteLine("{0} {1} {2}", day, month, year);
                        }
                        else if (month == 12)
                        {
                            day = 1;
                            month = 1;
                            year++;
                            Console.WriteLine("{0} {1} {2}", day, month, year);
                        }
                        else
                        {
                            Console.WriteLine("Data Error!");
                        }
                        break;
                    }
                default:
                    {
                        day++;
                        Console.WriteLine("{0} {1} {2}", day, month, year);

                    }
                    break;

            }
        }
    }
}
