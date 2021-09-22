using System;

namespace _19_DoWhileCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter numbers to count how many are positive and how many are negative\nor type 0 to stop counting:");

            int posCounter = 0;
            int negCounter = 0;

            do
            {
                number = int.Parse(Console.ReadLine());

                if (number > 0)
                    posCounter++;

                else if (number < 0)
                    negCounter++;

            } while (number != 0);

            Console.WriteLine($"\nPositive numbers: {posCounter}\nNegative numbers: {negCounter}");

            Console.ReadKey();
        }
    }
}
