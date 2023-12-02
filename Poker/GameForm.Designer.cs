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
            lblUserName = new ToolStripStatusLabel();
            lblCardValue = new ToolStripStatusLabel();
            gameDetails = new GroupBox();
            nmPlayerNumber = new NumericUpDown();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            txtUserName = new TextBox();
            gameTable = new GroupBox();
            player3TotalMoney = new Label();
            player2TotalMoney = new Label();
            player1TotalMoney = new Label();
            userTotalMoney = new Label();
            btnExit = new Button();
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
            player2Image = new PictureBox();
            player3Image = new PictureBox();
            player1Image = new PictureBox();
            userImage = new PictureBox();
            statusStrip1.SuspendLayout();
            gameDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmPlayerNumber).BeginInit();
            gameTable.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)player2Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUserName, lblCardValue });
            statusStrip1.Location = new Point(0, 495);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(904, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUserName
            // 
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 20);
            lblUserName.Text = "<username>";
            // 
            // lblCardValue
            // 
            lblCardValue.Name = "lblCardValue";
            lblCardValue.Size = new Size(69, 20);
            lblCardValue.Text = "No Value";
            // 
            // gameDetails
            // 
            gameDetails.Controls.Add(nmPlayerNumber);
            gameDetails.Controls.Add(label2);
            gameDetails.Controls.Add(button1);
            gameDetails.Controls.Add(label1);
            gameDetails.Controls.Add(txtUserName);
            gameDetails.Location = new Point(24, 21);
            gameDetails.Name = "gameDetails";
            gameDetails.Size = new Size(868, 73);
            gameDetails.TabIndex = 4;
            gameDetails.TabStop = false;
            gameDetails.Text = "Game Details";
            // 
            // nmPlayerNumber
            // 
            nmPlayerNumber.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            nmPlayerNumber.Location = new Point(555, 26);
            nmPlayerNumber.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nmPlayerNumber.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nmPlayerNumber.Name = "nmPlayerNumber";
            nmPlayerNumber.ReadOnly = true;
            nmPlayerNumber.Size = new Size(189, 27);
            nmPlayerNumber.TabIndex = 4;
            nmPlayerNumber.TextAlign = HorizontalAlignment.Center;
            nmPlayerNumber.Value = new decimal(new int[] { 2, 0, 0, 0 });
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
            button1.Click += startBtn_Click;
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
            // txtUserName
            // 
            txtUserName.Location = new Point(99, 26);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(279, 27);
            txtUserName.TabIndex = 0;
            txtUserName.Text = "Player01";
            // 
            // gameTable
            // 
            gameTable.BackColor = Color.Green;
            gameTable.Controls.Add(player3TotalMoney);
            gameTable.Controls.Add(player2TotalMoney);
            gameTable.Controls.Add(player1TotalMoney);
            gameTable.Controls.Add(userTotalMoney);
            gameTable.Controls.Add(btnExit);
            gameTable.Controls.Add(UserControls);
            gameTable.Controls.Add(player3BetMoney);
            gameTable.Controls.Add(player2BetMoney);
            gameTable.Controls.Add(player1BetMoney);
            gameTable.Controls.Add(userBetMoney);
            gameTable.Controls.Add(river);
            gameTable.Controls.Add(turn);
            gameTable.Controls.Add(flop3);
            gameTable.Controls.Add(flop2);
            gameTable.Controls.Add(flop1);
            gameTable.Controls.Add(player1Card2);
            gameTable.Controls.Add(player1Card1);
            gameTable.Controls.Add(player3Card2);
            gameTable.Controls.Add(player3Card1);
            gameTable.Controls.Add(player2Card2);
            gameTable.Controls.Add(player2Card1);
            gameTable.Controls.Add(userCard2);
            gameTable.Controls.Add(userCard1);
            gameTable.Controls.Add(pictureBox5);
            gameTable.Controls.Add(player2Image);
            gameTable.Controls.Add(player3Image);
            gameTable.Controls.Add(player1Image);
            gameTable.Controls.Add(userImage);
            gameTable.Enabled = false;
            gameTable.Location = new Point(24, 112);
            gameTable.Name = "gameTable";
            gameTable.Size = new Size(868, 380);
            gameTable.TabIndex = 5;
            gameTable.TabStop = false;
            gameTable.Text = "GameTable";
            gameTable.Visible = false;
            // 
            // player3TotalMoney
            // 
            player3TotalMoney.AutoSize = true;
            player3TotalMoney.BackColor = SystemColors.Control;
            player3TotalMoney.Location = new Point(83, 174);
            player3TotalMoney.Name = "player3TotalMoney";
            player3TotalMoney.Size = new Size(29, 20);
            player3TotalMoney.TabIndex = 32;
            player3TotalMoney.Text = "0 $";
            player3TotalMoney.Visible = false;
            // 
            // player2TotalMoney
            // 
            player2TotalMoney.AutoSize = true;
            player2TotalMoney.BackColor = SystemColors.Control;
            player2TotalMoney.Location = new Point(494, 47);
            player2TotalMoney.Name = "player2TotalMoney";
            player2TotalMoney.Size = new Size(29, 20);
            player2TotalMoney.TabIndex = 31;
            player2TotalMoney.Text = "0 $";
            player2TotalMoney.Visible = false;
            // 
            // player1TotalMoney
            // 
            player1TotalMoney.AutoSize = true;
            player1TotalMoney.BackColor = SystemColors.Control;
            player1TotalMoney.Location = new Point(750, 174);
            player1TotalMoney.Name = "player1TotalMoney";
            player1TotalMoney.Size = new Size(29, 20);
            player1TotalMoney.TabIndex = 30;
            player1TotalMoney.Text = "0 $";
            player1TotalMoney.Visible = false;
            // 
            // userTotalMoney
            // 
            userTotalMoney.AutoSize = true;
            userTotalMoney.BackColor = SystemColors.Control;
            userTotalMoney.Location = new Point(329, 284);
            userTotalMoney.Name = "userTotalMoney";
            userTotalMoney.Size = new Size(29, 20);
            userTotalMoney.TabIndex = 29;
            userTotalMoney.Text = "0 $";
            userTotalMoney.Visible = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(826, 26);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.TabIndex = 28;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            player3BetMoney.Visible = false;
            // 
            // player2BetMoney
            // 
            player2BetMoney.AutoSize = true;
            player2BetMoney.BackColor = SystemColors.Control;
            player2BetMoney.Location = new Point(494, 113);
            player2BetMoney.Name = "player2BetMoney";
            player2BetMoney.Size = new Size(29, 20);
            player2BetMoney.TabIndex = 25;
            player2BetMoney.Text = "0 $";
            player2BetMoney.Visible = false;
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
            player1BetMoney.Visible = false;
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
            userBetMoney.Visible = false;
            // 
            // river
            // 
            river.BackColor = SystemColors.Control;
            river.Location = new Point(503, 155);
            river.Name = "river";
            river.Size = new Size(30, 43);
            river.SizeMode = PictureBoxSizeMode.StretchImage;
            river.TabIndex = 22;
            river.TabStop = false;
            // 
            // turn
            // 
            turn.BackColor = SystemColors.Control;
            turn.Location = new Point(467, 155);
            turn.Name = "turn";
            turn.Size = new Size(30, 43);
            turn.SizeMode = PictureBoxSizeMode.StretchImage;
            turn.TabIndex = 21;
            turn.TabStop = false;
            // 
            // flop3
            // 
            flop3.BackColor = SystemColors.Control;
            flop3.Location = new Point(423, 155);
            flop3.Name = "flop3";
            flop3.Size = new Size(30, 43);
            flop3.SizeMode = PictureBoxSizeMode.StretchImage;
            flop3.TabIndex = 20;
            flop3.TabStop = false;
            // 
            // flop2
            // 
            flop2.BackColor = SystemColors.Control;
            flop2.Location = new Point(387, 155);
            flop2.Name = "flop2";
            flop2.Size = new Size(30, 43);
            flop2.SizeMode = PictureBoxSizeMode.StretchImage;
            flop2.TabIndex = 19;
            flop2.TabStop = false;
            // 
            // flop1
            // 
            flop1.BackColor = SystemColors.Control;
            flop1.Location = new Point(351, 155);
            flop1.Name = "flop1";
            flop1.Size = new Size(30, 43);
            flop1.SizeMode = PictureBoxSizeMode.StretchImage;
            flop1.TabIndex = 18;
            flop1.TabStop = false;
            // 
            // player1Card2
            // 
            player1Card2.BackColor = SystemColors.Control;
            player1Card2.Location = new Point(600, 180);
            player1Card2.Name = "player1Card2";
            player1Card2.Size = new Size(30, 43);
            player1Card2.SizeMode = PictureBoxSizeMode.StretchImage;
            player1Card2.TabIndex = 17;
            player1Card2.TabStop = false;
            player1Card2.Visible = false;
            // 
            // player1Card1
            // 
            player1Card1.BackColor = SystemColors.Control;
            player1Card1.Location = new Point(600, 131);
            player1Card1.Name = "player1Card1";
            player1Card1.Size = new Size(30, 43);
            player1Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1Card1.TabIndex = 16;
            player1Card1.TabStop = false;
            player1Card1.Visible = false;
            // 
            // player3Card2
            // 
            player3Card2.BackColor = SystemColors.Control;
            player3Card2.Location = new Point(243, 180);
            player3Card2.Name = "player3Card2";
            player3Card2.Size = new Size(30, 43);
            player3Card2.SizeMode = PictureBoxSizeMode.StretchImage;
            player3Card2.TabIndex = 15;
            player3Card2.TabStop = false;
            player3Card2.Visible = false;
            // 
            // player3Card1
            // 
            player3Card1.BackColor = SystemColors.Control;
            player3Card1.Location = new Point(243, 131);
            player3Card1.Name = "player3Card1";
            player3Card1.Size = new Size(30, 43);
            player3Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            player3Card1.TabIndex = 14;
            player3Card1.TabStop = false;
            player3Card1.Visible = false;
            // 
            // player2Card2
            // 
            player2Card2.BackColor = SystemColors.Control;
            player2Card2.Location = new Point(447, 103);
            player2Card2.Name = "player2Card2";
            player2Card2.Size = new Size(30, 43);
            player2Card2.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card2.TabIndex = 13;
            player2Card2.TabStop = false;
            // 
            // player2Card1
            // 
            player2Card1.BackColor = SystemColors.Control;
            player2Card1.Location = new Point(411, 103);
            player2Card1.Name = "player2Card1";
            player2Card1.Size = new Size(30, 43);
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
            // player2Image
            // 
            player2Image.BackColor = Color.Silver;
            player2Image.Image = Properties.Resources.user;
            player2Image.Location = new Point(411, 26);
            player2Image.Name = "player2Image";
            player2Image.Size = new Size(57, 62);
            player2Image.SizeMode = PictureBoxSizeMode.Zoom;
            player2Image.TabIndex = 3;
            player2Image.TabStop = false;
            player2Image.Visible = false;
            // 
            // player3Image
            // 
            player3Image.BackColor = Color.Silver;
            player3Image.Image = Properties.Resources.user;
            player3Image.Location = new Point(164, 147);
            player3Image.Name = "player3Image";
            player3Image.Size = new Size(57, 62);
            player3Image.SizeMode = PictureBoxSizeMode.Zoom;
            player3Image.TabIndex = 2;
            player3Image.TabStop = false;
            player3Image.Visible = false;
            // 
            // player1Image
            // 
            player1Image.BackColor = Color.Silver;
            player1Image.Image = Properties.Resources.user;
            player1Image.Location = new Point(648, 147);
            player1Image.Name = "player1Image";
            player1Image.Size = new Size(57, 62);
            player1Image.SizeMode = PictureBoxSizeMode.Zoom;
            player1Image.TabIndex = 1;
            player1Image.TabStop = false;
            player1Image.Visible = false;
            // 
            // userImage
            // 
            userImage.BackColor = Color.Silver;
            userImage.BorderStyle = BorderStyle.FixedSingle;
            userImage.Image = Properties.Resources.user;
            userImage.Location = new Point(411, 266);
            userImage.Name = "userImage";
            userImage.Size = new Size(57, 62);
            userImage.SizeMode = PictureBoxSizeMode.Zoom;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 521);
            Controls.Add(gameTable);
            Controls.Add(gameDetails);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GameForm";
            Text = "GameForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            gameDetails.ResumeLayout(false);
            gameDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmPlayerNumber).EndInit();
            gameTable.ResumeLayout(false);
            gameTable.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)player2Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUserName;
        private GroupBox gameDetails;
        private TextBox txtUserName;
        private NumericUpDown nmPlayerNumber;
        private Label label2;
        private Button button1;
        private Label label1;
        private GroupBox gameTable;
        private PictureBox pictureBox5;
        private PictureBox player2Image;
        private PictureBox player3Image;
        private PictureBox player1Image;
        private PictureBox userImage;
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
        private Button btnExit;
        private Label player2TotalMoney;
        private Label player1TotalMoney;
        private Label userTotalMoney;
        private Label player3TotalMoney;
        private ToolStripStatusLabel lblCardValue;
    }
}
