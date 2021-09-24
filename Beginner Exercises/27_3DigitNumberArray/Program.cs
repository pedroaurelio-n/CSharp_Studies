using System;

namespace _27_3DigitNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };

            int threeDigit = 0;

            foreach (int number in numbers)
            {
                if (number >= 100 && number <= 999)
                    threeDigit++;
            }

            Console.WriteLine($"In the array, there are {threeDigit} numbers with 3 digits");

            Console.ReadKey();
        }
    }
}
