using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Encapsulation
{
    public class User
    {
        private string _username;
        private string _firstName;
        private string _lastName;
        private string _password;
        private float _hourlySalary;
        private int _workHours;

        private float _dailySalary;
        private float _monthlySalary;
        private float _yearlySalary;

        public string GetUsername() { return _username; }
        public void SetUsername(string username) { _username = username; }

        public string GetFirstName() { return _firstName; }
        public void SetFirstName(string firstName) { _firstName = firstName; }

        public string GetLastName() { return _lastName; }
        public void SetLastName(string lastName) { _lastName = lastName; }

        public string GetPassword() { return _password; }
        public void SetPassword(string password) { _password = password; }

        public float GetHourlySalary() { return _hourlySalary; }
        public void SetHourlySalary(float hourlySalary) 
        {
            if (hourlySalary >= 0)
                _hourlySalary = hourlySalary;

            else
                _hourlySalary = 0;
        }

        public int GetWorkHours() { return _workHours; }
        public void SetWorkHours(int workHours)
        {
            if (workHours > 0)
                _workHours = workHours;

            else
                _workHours = 0;
        }


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
            return _firstName + " " + _lastName;
        }

        public string LoginInformation()
        {
            return "Username: " + _username
                    + "\nPassword: " + _password;
        }

        private float DailySalary()
        {
            _dailySalary = _hourlySalary * _workHours;
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
