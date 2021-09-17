using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Area Calculator!\n");

            Console.Write("Enter the base: ");
            int baseValue = int.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            int heightValue = int.Parse(Console.ReadLine());

            int areaValue = baseValue * heightValue / 2;
            Console.WriteLine($"Area = {areaValue}");

            Console.ReadLine();
        }
    }
}
