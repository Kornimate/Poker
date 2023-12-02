using Model;

namespace Poker
{
    public partial class GameForm : Form
    {
        private readonly PokerModel model;
        public GameForm()
        {
            InitializeComponent();

            model = new PokerModel("Geri", 2);
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

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
