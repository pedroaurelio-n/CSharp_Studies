using System;
using System.Collections.Generic;
using System.Text;

namespace _03_EmployeeManager
{
    public class Shopkeeper : Employee
    {
        private float _comission;
        
        public Shopkeeper() { }
        public Shopkeeper(string fullName, int age, float salary, float comission)
        {
            FullName = fullName;
            Age = age;
            Salary = salary;
            _comission = comission;
        }

        public override void Raise()
        {
            if (Age > 20 && _comission > 300)
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
               + $"\nComission: ${_comission.ToString("0.00")}";
        }
    }
}
