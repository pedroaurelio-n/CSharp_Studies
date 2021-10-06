using System;
using System.Collections.Generic;
using System.Text;

namespace _02_CakeTicket
{
    public class Ticket
    {
        private Cake _cake;
        private int _quantity;

        private float _totalPrice;

        public Ticket() { }

        public Ticket(Cake cake, int quantity)
        {
            _cake = cake;
            _quantity = quantity;
        }

        public void GenerateTicket()
        {
            _totalPrice = _cake.GetPrice() * _quantity;

            Console.WriteLine($"------Cake Ticket------"
                          + $"\nColor:       {_cake.GetColor()}"
                          + $"\nFlavor:      {_cake.GetFlavor()}"
                          + $"\nSize:        {_cake.GetSize()}"
                          + $"\nPrice:       ${_cake.GetPrice().ToString("0.00")}"
                          + $"\nQuantity:    {_quantity}"
                          + $"\nTotal Price: ${_totalPrice.ToString("0.00")}");
        }
    }
}
