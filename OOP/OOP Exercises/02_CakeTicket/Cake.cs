using System;
using System.Collections.Generic;
using System.Text;

namespace _02_CakeTicket
{
    public enum CakeSize
    {
        SMALL,
        MEDIUM,
        BIG
    }

    public class Cake
    {
        private string _color;
        private string _flavor;
        private CakeSize _cakeSize;

        private float _price;

        public Cake() { }

        public Cake(string color, string flavor, CakeSize cakeSize)
        {
            _color = color;
            _flavor = flavor;
            _cakeSize = cakeSize;

            switch (_cakeSize)
            {
                case CakeSize.SMALL: _price = 5; break;
                case CakeSize.MEDIUM: _price = 8; break;
                case CakeSize.BIG: _price = 10; break;
            }
        }

        public string GetColor() { return _color; }
        public string GetFlavor() { return _flavor; }
        public string GetSize()
        {
            switch (_cakeSize)
            {
                case CakeSize.SMALL: return "Small";
                case CakeSize.MEDIUM: return "Medium";
                case CakeSize.BIG: return "Big";
                default: return "";
            }
        }
        public float GetPrice() { return _price; }
    }
}
