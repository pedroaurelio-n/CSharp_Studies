using System;

namespace _33_DrawTriangleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side of the triangle: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Enter a character to fill the triangle: ");
            char fill = char.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(fill);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
