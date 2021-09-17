using System;

namespace _9_EvenUneven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine($"{number} is even!");

            else
                Console.WriteLine($"{number} is uneven!");

            Console.ReadKey();
        }
    }
}
