using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Shirt
    {
        private string _color;
        private char _size;
        private double _price;

        public Shirt() : this("blue",'M',49.90) { }

        public Shirt(string color, char size, double price)
        {
            _color = color;
            _size = size;
            _price = price;
        }

        

        public void SetColor(string color)
        {
            _color = color;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
