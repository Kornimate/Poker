using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class PlayerUI
    {
        public string Key { get; set; }
        public PictureBox Image { get; set; }
        public Label Money { get; set; }
        public PictureBox Card1 { get; set; }
        public PictureBox Card2 { get; set; }
        public PlayerUI(PictureBox image, Label money, PictureBox card1, PictureBox card2, string key)
        {
            this.Image = image;
            this.Money = money;
            this.Card1 = card1;
            this.Card2 = card2;
            Key = key;
        }
    }
}
