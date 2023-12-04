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
        private int sumMoneyOnTable;

        public event EventHandler? Flop;
        public event EventHandler? Turn;
        public event EventHandler? River;
        public event EventHandler? GameEnd;
        public event EventHandler? UserChoose;
        public event EventHandler? RoundEnded;
        public event EventHandler? StartingProcedureEnded;
        public event EventHandler? EnableTimer;
        public event EventHandler? DisableTimer;
        public event EventHandler? EnableShowingTimer;
        public event EventHandler<int>? CircleEnded;
        public event EventHandler<int>? UpdatePlayer;
        public event EventHandler<int>? RevealPlayerCards;
        public event EventHandler<int>? FoldPlayerCards;
        public event EventHandler<int>? CurrentPlayerIndicator;
        public event EventHandler<int>? SmallBlindIndicator;
        public event EventHandler<int>? ShowCardsEvaluation;
        public event EventHandler<string>? AnnounceWinner;

        public PokerModel()
        {
            //StartNewGame(playerName, numOfPlayers);
        }

        public void StartNewGame(string playerName, int numOfPlayers)
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
            smallBlind = -1;
            StartNewRound();
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

        public void Circle()
        {
            ++numOfCardsRevealed;
            current = smallBlind;
            target = smallBlind;
            switch (numOfCardsRevealed)
            {
                case 3:
                    Flop?.Invoke(this, EventArgs.Empty);
                    ShowCardsEvaluation?.Invoke(this, players![0].Number);
                    break;
                case 4:
                    Turn?.Invoke(this, EventArgs.Empty);
                    ShowCardsEvaluation?.Invoke(this, players![0].Number);
                    break;
                case 5:
                    River?.Invoke(this, EventArgs.Empty);
                    ShowCardsEvaluation?.Invoke(this, players![0].Number);
                    break;
                case 6:
                    ShowCards();
                    break;
                default:
                    break;
            }
        }
        public void GoThroughPlayers()
        {
            players!.ForEach(p =>
            {
                if (p.IsActive && p.Money == 0)
                {
                    ShowCards(true);
                    return;
                }
            });
            if (players.Count(x => x.IsActive) == 1)
            {
                if (numOfCardsRevealed == 2)
                {
                    EndOfGame();
                }
                else
                {
                    ShowCards();
                }
            }
            if (players![current].IsActive)
            {
                CurrentPlayerIndicator?.Invoke(this, players![current].Number);
                players[current].Rating = Dealer.EvaluateCards(Enumerable.Concat(sharedCards!.Take(numOfCardsRevealed)!, players[current].Cards).ToList()!).Item1;
                if (players![current].IsBot)
                {
                    PokerAction action = players![current].ChooseAction(raise);
                    if (action == PokerAction.Raise)
                    {
                        target = current;
                        changed = true;
                        int amount = players[current].RaiseMoneyOnTable(raise);
                        players[current].HasAlreadyRaised = true;
                        raise = amount;
                    }
                    if (action == PokerAction.Fold)
                    {
                        players[current].SetActivation(false);
                        FoldPlayerCards?.Invoke(this, players[current].Number);
                    }
                    if (action == PokerAction.Call)
                    {
                        players[current].CallMoney(raise);
                    }
                    UpdatePlayer?.Invoke(this, players![current].Number);
                }
                else
                {
                    if (current != target || !changed)
                    {
                        DisableTimer?.Invoke(this, EventArgs.Empty);
                        UserChoose?.Invoke(this, EventArgs.Empty);
                        ShowCardsEvaluation?.Invoke(this, players[current].Number);
                        return;
                    }
                }
            }
            IncrementCurrent();
            RevealProcedureAndTableOrganizing();
        }

        private void RevealProcedureAndTableOrganizing()
        {
            if (current == target)
            {
                players!.ForEach(p =>
                {
                    sumMoneyOnTable += p.MoneyOnTable;
                    p.SetMoneyOnTable(0);
                    UpdatePlayer?.Invoke(this, p.Number);
                });
                CircleEnded?.Invoke(this, sumMoneyOnTable);
                raise = 0;
                changed = false;
                Circle();
                return;
            }
        }

        private bool RevealForUserIfLastInRow()
        {
            IncrementCurrent();
            if (current == target)
            {
                RevealProcedureAndTableOrganizing();
            }
            return numOfCardsRevealed == 6;
        }

        private void IncrementCurrent()
        {
            current = (current + 1) % players!.Count;
        }

        private void IncrementSmallBlind()
        {
            do
            {
                smallBlind = (smallBlind + 1) % players!.Count;
            } while (!players[smallBlind].IsActive);
        }

        private void ShowCards(bool rapidEnd = false)
        {
            if (rapidEnd)
            {
                Flop?.Invoke(this, EventArgs.Empty);
                Turn?.Invoke(this, EventArgs.Empty);
                River?.Invoke(this, EventArgs.Empty);
            }
            DisableTimer?.Invoke(this, EventArgs.Empty);
            CircleEnded?.Invoke(this, 0);
            var winningOrder = players!.Where(x => x.IsActive).Select(x => new { rating = Dealer.EvaluateCards(Enumerable.Concat(sharedCards!, x.Cards).ToList()!), idx = x.Number }).OrderByDescending(x => (int)x.rating.Item1).ThenByDescending(x => (int)x.rating.Item2).ToList();
            winningOrder.ForEach(x =>
            {
                RevealPlayerCards?.Invoke(this, x.idx);
            });
            players!.ForEach(p =>
            {
                p.SetDefaultForRound();
                UpdatePlayer?.Invoke(this, p.Number);
            });
            Player p = players.First(x => x.Number == winningOrder[0].idx);
            p.AddMoney(sumMoneyOnTable);
            AnnounceWinner?.Invoke(this, p.Name);
            UpdatePlayer?.Invoke(this, p.Number);
            if (players[0].Money == 0)
            {
                DisableTimer?.Invoke(this, EventArgs.Empty);
                GameEnd?.Invoke(this, EventArgs.Empty);
            }
            EnableShowingTimer?.Invoke(this, EventArgs.Empty);
        }

        public void StartNewRound()
        {
            RoundEnded?.Invoke(this, EventArgs.Empty);
            deck = new Deck();
            foreach (Player p in players!)
            {
                p.SetDefaultForRound();
                p.GetCardFromDeck(deck.Draw());
                p.GetCardFromDeck(deck.Draw());
                UpdatePlayer?.Invoke(this, p.Number);
            }
            sharedCards = Enumerable.Range(0, 5).Select(x => deck.Draw()).ToList()!;
            numOfCardsRevealed = 2;
            sumMoneyOnTable = 0;
            changed = false;
            IncrementSmallBlind();
            SmallBlindIndicator?.Invoke(this, players![smallBlind].Number);
            target = smallBlind;
            current = smallBlind;
            if (current != 0)
            {
                EnableTimer?.Invoke(this, EventArgs.Empty);
            }
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
            if (!RaiseExists())
            {
                throw new Exception("No raise in circle!");
            }
            if (GetUserTotalMoney() < raise)
            {
                throw new Exception("Not enough Money!");
            }
            players![0].CallMoney(raise);
            UpdatePlayer?.Invoke(this, players[0].Number);
            if (!RevealForUserIfLastInRow())
            {
                EnableTimer?.Invoke(this, EventArgs.Empty);
            }
        }

        public void UserRaise(int raiseValue)
        {
            if (GetUserTotalMoney() < raiseValue+raise)
            {
                throw new Exception("Not enough Money!");
            }
            raise += raiseValue;
            players![0].CallMoney(raise);
            changed = true;
            target = 0; // user number in line, always 0;
            UpdatePlayer?.Invoke(this, players[0].Number);
            if (!RevealForUserIfLastInRow())
            {
                EnableTimer?.Invoke(this, EventArgs.Empty);
            }
        }

        public int GetUserTotalMoney()
        {
            return players![0].Money;
        }

        public void UserCheck()
        {

            if (RaiseExists())
            {
                throw new Exception("You can not check!");
            }
            if (!RevealForUserIfLastInRow())
            {
                EnableTimer?.Invoke(this, EventArgs.Empty);
            }
            UpdatePlayer?.Invoke(this, players![0].Number);
        }

        public void UserFold()
        {
            players![0].SetActivation(false);
            FoldPlayerCards?.Invoke(this, 0);
            if (!RevealForUserIfLastInRow())
            {
                EnableTimer?.Invoke(this, EventArgs.Empty);
            }
            UpdatePlayer?.Invoke(this, players[0].Number);
        }
    }
}
