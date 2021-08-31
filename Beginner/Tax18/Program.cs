using System;

namespace Tax18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All products have an 18% tax added to the original price");
            Console.Write("Enter the product's original price: $");
            float originalPrice = float.Parse(Console.ReadLine());

            float taxValue = 0.18f;
            float totalPrice = originalPrice * (1 + taxValue);

            Console.WriteLine($"\nTax percentage: {taxValue * 100}%");
            Console.WriteLine($"Total price: ${totalPrice.ToString("0.00")}");

            Console.ReadLine();
        }
    }
}
