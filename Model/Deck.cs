using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Deck
    {
        private List<Card> cards;
        private int counter;
        public Deck()
        {
            cards = new List<Card>();
            counter = 0;
            foreach(Color c in Enum.GetValues<Color>())
            {
                foreach(Value v in Enum.GetValues<Value>())
                {
                    cards.Add(new Card(c, v));
                }
            }
            SchuffleDeck();
        }
        private void SchuffleDeck()
        {
            Random rnd = new Random();
            cards = cards.OrderBy(x => rnd.Next()).ToList();
        }

        public Card? Draw()
        {
            return counter < cards.Count ? cards[counter++] : null;
        }
    }
}
