using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PokerModel
    {
        private List<Player>? players;
        private Deck? deck;
        private bool endOfGame;
        private List<Card>? sharedCards;
        private int numOfCardsRevealed;
        private int smallBlind;

        public event EventHandler? Flop;
        public event EventHandler? Turn;
        public event EventHandler? River;
        public event EventHandler? GameEnd;
        public event EventHandler? UserChoose;
        public event EventHandler<int>? UpdatePlayer;

        public PokerModel(string playerName, int numOfPlayers)
        {
            StartNewGame(playerName, numOfPlayers);
        }

        private void StartNewGame(string playerName, int numOfPlayers)
        {
            players = new List<Player>()
            {
                new Player(playerName, false,0)
            };
            for (int i = 1; i < numOfPlayers; i++)
            {
                players.Add(new Player($"Bot_{i}", true, i));
            }
            deck = new Deck();
            foreach (Player p in players)
            {
                p.GetCard(deck.Draw());
            }
            sharedCards = Enumerable.Range(0, 5).Select(x => deck.Draw()).ToList()!;
            numOfCardsRevealed = 2;
            smallBlind = 0;
            Round();
        }

        private void Round()
        {
            GoThroughPlayers();
            ++numOfCardsRevealed;
            smallBlind = (++smallBlind) % players!.Count;
            switch (numOfCardsRevealed)
            {
                case 3:
                    Flop?.Invoke(this, EventArgs.Empty);
                    Round();
                    break;
                case 4:
                    Turn?.Invoke(this, EventArgs.Empty);
                    Round();
                    break;
                case 5:
                    River?.Invoke(this, EventArgs.Empty);
                    Round();
                    break;
                case 6:
                    EndOfGame();
                    break;
                default:
                    break;
            }
        }
        private void GoThroughPlayers()
        {
            int target = smallBlind - 1;
            int curr = smallBlind;
            bool changed = false;
            while (curr != target)
            {
                if(target == smallBlind-1 && !changed)
                {
                    target = smallBlind;
                }
                if (players![curr].IsBot)
                {
                    PokerAction action = players![curr].ChooseAction();
                    if(action == PokerAction.Raise)
                    {
                        target = curr;
                        changed = true;
                    }
                    UpdatePlayer?.Invoke(this, players![curr].Number);
                }
                else
                {
                    UserChoose?.Invoke(this, EventArgs.Empty);
                }
                curr = (curr + 1) % players.Count;
            }
        }
        private void EndOfGame()
        {
            GameEnd?.Invoke(this, EventArgs.Empty);
        }
    }
}
