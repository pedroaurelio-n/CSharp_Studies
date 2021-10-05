using System;

namespace _3_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User userOne = new User();
            userOne.SetUsername("pedroaurelio_n");
            userOne.SetFirstName("Pedro");
            userOne.SetLastName("Aurelio");
            userOne.SetPassword("123");

            Console.WriteLine(User.WelcomeMessage(userOne.GetFirstName()));
            Console.WriteLine();

            Console.Write("Enter your hourly salary: $");
            userOne.SetHourlySalary(float.Parse(Console.ReadLine()));

            Console.Write("Enter your work hours: ");
            userOne.SetWorkHours(int.Parse(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine(userOne.FullName());
            Console.WriteLine(userOne.LoginInformation());
            Console.WriteLine(userOne.CalculateSalary());

            Console.ReadLine();
        }
    }
}
