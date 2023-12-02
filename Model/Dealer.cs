using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dealer
    {
        public static PokerRating EvaluateCards(List<Card> cards)
        {
            return PokerRating.HighCard;
        }
    }
}
