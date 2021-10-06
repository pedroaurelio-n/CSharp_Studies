using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Account
{
    public class Account
    {
        private string _name;
        private float _balance;

        public Account() { }

        public Account(string name, float balance)
        {
            _name = name;
            _balance = balance;
        }

        public string GetName() { return _name; }
        public void SetName(string name) { _name = name; }

        public float GetBalance() { return _balance; }
        public void SetBalance(float balance)
        {
            if (balance > 0)
                _balance = balance;

            else
                _balance = 0;
        }

        public void DepositMoney(float value)
        {
            if (value > 0)
                _balance += value;

            Console.WriteLine($"Your balance now is ${_balance.ToString("0.00")}");
        }

        public void WithdrawMoney(float value)
        {
            if (_balance >= value)
                _balance -= value;

            else
                _balance = 0;

            Console.WriteLine($"Your balance now is ${_balance.ToString("0.00")}");
        }

        public override string ToString()
        {
            return $"Account Info"
               + $"\nName:      {_name}"
               + $"\nBalance:   ${_balance.ToString("0.00")}";
        }
    }
}
