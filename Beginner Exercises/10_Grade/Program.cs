using System;

namespace _10_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade (A/B/C): ");
            char grade = char.Parse(Console.ReadLine());

            if (grade == 'A')
                Console.WriteLine("Congratulations! You reached max score.");

            else if (grade == 'B')
                Console.WriteLine("You scored average. Good luck next time.");

            else if (grade == 'C')
                Console.WriteLine("You failed. Try again.");

            else
                Console.WriteLine("Invalid grade!");

            Console.ReadKey();
        }
    }
}
