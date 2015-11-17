using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirt myShirt = new Shirt("Yellow", 'S', 69.5);

            Card myCard = new Card(CardType.Clubs, CardColor.Red, 1);

            CreditCard yaelCard = new CreditCard(CreditCompany.Hapoalim, "Yael Cohen", 2468013579, 1.2012);

        }
    }
}
