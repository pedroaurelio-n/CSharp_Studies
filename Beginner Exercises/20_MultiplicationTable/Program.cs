using System;

namespace _20_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table Checker\n");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter a limit: ");
            int limit = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTABLE OF {number} FROM 0 TO {limit}");

            for (int counter = 0; counter <= limit; counter++)
            {
                Console.WriteLine($"{number} X {counter} = {number * counter}");
            }

            Console.ReadKey();
        }
    }
}
