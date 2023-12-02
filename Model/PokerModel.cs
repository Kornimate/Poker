using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PokerModel
    {
        public List<Player>? players;
        public Deck? deck;
        public bool endOfGame;
        public List<Card>? sharedCards;
        public int numOfCardsRevealed;
        public int smallBlind;

        public event EventHandler? Flop;
        public event EventHandler? Turn;
        public event EventHandler? River;
        public event EventHandler? GameEnd;
        public event EventHandler? UserChoose;
        public event EventHandler? RoundEnded;
        public event EventHandler<int>? UpdatePlayer;
        public event EventHandler<int>? RevealPlayerCards;

        public PokerModel(string playerName, int numOfPlayers)
        {
            StartNewGame(playerName, numOfPlayers);
        }

        private void StartNewGame(string playerName, int numOfPlayers)
        {
            players = new List<Player>()
            {
                new Player(playerName, false,0),
                new Player($"Bot_{2}", true, 2)
            };
            if (numOfPlayers == 4)
            {
                players.Add(new Player($"Bot_{1}", true, 1));
                players.Add(new Player($"Bot_{3}", true, 3));
                players = players.OrderBy(x => x.Number).ToList();
            }
            deck = new Deck();
            foreach (Player p in players)
            {
                p.GetCardFromDeck(deck.Draw());
                p.GetCardFromDeck(deck.Draw());
            }
            sharedCards = Enumerable.Range(0, 5).Select(x => deck.Draw()).ToList()!;
            numOfCardsRevealed = 2;
            smallBlind = 0;
            Round();
        }

        public void Testing()
        {
            foreach (Player p in players!)
            {
                RevealPlayerCards?.Invoke(this, p.Number);
            }
            Flop?.Invoke(this, EventArgs.Empty);
            Turn?.Invoke(this, EventArgs.Empty);
            River?.Invoke(this, EventArgs.Empty);
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
                if (target == smallBlind - 1 && !changed)
                {
                    target = smallBlind;
                }
                if (players![curr].IsBot)
                {
                    PokerAction action = players![curr].ChooseAction();
                    if (action == PokerAction.Raise)
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
