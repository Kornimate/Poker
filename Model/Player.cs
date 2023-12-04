
using System.Runtime.InteropServices;

namespace Model
{
    public class Player
    {
        public string Name { get; private set; }
        public List<Card?> Cards { get; private set; }
        public bool IsBot { get; private set; }
        public bool HasAlreadyRaised { get; set; }
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
            HasAlreadyRaised = false;
        }
        public void GetCardFromDeck(Card? card)
        {
            if (Cards.Count >= 2)
            {
                throw new Exception("Too many cards for a Player!");
            }
            Cards.Add(card);
        }

        public PokerAction ChooseAction(int raise)
        {
            int limit = (Rating switch
            {
                PokerRating.HighCard => 80,
                PokerRating.Pair => 78,
                PokerRating.TwoPairs => 76,
                PokerRating.ThreeOfAKind => 74,
                PokerRating.Straight => 72,
                PokerRating.Flush => 71,
                PokerRating.Full => 70,
                PokerRating.FourOfAKind => 69,
                PokerRating.StraightFlush => 65,
                PokerRating.RoyalFlush => 60,
                null => 101,
                _ => 101,
            });

            int target = new Random().Next(1, 101);

            if (raise == 0)
            {
                if (target > limit && !HasAlreadyRaised)
                {
                    return PokerAction.Raise;
                }
                else
                {
                    return PokerAction.Check;
                }
            }
            else
            {
                if (Money < raise)
                {
                    return PokerAction.Fold;
                }
                if(Money == raise)
                {
                    return PokerAction.Call;
                }
                if (target > limit && !HasAlreadyRaised)
                {
                    return PokerAction.Raise;
                }
                else if (target < 20)
                {
                    return PokerAction.Fold;
                }
                else
                {
                    return PokerAction.Call;
                }
            }
        }

        public void CallMoney(int amount)
        {
            int diff =  amount - MoneyOnTable;
            MoneyOnTable = amount;
            Money-= diff;
        }

        public int RaiseMoneyOnTable(int raise)
        {
            int amount = Rating switch
            {
                PokerRating.HighCard => Math.Min(Money, Convert.ToInt32(0.01 * Money)),
                PokerRating.Pair => Math.Min(Money, Convert.ToInt32(0.01 * Money)),
                PokerRating.TwoPairs => Math.Min(Money, Convert.ToInt32(0.02 * Money)),
                PokerRating.ThreeOfAKind => Math.Min(Money, Convert.ToInt32(0.03 * Money)),
                PokerRating.Straight => Math.Min(Money, Convert.ToInt32(0.035 * Money)),
                PokerRating.Flush => Math.Min(Money, Convert.ToInt32(0.04 * Money)),
                PokerRating.Full => Math.Min(Money, Convert.ToInt32(0.05 * Money)),
                PokerRating.FourOfAKind => Math.Min(Money, Convert.ToInt32(0.06 * Money)),
                PokerRating.StraightFlush => Math.Min(Money, Convert.ToInt32(0.065 * Money)),
                PokerRating.RoyalFlush => Money,
                _ => 0,
            };
            if(raise + amount > Money)
            {
                amount = Money - raise;
            }
            amount += raise;
            Money -= amount;
            MoneyOnTable += amount;
            return amount;
        }

        public void SetActivation(bool value)
        {
            IsActive = value;
        }

        public void SetMoneyOnTable(int value)
        {
            MoneyOnTable = value;
        }
        public void SetDefaultForRound()
        {
            IsActive = Money > 0;
            MoneyOnTable = 0;
            Cards.Clear();
            HasAlreadyRaised = false;
        }

        public void AddMoney(int amount)
        {
            Money += amount;
        }
    }
}
