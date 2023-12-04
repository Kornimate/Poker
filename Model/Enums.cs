using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum PokerColor { Hearts, Diamonds, Spades, Clubs }
    public enum PokerValue { Two=1, Three=2, Four=3, Five=4, Six=5, Seven=6, Eight=7, Nine=8, Ten=9, Jack=10, Queen=11, King=12, Ace=13 }
    public enum PokerRating { HighCard=1, Pair=2, TwoPairs=3, ThreeOfAKind=4, Straight=5, Flush=6, Full=7, FourOfAKind=8, StraightFlush=9, RoyalFlush=10 }
    public enum PokerAction { Fold, Call, Raise, Check}
}
