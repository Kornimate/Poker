using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Card
    {
        public PokerColor Color { get; }
        public PokerValue Value { get; }
        public Card(PokerColor color, PokerValue value)
        {
            Color = color;
            Value = value;
        }
    }
}
