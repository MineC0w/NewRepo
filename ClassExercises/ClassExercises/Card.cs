using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Card
    {
        private CardType _figure;
        private CardColor _color;
        private int _number;

        public Card(CardType type, CardColor color, int number)
        {
            _figure = type;
            _color = color;
            _number = number;
        }

        public Card() : this(CardType.Heart, CardColor.Red, 9) { }

        public int GetNumber()
        {
            return _number;
        }

        public void SetType(CardType cardType)
        {
            _figure = cardType;
        }
    }

    public enum CardType { Heart, Diamond, Clover, Clubs}
    public enum CardColor { Black, Red}
}
