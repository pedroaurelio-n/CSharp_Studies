using System;

namespace _02_CakeTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Cake Shop!\n");

            Console.Write("Enter the desired color of your cake: ");
            string color = Console.ReadLine();

            Console.Write("Enter the flavor of your cake: ");
            string flavor = Console.ReadLine();

            bool loopCakeSize = true;
            CakeSize cakeSize;

            do
            {
                Console.Write("Enter the size of your cake (Small/Medium/Big): ");
                string cakeSizeString = Console.ReadLine();

                switch (cakeSizeString.ToUpper())
                {
                    case "SMALL": cakeSize = CakeSize.SMALL; loopCakeSize = false; break;
                    case "MEDIUM": cakeSize = CakeSize.MEDIUM; loopCakeSize = false; break;
                    case "BIG": cakeSize = CakeSize.BIG; loopCakeSize = false; break;
                    default: cakeSize = CakeSize.SMALL; Console.WriteLine("Invalid option!\n"); break;
                }
            } while (loopCakeSize);

            Cake newCake = new Cake(color, flavor, cakeSize);

            Console.Write("\nEnter the quantity of cakes you want to buy: ");
            int quantity = int.Parse(Console.ReadLine());

            Ticket newTicket = new Ticket(newCake, quantity);

            Console.WriteLine();

            newTicket.GenerateTicket();

            Console.ReadKey();
        }
    }
}
