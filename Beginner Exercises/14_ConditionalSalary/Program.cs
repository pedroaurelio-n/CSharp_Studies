using System;

namespace _14_ConditionalSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Calculator\n30 work hours or more = $20/h\nLess than 30 work hours = $10/h\n");

            Console.Write("Enter your work hours: ");
            int workHours = int.Parse(Console.ReadLine());
            float salary;

            if (workHours >= 30)
                salary = workHours * 20;

            else
                salary = workHours * 10;

            Console.WriteLine($"\nYour salary is ${salary}");

            Console.ReadKey();
        }
    }
}
