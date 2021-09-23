using System;

namespace _22_HalfDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            float number;
            float half;

            do
            {
                Console.Write("Enter a positive number to check its half\nor type a negative number to exit: ");
                number = int.Parse(Console.ReadLine());

                half = number / 2;

                if (number < 0)
                    break;

                Console.WriteLine($"The half of {number} is {half}\n");

            } while (number >= 0);

            Console.ReadKey();
        }
    }
}
