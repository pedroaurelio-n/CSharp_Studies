using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine($"The sum of the two numbers is {sum}");

            Console.ReadLine();
        }
    }
}
