using System;

namespace Salary20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 hour of work = $20");
            Console.Write("Enter how many hours you worked: ");
            int workHours = int.Parse(Console.ReadLine());

            int salaryValue = workHours * 20;
            Console.WriteLine($"\nBy working {workHours} hours you earned ${salaryValue}");

            Console.ReadLine();
        }
    }
}
