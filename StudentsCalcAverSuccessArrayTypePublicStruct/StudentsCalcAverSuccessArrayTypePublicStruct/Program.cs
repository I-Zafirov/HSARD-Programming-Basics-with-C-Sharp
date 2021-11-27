using System;

namespace StudentsCalcAverSuccessArrayTypePublicStruct
{
    class Program
    {
        /*
        static void input (int[]a, int n)
         {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input number:");
                a[i] = int.Parse(Console.ReadLine());
            }
         }
        */
static double Sum (Student[]b, int count)
        {
            double s = 0;

            for(int i = 0; i < count; i++)
            {
                s += b[i].AverSuccess;
            }
            double success = s / count;
            return success;
        }
        public struct Student
        {
            public string Name;
            public string FacultyNumber;
            public string Specialty;
            public double AverSuccess;
        };
          static void Main(string[] args)
        {
            Student[] s = new Student[3];

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Input Name:");
                s[i].Name = Console.ReadLine();
                
                Console.WriteLine("Input Faculty Number:");
                s[i].FacultyNumber = Console.ReadLine();
                
                Console.WriteLine("Input Specialty:");
                s[i].Specialty = Console.ReadLine();
                
                Console.WriteLine("Input Average Success:");
                s[i].AverSuccess = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(s[i].Name);
                Console.WriteLine(s[i].FacultyNumber);
                Console.WriteLine(s[i].Specialty);
                Console.WriteLine(s[i].AverSuccess);
            }
            double m = Sum(s, 3);
            Console.WriteLine("Average Success is {0}", m);
        }
    }
}
