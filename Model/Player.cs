
using System.Runtime.InteropServices;

namespace Model
{
    public class Player
    {
        public string Name { get; private set; }
        public List<Card?> Cards { get; private set; }
        public bool IsBot { get; private set; }
        public int Money { get; private set; }
        public int MoneyOnTable { get; private set; }
        public int Number { get; private set; }
        public bool IsActive { get; private set; }
        public PokerRating? Rating { get; set; }
        public Player(string name, bool isBot, int number)
        {
            Name = name;
            Cards = new List<Card?>();
            IsBot = isBot;
            Number = number;
            MoneyOnTable = 0;
            Money = 10_000;
            IsActive = true;
            Rating = null;
        }
        public void GetCardFromDeck(Card? card)
        {
            if(Cards.Count >= 2)
            {
                throw new Exception("Too many cards for a Player!");
            }
            Cards.Add(card);
        }

        public PokerAction ChooseAction()
        {
            return PokerAction.Check;
        }

        public bool RaiseMoney(int amount)
        {
            if(Money-amount < 0)
            {
                return false;
            }
            Money-= amount;
            MoneyOnTable += amount;
            return true;
        }

        public int RaiseMoneyOnTable()
        {
            int amount = Dealer.EvaluateCards(this.Cards!) switch
            {
                PokerRating.HighCard => 1,
                PokerRating.Pair => Math.Min(Money, (int)0.1 * Money),
                PokerRating.TwoPairs => Math.Min(Money, (int)0.2 * Money),
                PokerRating.ThreeOfAKind => Math.Min(Money, (int)0.3 * Money),
                PokerRating.Straight => Math.Min(Money, (int)0.35 * Money),
                PokerRating.Flush => Math.Min(Money, (int)0.4 * Money),
                PokerRating.Full => Math.Min(Money, (int)0.5 * Money),
                PokerRating.FourOfAKind => Math.Min(Money, (int)0.6 * Money),
                PokerRating.StraightFlush => Math.Min(Money, (int)0.65 * Money),
                PokerRating.RoyalFlush => Money,
                _ => 0,
            };
            Money -= amount;
            MoneyOnTable += amount;
            return amount;
        }

        public void SetActivation(bool value)
        {
            IsActive = value;
        }

        public void ClearTable()
        {
            MoneyOnTable = 0;
            if (Money <= 0)
            {
                IsActive = false; 
            }
        }
        public void SetMoneyOnTable(int value)
        {
            MoneyOnTable=value;
        }
        public void SetDefaultForRound()
        {
            IsActive = Money > 0;
            MoneyOnTable = 0;
            Cards.Clear();
        }
    }
}
