using Model;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Poker
{
    public partial class GameForm : Form
    {
        private PokerModel? model;
        private List<PlayerUI>? players;
        private List<PictureBox>? sharedCards;
        private readonly Bitmap? CardBack;

        private const int WAITTIME = 200;
        public GameForm()
        {
            InitializeComponent();
            CardBack = Properties.Resources.cardBack;
            gameTimer.Interval= WAITTIME;
            gameTimer.Enabled = false;
            gameTimer.Tick += NextPlayer;
        }

        private void NextPlayer(object? sender, EventArgs e)
        {
            model!.GoThroughPlayers();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            userControls.Enabled = false;
            model!.UserCall();
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            try
            {
                int raiseValue = (int)betAmount.Value;
                if (raiseValue > model!.GetUserTotalMoney())
                {
                    throw new Exception("Not enough Money!");
                }
                userControls.Enabled = false;
                model!.UserRaise(raiseValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            userControls.Enabled = false;
            model!.UserCheck();
        }

        private void btnFold_Click(object sender, EventArgs e)
        {
            userControls.Enabled = false;
            model!.UserFold();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            int numOfPlayers = (int)nmPlayerNumber.Value;
            if (username == null || username == string.Empty)
            {
                MessageBox.Show("Username must be at least one valid char!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StartNewGameUI(username, numOfPlayers);
        }

        private void StartNewGameUI(string username, int numOfPlayers)
        {
            gameDetails.Visible = false;
            gameDetails.Enabled = false;

            lblUserName.Text = username;
            lblCardValue.Text = "No Value";

            players = new List<PlayerUI>()
            {
                new PlayerUI(userImage, userBetMoney, userCard1, userCard2,userTotalMoney,0,605, 355),
                new PlayerUI(player2Image, player2BetMoney, player2Card1, player2Card2,player2TotalMoney,2,475, 59)
            };

            if (numOfPlayers == 4)
            {
                players.Add(new PlayerUI(player1Image, player1BetMoney, player1Card1, player1Card2, player1TotalMoney, 1, 836, 141));
                players.Add(new PlayerUI(player3Image, player3BetMoney, player3Card1, player3Card2, player3TotalMoney, 3, 233, 276));
            }

            sharedCards = new List<PictureBox>
            {
                flop1,flop2,flop3,turn,river
            };

            players.ForEach(p =>
            {
                p.Card1.Visible = true;
                p.Card1.Image = CardBack;
                p.Card2.Visible = true;
                p.Card2.Image = CardBack;
                p.Money.Visible = true;
                p.Image.Visible = true;
                p.TotalMoney.Visible = true;
                p.Money.Visible = true;
            });

            sharedCards.ForEach(s =>
            {
                s.Image = Properties.Resources.cardBack;
            });

            model = new PokerModel();

            model.UpdatePlayer += UpdatePlayer;
            model.RoundEnded += RoundEnded;
            model.RevealPlayerCards += RevealPlayerCards;
            model.FoldPlayerCards += FoldPlayerCards;
            model.CurrentPlayerIndicator += CurrentPlayerIncidator;
            model.StartingProcedureEnded += StartingProcedureEnded;
            model.EnableTimer += EnableTimer;
            model.DisableTimer += DisableTimer;
            model.UserChoose += UserChoose;
            model.Flop += Flop;
            model.Turn += Turn;
            model.River += River;

            model.StartNewGame(username, numOfPlayers);

            //model.Testing();

            gameTable.Enabled = true;
            gameTable.Visible = true;
        }

        private void FoldPlayerCards(object? sender, int e)
        {
            PlayerUI playerUI = players!.Find(x => x.Key == e)!;
            playerUI.Card1.Visible = false;
            playerUI.Card2.Visible = false;
        }

        private void DisableTimer(object? sender, EventArgs e)
        {
            gameTimer.Enabled = false;
        }

        private void EnableTimer(object? sender, EventArgs e)
        {
            gameTimer.Enabled = true;
        }

        private void StartingProcedureEnded(object? sender, EventArgs e)
        {
            model!.ShowUserCards();
            model.GoThroughPlayers();
        }

        private void CurrentPlayerIncidator(object? sender, int e)
        {
            PlayerUI playerUI = players!.Find(x => x.Key == e)!;
            indicator.Location = new Point(playerUI.X, playerUI.Y);
        }

        private void UserChoose(object? sender, EventArgs e)
        {
            userControls.Enabled = true;
        }

        private void Turn(object? sender, EventArgs e)
        {
            sharedCards![3].Image = cards[new Tuple<PokerColor, PokerValue>(model!.sharedCards![3]!.Color, model.sharedCards[3]!.Value)];
        }

        private void River(object? sender, EventArgs e)
        {
            sharedCards![4].Image = cards[new Tuple<PokerColor, PokerValue>(model!.sharedCards![4]!.Color, model.sharedCards[4]!.Value)];
        }

        private void Flop(object? sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                sharedCards![i].Image = cards[new Tuple<PokerColor, PokerValue>(model!.sharedCards![i]!.Color, model.sharedCards[i]!.Value)];
            }
        }

        private void RevealPlayerCards(object? sender, int e)
        {
            PlayerUI playerUI = players!.Find(x => x.Key == e)!;
            Player player = model!.players!.Find(x => x.Number == e)!;
            playerUI.Card1.Image = cards[new Tuple<PokerColor, PokerValue>(player.Cards[0]!.Color, player.Cards[0]!.Value)];
            playerUI.Card2.Image = cards[new Tuple<PokerColor, PokerValue>(player.Cards[1]!.Color, player.Cards[1]!.Value)];
        }

        private void RoundEnded(object? sender, EventArgs e)
        {
            players!.ForEach(p =>
            {
                p.TotalMoney.Text = FormatMoney(model!.players!.Find(x => x.Number == p.Key)!.Money);
                p.Card1.Image = CardBack;
                p.Card2.Image = CardBack;
                p.Money.Text = FormatMoney(0);
            });
            lblCardValue.Text = "No Value";
        }

        private void UpdatePlayer(object? sender, int e)
        {
            PlayerUI playerUI = players!.Find(x => x.Key == e)!;
            Player player = model!.players!.Find(x => x.Number == e)!;
            playerUI.TotalMoney.Text = FormatMoney(player.Money);
            playerUI.Money.Text = FormatMoney(player.MoneyOnTable);
        }

        private string FormatMoney(int money)
        {
            return $"{money} $";
        }

        private void EndGameUI()
        {
            gameTable.Enabled = false;
            gameTable.Visible = false;
            gameDetails.Visible = true;
            gameDetails.Enabled = true;
            players!.ForEach(p =>
            {
                p.Card1.Visible = false;
                p.Card2.Visible = false;
                p.Money.Visible = false;
                p.Image.Visible = false;
                p.Money.Visible = false;
                p.TotalMoney.Visible = false;
            });
        }

        private readonly Dictionary<Tuple<PokerColor, PokerValue>, Bitmap> cards = new Dictionary<Tuple<Model.PokerColor, PokerValue>, Bitmap>()
        {
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Two),Properties.Resources.D2 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Three),Properties.Resources.D3 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Four),Properties.Resources.D4 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Five),Properties.Resources.D5 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Six),Properties.Resources.D6 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Seven),Properties.Resources.D7 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Eight),Properties.Resources.D8 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Nine),Properties.Resources.D9 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Ten),Properties.Resources.D10 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Jack),Properties.Resources.DJ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Queen),Properties.Resources.DQ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.King),Properties.Resources.DK },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Diamonds,PokerValue.Ace),Properties.Resources.DA },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Two),Properties.Resources.H2 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Three),Properties.Resources.H3 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Four),Properties.Resources.H4 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Five),Properties.Resources.H5 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Six),Properties.Resources.H6 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Seven),Properties.Resources.H7 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Eight),Properties.Resources.H8 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Nine),Properties.Resources.H9 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Ten),Properties.Resources.H10 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Jack),Properties.Resources.HJ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Queen),Properties.Resources.HQ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.King),Properties.Resources.HK },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Hearts,PokerValue.Ace),Properties.Resources.HA },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Two),Properties.Resources.C2 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Three),Properties.Resources.C3 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Four),Properties.Resources.C4 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Five),Properties.Resources.C5 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Six),Properties.Resources.C6 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Seven),Properties.Resources.C7 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Eight),Properties.Resources.C8 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Nine),Properties.Resources.C9 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Ten),Properties.Resources.C10 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Jack),Properties.Resources.CJ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Queen),Properties.Resources.CQ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.King),Properties.Resources.CK },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Clubs,PokerValue.Ace),Properties.Resources.CA },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Two),Properties.Resources.S2 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Three),Properties.Resources.S3 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Four),Properties.Resources.S4 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Five),Properties.Resources.S5 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Six),Properties.Resources.S6 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Seven),Properties.Resources.S7 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Eight),Properties.Resources.S8 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Nine),Properties.Resources.S9 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Ten),Properties.Resources.S10 },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Jack),Properties.Resources.SJ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Queen),Properties.Resources.SQ },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.King),Properties.Resources.SK },
            {new Tuple<PokerColor,PokerValue>(PokerColor.Spades,PokerValue.Ace),Properties.Resources.SA }
        };

        private void btnExit_Click(object sender, EventArgs e)
        {
            EndGameUI();
        }
    }
}
