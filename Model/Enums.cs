using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Color { Hearts, Diamonds, Spades, Clubs }
    public enum Value { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
    public enum Rating { HighCard, Pair, TwoPairs, ThreeOfAKind, Straight, Flush, Full, FourOfAKind, StraightFlush, RoyalFlush }

    public enum PokerAction { Fold, Call, Raise, Bet, Check}
}
