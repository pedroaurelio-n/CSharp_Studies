using System;

namespace _2_ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            User userOne = new User();
            userOne.Username = "pedroaurelio_n";
            userOne.FirstName = "Pedro";
            userOne.LastName = "Aurelio";
            userOne.Password = "123";

            Console.WriteLine(User.WelcomeMessage(userOne.FirstName));
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
