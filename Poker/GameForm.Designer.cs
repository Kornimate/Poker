namespace Poker
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            UserControls = new GroupBox();
            btnCall = new Button();
            btnFold = new Button();
            btnRaise = new Button();
            betAmount = new NumericUpDown();
            btnCheck = new Button();
            player3BetMoney = new Label();
            player2BetMoney = new Label();
            player1BetMoney = new Label();
            userBetMoney = new Label();
            river = new PictureBox();
            turn = new PictureBox();
            flop3 = new PictureBox();
            flop2 = new PictureBox();
            flop1 = new PictureBox();
            player1Card2 = new PictureBox();
            player1Card1 = new PictureBox();
            player3Card2 = new PictureBox();
            player3Card1 = new PictureBox();
            player2Card2 = new PictureBox();
            player2Card1 = new PictureBox();
            userCard2 = new PictureBox();
            userCard1 = new PictureBox();
            pictureBox5 = new PictureBox();
            player2 = new PictureBox();
            player3 = new PictureBox();
            player1 = new PictureBox();
            user = new PictureBox();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            UserControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)betAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)river).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flop3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flop2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flop1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 495);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(904, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(93, 20);
            toolStripStatusLabel1.Text = "<username>";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(24, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(868, 73);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Details";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Location = new Point(555, 26);
            numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(189, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 30);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Number of Players";
            // 
            // button1
            // 
            button1.Location = new Point(750, 25);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 2;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 27);
            textBox2.TabIndex = 0;
            textBox2.Text = "Player01";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Green;
            groupBox2.Controls.Add(UserControls);
            groupBox2.Controls.Add(player3BetMoney);
            groupBox2.Controls.Add(player2BetMoney);
            groupBox2.Controls.Add(player1BetMoney);
            groupBox2.Controls.Add(userBetMoney);
            groupBox2.Controls.Add(river);
            groupBox2.Controls.Add(turn);
            groupBox2.Controls.Add(flop3);
            groupBox2.Controls.Add(flop2);
            groupBox2.Controls.Add(flop1);
            groupBox2.Controls.Add(player1Card2);
            groupBox2.Controls.Add(player1Card1);
            groupBox2.Controls.Add(player3Card2);
            groupBox2.Controls.Add(player3Card1);
            groupBox2.Controls.Add(player2Card2);
            groupBox2.Controls.Add(player2Card1);
            groupBox2.Controls.Add(userCard2);
            groupBox2.Controls.Add(userCard1);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(player2);
            groupBox2.Controls.Add(player3);
            groupBox2.Controls.Add(player1);
            groupBox2.Controls.Add(user);
            groupBox2.Location = new Point(24, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(868, 380);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "GameTable";
            // 
            // UserControls
            // 
            UserControls.Controls.Add(btnCall);
            UserControls.Controls.Add(btnFold);
            UserControls.Controls.Add(btnRaise);
            UserControls.Controls.Add(betAmount);
            UserControls.Controls.Add(btnCheck);
            UserControls.Location = new Point(555, 284);
            UserControls.Name = "UserControls";
            UserControls.Size = new Size(305, 90);
            UserControls.TabIndex = 27;
            UserControls.TabStop = false;
            // 
            // btnCall
            // 
            btnCall.Location = new Point(6, 17);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(94, 29);
            btnCall.TabIndex = 7;
            btnCall.Text = "Call";
            btnCall.UseVisualStyleBackColor = true;
            btnCall.Click += btnCall_Click;
            // 
            // btnFold
            // 
            btnFold.Location = new Point(6, 54);
            btnFold.Name = "btnFold";
            btnFold.Size = new Size(94, 29);
            btnFold.TabIndex = 9;
            btnFold.Text = "Fold";
            btnFold.UseVisualStyleBackColor = true;
            btnFold.Click += btnFold_Click;
            // 
            // btnRaise
            // 
            btnRaise.Location = new Point(106, 17);
            btnRaise.Name = "btnRaise";
            btnRaise.Size = new Size(93, 29);
            btnRaise.TabIndex = 8;
            btnRaise.Text = "Raise";
            btnRaise.UseVisualStyleBackColor = true;
            btnRaise.Click += btnRaise_Click;
            // 
            // betAmount
            // 
            betAmount.Location = new Point(106, 56);
            betAmount.Name = "betAmount";
            betAmount.Size = new Size(93, 27);
            betAmount.TabIndex = 10;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(205, 17);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 66);
            btnCheck.TabIndex = 11;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // player3BetMoney
            // 
            player3BetMoney.AutoSize = true;
            player3BetMoney.BackColor = SystemColors.Control;
            player3BetMoney.Location = new Point(291, 174);
            player3BetMoney.Name = "player3BetMoney";
            player3BetMoney.Size = new Size(29, 20);
            player3BetMoney.TabIndex = 26;
            player3BetMoney.Text = "0 $";
            // 
            // player2BetMoney
            // 
            player2BetMoney.AutoSize = true;
            player2BetMoney.BackColor = SystemColors.Control;
            player2BetMoney.Location = new Point(483, 112);
            player2BetMoney.Name = "player2BetMoney";
            player2BetMoney.Size = new Size(29, 20);
            player2BetMoney.TabIndex = 25;
            player2BetMoney.Text = "0 $";
            // 
            // player1BetMoney
            // 
            player1BetMoney.AutoSize = true;
            player1BetMoney.BackColor = SystemColors.Control;
            player1BetMoney.Location = new Point(542, 174);
            player1BetMoney.Name = "player1BetMoney";
            player1BetMoney.Size = new Size(29, 20);
            player1BetMoney.TabIndex = 24;
            player1BetMoney.Text = "0 $";
            // 
            // userBetMoney
            // 
            userBetMoney.AutoSize = true;
            userBetMoney.BackColor = SystemColors.Control;
            userBetMoney.Location = new Point(380, 221);
            userBetMoney.Name = "userBetMoney";
            userBetMoney.Size = new Size(29, 20);
            userBetMoney.TabIndex = 23;
            userBetMoney.Text = "0 $";
            // 
            // river
            // 
            river.BackColor = SystemColors.Control;
            river.Location = new Point(468, 165);
            river.Name = "river";
            river.Size = new Size(20, 33);
            river.TabIndex = 22;
            river.TabStop = false;
            // 
            // turn
            // 
            turn.BackColor = SystemColors.Control;
            turn.Location = new Point(446, 165);
            turn.Name = "turn";
            turn.Size = new Size(20, 33);
            turn.TabIndex = 21;
            turn.TabStop = false;
            // 
            // flop3
            // 
            flop3.BackColor = SystemColors.Control;
            flop3.Location = new Point(424, 165);
            flop3.Name = "flop3";
            flop3.Size = new Size(20, 33);
            flop3.TabIndex = 20;
            flop3.TabStop = false;
            // 
            // flop2
            // 
            flop2.BackColor = SystemColors.Control;
            flop2.Location = new Point(402, 165);
            flop2.Name = "flop2";
            flop2.Size = new Size(20, 33);
            flop2.TabIndex = 19;
            flop2.TabStop = false;
            // 
            // flop1
            // 
            flop1.BackColor = SystemColors.Control;
            flop1.Location = new Point(380, 165);
            flop1.Name = "flop1";
            flop1.Size = new Size(20, 33);
            flop1.TabIndex = 18;
            flop1.TabStop = false;
            // 
            // player1Card2
            // 
            player1Card2.BackColor = SystemColors.Control;
            player1Card2.Location = new Point(611, 180);
            player1Card2.Name = "player1Card2";
            player1Card2.Size = new Size(20, 33);
            player1Card2.TabIndex = 17;
            player1Card2.TabStop = false;
            // 
            // player1Card1
            // 
            player1Card1.BackColor = SystemColors.Control;
            player1Card1.Location = new Point(611, 141);
            player1Card1.Name = "player1Card1";
            player1Card1.Size = new Size(20, 33);
            player1Card1.TabIndex = 16;
            player1Card1.TabStop = false;
            // 
            // player3Card2
            // 
            player3Card2.BackColor = SystemColors.Control;
            player3Card2.Location = new Point(243, 180);
            player3Card2.Name = "player3Card2";
            player3Card2.Size = new Size(20, 33);
            player3Card2.TabIndex = 15;
            player3Card2.TabStop = false;
            // 
            // player3Card1
            // 
            player3Card1.BackColor = SystemColors.Control;
            player3Card1.Location = new Point(243, 141);
            player3Card1.Name = "player3Card1";
            player3Card1.Size = new Size(20, 33);
            player3Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            player3Card1.TabIndex = 14;
            player3Card1.TabStop = false;
            // 
            // player2Card2
            // 
            player2Card2.BackColor = SystemColors.Control;
            player2Card2.Location = new Point(433, 103);
            player2Card2.Name = "player2Card2";
            player2Card2.Size = new Size(20, 33);
            player2Card2.TabIndex = 13;
            player2Card2.TabStop = false;
            // 
            // player2Card1
            // 
            player2Card1.BackColor = SystemColors.Control;
            player2Card1.Location = new Point(411, 103);
            player2Card1.Name = "player2Card1";
            player2Card1.Size = new Size(20, 33);
            player2Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card1.TabIndex = 12;
            player2Card1.TabStop = false;
            // 
            // userCard2
            // 
            userCard2.BackColor = SystemColors.Control;
            userCard2.Location = new Point(62, 301);
            userCard2.Name = "userCard2";
            userCard2.Size = new Size(50, 73);
            userCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            userCard2.TabIndex = 6;
            userCard2.TabStop = false;
            // 
            // userCard1
            // 
            userCard1.BackColor = SystemColors.Control;
            userCard1.Location = new Point(6, 301);
            userCard1.Name = "userCard1";
            userCard1.Size = new Size(50, 73);
            userCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            userCard1.TabIndex = 5;
            userCard1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Sienna;
            pictureBox5.Location = new Point(227, 94);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(415, 166);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // player2
            // 
            player2.BackColor = Color.Silver;
            player2.Image = Properties.Resources.user;
            player2.Location = new Point(402, 26);
            player2.Name = "player2";
            player2.Size = new Size(57, 62);
            player2.SizeMode = PictureBoxSizeMode.Zoom;
            player2.TabIndex = 3;
            player2.TabStop = false;
            // 
            // player3
            // 
            player3.BackColor = Color.Silver;
            player3.Image = Properties.Resources.user;
            player3.Location = new Point(164, 147);
            player3.Name = "player3";
            player3.Size = new Size(57, 62);
            player3.SizeMode = PictureBoxSizeMode.Zoom;
            player3.TabIndex = 2;
            player3.TabStop = false;
            // 
            // player1
            // 
            player1.BackColor = Color.Silver;
            player1.Image = Properties.Resources.user;
            player1.Location = new Point(648, 147);
            player1.Name = "player1";
            player1.Size = new Size(57, 62);
            player1.SizeMode = PictureBoxSizeMode.Zoom;
            player1.TabIndex = 1;
            player1.TabStop = false;
            // 
            // user
            // 
            user.BackColor = Color.Silver;
            user.BorderStyle = BorderStyle.FixedSingle;
            user.Image = Properties.Resources.user;
            user.Location = new Point(402, 266);
            user.Name = "user";
            user.Size = new Size(57, 62);
            user.SizeMode = PictureBoxSizeMode.Zoom;
            user.TabIndex = 0;
            user.TabStop = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 521);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Name = "GameForm";
            Text = "GameForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            UserControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)betAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)river).EndInit();
            ((System.ComponentModel.ISupportInitialize)turn).EndInit();
            ((System.ComponentModel.ISupportInitialize)flop3).EndInit();
            ((System.ComponentModel.ISupportInitialize)flop2).EndInit();
            ((System.ComponentModel.ISupportInitialize)flop1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)user).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox pictureBox5;
        private PictureBox player2;
        private PictureBox player3;
        private PictureBox player1;
        private PictureBox user;
        private Button btnCheck;
        private NumericUpDown betAmount;
        private Button btnFold;
        private Button btnRaise;
        private Button btnCall;
        private PictureBox userCard2;
        private PictureBox userCard1;
        private PictureBox player3Card2;
        private PictureBox player3Card1;
        private PictureBox player2Card2;
        private PictureBox player2Card1;
        private PictureBox player1Card2;
        private PictureBox player1Card1;
        private Label userBetMoney;
        private PictureBox river;
        private PictureBox turn;
        private PictureBox flop3;
        private PictureBox flop2;
        private PictureBox flop1;
        private Label player3BetMoney;
        private Label player2BetMoney;
        private Label player1BetMoney;
        private GroupBox UserControls;
    }
}
