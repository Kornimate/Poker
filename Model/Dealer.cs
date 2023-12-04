using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dealer
    {
        public static (PokerRating, PokerValue) EvaluateCards(List<Card> cards)
        {
            if(cards.Count < 5)
            {
                return (PokerRating.HighCard, cards.Max(x => x.Value));
            }
            int maxColor = 0;
            int maxValue = 0;
            Dictionary<PokerColor, int> colors = new Dictionary<PokerColor, int>();
            Dictionary<PokerValue, int> values = new Dictionary<PokerValue, int>();
            foreach (Card card in cards)
            {
                if (colors.ContainsKey(card.Color))
                {
                    colors[card.Color]++;
                }
                else
                {
                    colors.Add(card.Color, 1);
                }
                if (colors[card.Color] > maxColor)
                {
                    maxColor = colors[card.Color];
                }
                if (values.ContainsKey(card.Value))
                {
                    values[card.Value]++;
                }
                else
                {
                    values.Add(card.Value, 1);
                }
                if (values[card.Value] > maxValue)
                {
                    maxValue = values[card.Value];
                }
            }
            var listOfColors = colors.Select(x => new { color = x.Key, multiplicity = x.Value }).OrderBy(x => x.multiplicity).ToList();
            var listOfValuesByValues = values.Select(x => new { value = x.Key, multiplicity = x.Value }).OrderBy(x => x.value).ToList();
            var listOfValuesByMultipicity = values.Select(x => new { value = x.Key, multiplicity = x.Value }).OrderBy(x => x.multiplicity).ToList();
            //todo royal flush and straight flush



            if (listOfValuesByMultipicity[^1].multiplicity == 4)
            {
                return (PokerRating.FourOfAKind, listOfValuesByMultipicity[^1].value);
            }
            if (listOfValuesByMultipicity[^1].multiplicity == 3 && listOfValuesByMultipicity[^2].multiplicity >= 2)
            {
                return (PokerRating.Full, listOfValuesByMultipicity.Where(x => x.multiplicity == 2).Max(x => x.value));
            }
            if (listOfColors[^1].multiplicity >= 5)
            {
                return (PokerRating.Flush, cards.Max(x => x.Value));
            }
            int counter = 0;
            for (int i = 1; i < listOfValuesByValues.Count; i++)
            {
                if ((int)listOfValuesByValues[i - 1].value + 1 == (int)listOfValuesByValues[i].value)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if (counter == 4)
                {
                    return (PokerRating.Straight, listOfValuesByValues[i].value);
                }
            }
            if (listOfValuesByMultipicity[^1].multiplicity == 3 && listOfValuesByMultipicity[^2].multiplicity == 1)
            {
                return (PokerRating.ThreeOfAKind, listOfValuesByMultipicity.Where(x => x.multiplicity == 3).Max(x=> x.value));
            }
            if (listOfValuesByMultipicity[^1].multiplicity == 2 && listOfValuesByMultipicity[^2].multiplicity == 2)
            {
                return (PokerRating.TwoPairs, listOfValuesByMultipicity.Where(x => x.multiplicity == 2).Max(x => x.value));
            }
            if (listOfValuesByMultipicity[^1].multiplicity == 2 && listOfValuesByMultipicity[^2].multiplicity == 1)
            {
                return (PokerRating.Pair, listOfValuesByMultipicity[^1].value);
            }
            return (PokerRating.HighCard, cards.Max(x => x.Value));
        }
    }
}
