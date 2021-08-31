using System;

namespace WeeksInDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are 7 days in 1 week");
            Console.Write("Enter a number of weeks: ");
            int weeksNumber = int.Parse(Console.ReadLine());

            int daysNumber = weeksNumber * 7;
            Console.WriteLine($"In {weeksNumber} weeks there are {daysNumber} days.");

            Console.ReadLine();
        }
    }
}
