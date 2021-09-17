using System;

namespace _12_DiscountSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have three options of discount!\nA - 10% off\nB - 25% off\nC - 50% off");

            Console.Write("\nEnter the product's value: $");
            float normalPrice = float.Parse(Console.ReadLine());

            Console.Write("Choose discount option: ");
            char discountChar = char.Parse(Console.ReadLine());
            float discount;
            string discountType;

            switch (discountChar)
            {
                case 'A': discount = normalPrice * 0.1f; discountType = "10% off discount"; break;
                case 'B': discount = normalPrice * 0.25f; discountType = "25% off discount"; break;
                case 'C': discount = normalPrice * 0.5f; discountType = "50% off discount"; break;
                default: Console.WriteLine("Invalid option."); discount = 0; discountType = ""; break;
            }

            if (discountChar == 'A' || discountChar == 'B' || discountChar == 'C')
            {
                Console.WriteLine($"\nNormal price: ${normalPrice.ToString("0.00")}");
                Console.WriteLine($"Discount option: {discountType}");
                Console.WriteLine($"Discounted value: ${discount.ToString("0.00")}");
                Console.WriteLine($"Total price: ${(normalPrice - discount).ToString("0.00")}");
            }

            Console.ReadKey();
        }
    }
}
