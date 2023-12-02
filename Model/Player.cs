
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
        public Player(string name, bool isBot, int number)
        {
            Name = name;
            Cards = new List<Card?>();
            IsBot = isBot;
            Number = number;

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

        public void SetMoneyOnTable(int amount)
        {
            if(amount > Money)
            {
                throw new Exception("Not enough Money!");
            }
            Money -= amount;
            MoneyOnTable += amount;
        }
    }
}
