using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ClassMethods
{
    public class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public float HourlySalary { get; private set; }
        public int WorkHours { get; private set; }

        private float _dailySalary;
        private float _monthlySalary;
        private float _yearlySalary;

        public static string WelcomeMessage()
        {
            return "Welcome!";
        }

        public static string WelcomeMessage(string name)
        {
            return "Welcome, " + name + "!";
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public string LoginInformation()
        {
            return "Username: " + Username
                    + "\nPassword: " + Password;
        }

        public void SetHourlySalary(float hourlySalary)
        {
            HourlySalary = hourlySalary;
        }

        public void SetWorkHours(int workHours)
        {
            WorkHours = workHours;
        }

        private float DailySalary()
        {
            _dailySalary = HourlySalary * WorkHours;
            return _dailySalary;
        }

        private float MonthlySalary()
        {
            _monthlySalary = _dailySalary * 30;
            return _monthlySalary;
        }

        private float YearlySalary()
        {
            _yearlySalary = _monthlySalary * 12;
            return _yearlySalary;
        }

        public string CalculateSalary()
        {
            DailySalary();
            MonthlySalary();
            YearlySalary();

            return "Daily salary:   $" + _dailySalary.ToString("0.00")
               + "\nMonthly salary: $" + _monthlySalary.ToString("0.00")
               + "\nYearly salary:  $" + _yearlySalary.ToString("0.00");
        }
    }
}
