using System;

namespace _13_Multiple5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 5 == 0)
                Console.WriteLine($"{number} is a multiple of 5");

            else
                Console.WriteLine($"{number} is not a multiple of 5");

            Console.ReadKey();
        }
    }
}
