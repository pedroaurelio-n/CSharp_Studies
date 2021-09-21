using System;

namespace _17_Triple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to triple it or enter 0 to exit: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                Console.WriteLine($"The triple of {number} is {number * 3}\n");

                Console.Write("Enter a number to triple it or enter 0 to exit: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
