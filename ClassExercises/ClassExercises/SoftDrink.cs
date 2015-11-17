using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class SoftDrink
    {
        private string _type;
        private double _price;
        private uint _quantity;

        public SoftDrink(string type, double price)
        {
            this._type = type;
            this._price = price;
            this._quantity = 100;
        }
        public override string ToString()
        {
            return string.Format("{0} bottles of {1}, {2} per unit.", _quantity, _type, _price);
        }

        public uint numberOfBottles(uint money)
        {
            return (uint)Math.Floor(money / _price);
        }

        public uint change(uint money)
        {
            return (uint)(money - numberOfBottles(money) * _price);
        }
    }
}
