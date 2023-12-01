
namespace Model
{
    public class Player
    {
        public string Name { get; private set; }
        public Card? Card { get; private set; }
        public bool IsBot { get; private set; }
        public int Money { get; private set; }
        public int Number { get; private set; }
        public Player(string name, bool isBot, int number)
        {
            Name = name;
            Card = null;
            IsBot = isBot;
            Number = number;

        }
        public void GetCard(Card? card)
        {
            Card = card;
        }

        public PokerAction ChooseAction()
        {
            return PokerAction.Check;
        }
    }
}
