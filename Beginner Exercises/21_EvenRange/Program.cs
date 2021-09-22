using System;

namespace _21_EvenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (different from the first): ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                Console.WriteLine($"\nALL THE EVEN NUMBERS IN THE RANGE {number1}-{number2} (inclusive)");

                for (int i = number1; i <= number2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            else if (number1 > number2)
            {
                Console.WriteLine($"\nALL THE EVEN NUMBERS IN THE RANGE {number2}-{number1} (inclusive)");

                for (int i = number2; i <= number1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
