using System;
using System.Collections.Generic;

namespace _01_StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Pedro", 8, 10));
            studentList.Add(new Student("Herobreno", 7, 4));
            studentList.Add(new Student("Lalo", 7, 13));
            studentList.Add(new Student("Steak", 2, 5));
            studentList.Add(new Student("Tony", -2, 3));

            foreach (Student student in studentList)
            {
                student.CalculateAverageScore();
            }

            Console.ReadKey();
        }
    }
}
