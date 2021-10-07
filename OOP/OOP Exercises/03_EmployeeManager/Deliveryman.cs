using System;
using System.Collections.Generic;
using System.Text;

namespace _03_EmployeeManager
{
    public class Deliveryman : Employee
    {
        private string _city;

        public Deliveryman() { }
        public Deliveryman(string fullName, int age, float salary, string city)
        {
            FullName = fullName;
            Age = age;
            Salary = salary;
            _city = city;
        }

        public override void Raise()
        {
            if (Age < 35 && _city.ToUpper() == "CHICAGO")
            {
                Salary += GetRaise();
                Console.WriteLine("Raise applied!");

                Console.WriteLine("Updated info:");
                Console.WriteLine(ToString() + "\n");
            }
        }

        public override string ToString()
        {
            return $"Full name: {FullName}"
               + $"\nAge: {Age}"
               + $"\nSalary: ${Salary.ToString("0.00")}"
               + $"\nCity: {_city}";
        }
    }
}
