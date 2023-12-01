using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Card
    {
        public Color Color { get; }
        public Value Value { get; }
        public Card(Color color, Value value)
        {
            Color = color;
            Value = value;
        }
    }
}
