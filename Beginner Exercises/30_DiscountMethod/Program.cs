using System;

namespace _30_DiscountMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Enter the product's price: $", false);
            float normalPrice = EnterPrice();

            PrintMessage("", true);

            PrintMessage($"The final price with 20% discount is: ${ApplyDiscount(normalPrice).ToString("00.00")}", true);

            Console.ReadKey();
        }

        static float EnterPrice()
        {
            return float.Parse(Console.ReadLine());
        }

        static void PrintMessage(string message, bool skipLine)
        {
            if (skipLine)
                Console.WriteLine(message);

            else
                Console.Write(message);
        }

        static float ApplyDiscount(float value)
        {
            return value = value - (value * 0.2f);
        }
    }
}
