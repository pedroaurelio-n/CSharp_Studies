using System;
using System.Collections.Generic;

namespace _01_StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            Console.Write("Enter a number of students to register: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter student {i} name: ");
                string name = Console.ReadLine();

                studentList.Add(new Student(name));
            }

            Console.WriteLine();

            foreach(Student student in studentList)
            {
                Console.Write($"Enter the first score for {student.Name}: ");
                student.Score1 = int.Parse(Console.ReadLine());

                Console.Write($"Enter the second score for {student.Name}: ");
                student.Score2 = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (Student student in studentList)
            {
                student.CalculateAverageScore();
            }

            Console.ReadKey();
        }
    }
}
