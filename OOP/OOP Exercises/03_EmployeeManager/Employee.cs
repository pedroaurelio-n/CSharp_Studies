using System;
using System.Collections.Generic;
using System.Text;

namespace _03_EmployeeManager
{
    public abstract class Employee
    {
        private string _fullName;
        private int _age;
        private float _salary;

        private const float _RAISE = 400;

        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                    _age = value;
                else
                    _age = 0;
            }
        }

        public float Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                    _salary = value;
                else
                    _salary = 0;
            }
        }

        public float GetRaise() { return _RAISE; }

        public abstract void Raise();
    }
}
