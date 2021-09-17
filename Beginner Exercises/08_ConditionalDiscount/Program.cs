using System;

namespace _8_ConditionalDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This store has a 20% off sale on products that cost $500 or above");
            Console.WriteLine("But only 10% off on products under $500\n");

            Console.Write("Enter the product's price: $");
            float normalPrice = float.Parse(Console.ReadLine());
            float discount;

            if (normalPrice >= 500)
                discount = normalPrice * 0.2f;

            else
                discount = normalPrice * 0.1f;

            float finalPrice = normalPrice - discount;
            Console.WriteLine($"\nDiscount is ${discount.ToString("0.00")}");
            Console.WriteLine($"\nFinal price is ${finalPrice.ToString("0.00")}");

            Console.ReadLine();
        }
    }
}
