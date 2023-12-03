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

        private int target;
        private int current;
        private bool changed;
        private int raise;

        public event EventHandler? Flop;
        public event EventHandler? Turn;
        public event EventHandler? River;
        public event EventHandler? GameEnd;
        public event EventHandler? UserChoose;
        public event EventHandler? RoundEnded;
        public event EventHandler? CircleEnded;
        public event EventHandler? StartingProcedureEnded;
        public event EventHandler<int>? UpdatePlayer;
        public event EventHandler<int>? RevealPlayerCards;
        public event EventHandler<int>? CurrentPlayerIndicator;

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
            smallBlind = 0;
            StartNewRound();
            Round();
            GoThroughPlayers();
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
            target = smallBlind - 1;
            current = smallBlind;
            changed = false;
            switch (numOfCardsRevealed)
            {
                case 3:
                    Flop?.Invoke(this, EventArgs.Empty);
                    GoThroughPlayers();
                    break;
                case 4:
                    Turn?.Invoke(this, EventArgs.Empty);
                    GoThroughPlayers();
                    break;
                case 5:
                    River?.Invoke(this, EventArgs.Empty);
                    GoThroughPlayers();
                    break;
                case 6:
                    ShowCards();
                    break;
                default:
                    break;
            }
            ++numOfCardsRevealed;
            smallBlind = (++smallBlind) % players!.Count;
            CircleEnded?.Invoke(this, EventArgs.Empty);
        }
        private void GoThroughPlayers()
        {
            if(current == target)
            {
                RoundEnded?.Invoke(this, EventArgs.Empty);
                StartNewRound();
                return;
            }
            players!.ForEach(p =>
            {
                if(p.IsActive && p.Money == 0)
                {
                    ShowCards();
                    return;
                }
            });
            while (current != target && current !=0)
            {
                CurrentPlayerIndicator?.Invoke(this, current);
                if (target == smallBlind - 1 && !changed)
                {
                    target = smallBlind;
                }
                if (!players![current].IsActive)
                {
                    continue;
                }
                if (players![current].IsBot)
                {
                    PokerAction action = players![current].ChooseAction();
                    if (action == PokerAction.Raise)
                    {
                        target = current;
                        changed = true;
                        raise = players[current].RaiseMoneyOnTable();
                    }
                    UpdatePlayer?.Invoke(this, players![current].Number);
                }
                else
                {
                    UserChoose?.Invoke(this, EventArgs.Empty);
                }
                current = (current + 1) % players.Count;
            }
            if(current == 0)
            {
                UserChoose?.Invoke(this, EventArgs.Empty);
                return;
            }
            Round();
        }

        private void ShowCards()
        {
            int i = 0;
            var winningOrder = players!.Where(x => x.IsActive).Select(x => new { rationg = Dealer.EvaluateCards(x.Cards!),idx = i++ }).OrderBy(x => x.idx).ToList();
            winningOrder.ForEach(x =>
            {
                RevealPlayerCards?.Invoke(this, x.idx);
            });
            i = 0;
            players!.ForEach(p =>
            {
                i += p.MoneyOnTable;
                p.ClearTable();
                UpdatePlayer?.Invoke(this, p.Number);
            });
        }

        private void StartNewRound()
        {
            deck = new Deck();
            foreach (Player p in players!)
            {
                p.Cards.Clear();
                p.GetCardFromDeck(deck.Draw());
                p.GetCardFromDeck(deck.Draw());
            }
            sharedCards = Enumerable.Range(0, 5).Select(x => deck.Draw()).ToList()!;
            numOfCardsRevealed = 2;
            StartingProcedureEnded?.Invoke(this, EventArgs.Empty);
        }

        public void ShowUserCards()
        {
            RevealPlayerCards?.Invoke(this, 0); // Reveal user cards after finished initialization
        }

        private void EndOfGame()
        {
            GameEnd?.Invoke(this, EventArgs.Empty);
        }

        public bool RaiseExists()
        {
            return raise > 0;
        }

        public void UserCall()
        {
            if(!players![0].AddMoney((-1) * raise))
            {
                throw new Exception("Not enough Money!");
            }
            current++;
        }

        public void UserRaise(int raiseValue)
        {
            if (!players![0].AddMoney((-1) * raiseValue))
            {
                throw new Exception("Not enough Money!");
            }
            current++;
        }

        public int GetUserTotalMoney()
        {
            return players![0].Money;
        }

        public void UserCheck()
        {
            current++;
        }

        public void UserFold()
        {
            players![0].SetActivation(false);
            current++;
        }
    }
}
