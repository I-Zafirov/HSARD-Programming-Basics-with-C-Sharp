using System;

namespace StudentsArrayTypePublicStruct
{
    class Program
    {
        public struct Student
        {
            public string Name;
            public string FacultyNumber;
            public string Specialty;
            public double AverageSuccess;
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            Console.WriteLine("Input students number (n<=10):");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input Name:");
                students[i].Name = Console.ReadLine();

                Console.WriteLine("Input FacultyNumber:");
                students[i].FacultyNumber = Console.ReadLine();

                Console.WriteLine("Input Specialty:");
                students[i].Specialty = Console.ReadLine();

                Console.WriteLine("Input AverageSuccess:");
                students[i].AverageSuccess = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("You have entered the following data:");
            Console.WriteLine("\n");
            Console.WriteLine("<Name, FacultyNumber, Specialty, AverageSuccess>");
            Console.WriteLine("\n");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(students[i].Name);
                Console.WriteLine('\t');
                Console.WriteLine(students[i].FacultyNumber);
                Console.WriteLine('\t');
                Console.WriteLine(students[i].Specialty);
                Console.WriteLine('\t');
                Console.WriteLine(students[i].AverageSuccess);
                Console.WriteLine("\n");
            }
        }
    }
}

