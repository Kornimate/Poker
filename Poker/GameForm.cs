using Model;

namespace Poker
{
    public partial class GameForm : Form
    {
        private readonly PokerModel? model;
        public GameForm()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {

        }

        private void btnRaise_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnFold_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private readonly Dictionary<Tuple<PokerColor,PokerValue>, Bitmap> cards = new Dictionary<Tuple<Model.PokerColor, PokerValue>, Bitmap>()
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
    }
}
