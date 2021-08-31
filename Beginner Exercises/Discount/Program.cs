using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20% SALE ON ALL ITEMS!!");
            Console.WriteLine("Calculate the discounted price.\n");

            Console.Write("Enter the normal price: $");
            float normalPrice = float.Parse(Console.ReadLine());

            float discountValue = normalPrice * 0.2f;
            float discountedPrice = normalPrice - discountValue;

            Console.WriteLine($"Save ${discountValue.ToString("0.00")} and pay only ${discountedPrice.ToString("0.00")}!!");

            Console.ReadLine();
        }
    }
}
