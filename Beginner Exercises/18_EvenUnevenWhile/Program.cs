using System;

namespace _18_EvenUnevenWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number to check even/uneven\nor enter a negative to exit: ");
            int number = int.Parse(Console.ReadLine());

            while (number >= 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"{number} is even!\n");

                else
                    Console.WriteLine($"{number} is uneven!\n");

                Console.Write("Enter a positive number to check even/uneven\nor enter a negative to exit: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
