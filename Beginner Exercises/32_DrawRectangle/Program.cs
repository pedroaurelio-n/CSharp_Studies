using System;

namespace _32_DrawRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter a character to fill the rectangle: ");
            char fill = char.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Rectangle with {height} of height and {width} of width: ");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(fill);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
