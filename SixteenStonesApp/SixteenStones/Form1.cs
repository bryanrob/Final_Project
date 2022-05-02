using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SixteenStones
{
    public partial class Form1 : Form
    {
        SixteenStones game = new SixteenStones();
        //int selectedRow = 0;

        //Color stoneColor = Color.Green;
        //Color blankColor = Color.Transparent;

        public Form1()
        {
            InitializeComponent();
            onProgramStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void messageOutput_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void startGame(object sender, MouseEventArgs e)
        {
            this.game = new SixteenStones();
            this.configureBoard(this.game.GetBoolBoard());
            this.configureTurn(this.game.GetTurn());
            this.configurePlayer(this.game.GetTurnPlayer());
            this.messageOutput.Text = this.game.GetOutputString();

            //this.selectedRow = 0;
            this.rowSelect.Text = "";
            this.stonesAmount.Text = "";
        }

        private void executeMove(object sender, MouseEventArgs e)
        {
            if (game.GetGameState())
            {
                int selectedRow;
                bool rowSuccess = Int32.TryParse(rowSelect.Text, out selectedRow);

                int amountOfStones;
                bool stonesSuccess = Int32.TryParse(stonesAmount.Text, out amountOfStones);

                if (stonesSuccess && rowSuccess)
                {
                    bool result = this.game.Move(selectedRow, amountOfStones);

                    if (result)
                    {
                        this.configureBoard(this.game.GetBoolBoard());
                    }


                    this.configureTurn(this.game.GetTurn());
                    this.configurePlayer(this.game.GetTurnPlayer());
                    if (game.GetGameState())
                    {

                        this.messageOutput.Text = this.game.GetOutputString();
                    }
                    else
                    {
                        this.messageOutput.Text = "Game over!  Player " + this.game.GetTurnPlayer().ToString() + " wins!";
                    }

                }
                else
                {
                    this.messageOutput.Text = "Input error: You may only enter numbers into the text fields.";
                }

            }
            else
            {
                //this.selectedRow = 0;
                this.rowSelect.Text = "";
                this.stonesAmount.Text = "";
            }
        }

        private void onClick(object sender, MouseEventArgs e)
        {
            //Get the button that called the functon.
            Button b = (Button)sender;

            if (b.Name.Equals("r1"))
            {
                //this.selectedRow = 1;
                rowSelect.Text = "1";
            }
            else if (b.Name.Equals("r2"))
            {
                //this.selectedRow = 2;
                rowSelect.Text = "2";
            }
            else if (b.Name.Equals("r3"))
            {
                //this.selectedRow = 3;
                rowSelect.Text = "3";
            }
            else if (b.Name.Equals("r4"))
            {
                //this.selectedRow = 4;
                rowSelect.Text = "4";
            }
            else if (b.Name.Equals("r5"))
            {
                //this.selectedRow = 5;
                rowSelect.Text = "5";
            }
        }

        private void configureBoard(bool[,] boolBoard)
        {
            if (boolBoard[0, 0]) r1s1.BringToFront();
            else r1s1.SendToBack();

            if (boolBoard[0, 1]) r1s2.BringToFront();
            else r1s2.SendToBack();

            if (boolBoard[0, 2]) r1s3.BringToFront();
            else r1s3.SendToBack();

            if (boolBoard[0, 3]) r1s4.BringToFront();
            else r1s4.SendToBack();

            if (boolBoard[0, 4]) r1s5.BringToFront();
            else r1s5.SendToBack();

            if (boolBoard[0, 5]) r1s6.BringToFront();
            else r1s6.SendToBack();

            if (boolBoard[1, 0]) r2s1.BringToFront();
            else r2s1.SendToBack();

            if (boolBoard[1, 1]) r2s2.BringToFront();
            else r2s2.SendToBack();

            if (boolBoard[1, 2]) r2s3.BringToFront();
            else r2s3.SendToBack();

            if (boolBoard[1, 3]) r2s4.BringToFront();
            else r2s4.SendToBack();

            if (boolBoard[1, 4]) r2s5.BringToFront();
            else r2s5.SendToBack();

            if (boolBoard[1, 5]) r2s6.BringToFront();
            else r2s5.SendToBack();

            if (boolBoard[2, 0]) r3s1.BringToFront();
            else r3s1.SendToBack();

            if (boolBoard[2, 1]) r3s2.BringToFront();
            else r3s2.SendToBack();

            if (boolBoard[2, 2]) r3s3.BringToFront();
            else r3s3.SendToBack();

            if (boolBoard[2, 3]) r3s4.BringToFront();
            else r3s4.SendToBack();

            if (boolBoard[2, 4]) r3s5.BringToFront();
            else r3s5.SendToBack();

            if (boolBoard[2, 5]) r3s6.BringToFront();
            else r3s6.SendToBack();

            if (boolBoard[3, 0]) r4s1.BringToFront();
            else r4s1.SendToBack();

            if (boolBoard[3, 1]) r4s2.BringToFront();
            else r4s2.SendToBack();

            if (boolBoard[3, 2]) r4s3.BringToFront();
            else r4s3.SendToBack();

            if (boolBoard[3, 3]) r4s4.BringToFront();
            else r4s4.SendToBack();

            if (boolBoard[3, 4]) r4s5.BringToFront();
            else r4s5.SendToBack();

            if (boolBoard[3, 5]) r4s6.BringToFront();
            else r4s6.SendToBack();

            if (boolBoard[4, 0]) r5s1.BringToFront();
            else r5s1.SendToBack();

            if (boolBoard[4, 1]) r5s2.BringToFront();
            else r5s2.SendToBack();

            if (boolBoard[4, 2]) r5s3.BringToFront();
            else r5s3.SendToBack();

            if (boolBoard[4, 3]) r5s4.BringToFront();
            else r5s4.SendToBack();

            if (boolBoard[4, 4]) r5s5.BringToFront();
            else r5s5.SendToBack();

            if (boolBoard[4, 5]) r5s6.BringToFront();
            else r5s6.SendToBack();
        }

        private void configureTurn(int turn)
        {
            this.turnCounter.Text = "Turn: " + turn.ToString();
        }
        private void configurePlayer(int player)
        {
            this.turnPlayer.Text = "Player " + player.ToString() + ", go!";
        }
        private void onProgramStart()
        {
            messageOutput.Text = "Select 'Initialize' to begin the game!";
            turnCounter.Text = "Turn: _";
            turnPlayer.Text = "Player: _, go!";

            int gridx = picCanvas.Width;
            int gridy = picCanvas.Height;

            picCanvas.Controls.Add(boardBackground);

            picCanvas.Controls.Add(r1s1);
            picCanvas.Controls.Add(r1s2);
            picCanvas.Controls.Add(r1s3);
            picCanvas.Controls.Add(r1s4);
            picCanvas.Controls.Add(r1s5);
            picCanvas.Controls.Add(r1s6);
            picCanvas.Controls.Add(r2s1);
            picCanvas.Controls.Add(r2s2);
            picCanvas.Controls.Add(r2s3);
            picCanvas.Controls.Add(r2s4);
            picCanvas.Controls.Add(r2s5);
            picCanvas.Controls.Add(r2s6);
            picCanvas.Controls.Add(r3s1);
            picCanvas.Controls.Add(r3s2);
            picCanvas.Controls.Add(r3s3);
            picCanvas.Controls.Add(r3s4);
            picCanvas.Controls.Add(r3s5);
            picCanvas.Controls.Add(r3s6);
            picCanvas.Controls.Add(r4s1);
            picCanvas.Controls.Add(r4s2);
            picCanvas.Controls.Add(r4s3);
            picCanvas.Controls.Add(r4s4);
            picCanvas.Controls.Add(r4s5);
            picCanvas.Controls.Add(r4s6);
            picCanvas.Controls.Add(r5s1);
            picCanvas.Controls.Add(r5s2);
            picCanvas.Controls.Add(r5s3);
            picCanvas.Controls.Add(r5s4);
            picCanvas.Controls.Add(r5s5);
            picCanvas.Controls.Add(r5s6);

            boardBackground.SendToBack();
        }

        private void r1s1_Click(object sender, EventArgs e)
        {

        }

        private void r1s2_Click(object sender, EventArgs e)
        {

        }

        private void r1s3_Click(object sender, EventArgs e)
        {

        }

        private void r1s4_Click(object sender, EventArgs e)
        {

        }

        private void r1s5_Click(object sender, EventArgs e)
        {

        }

        private void r1s6_Click(object sender, EventArgs e)
        {

        }

        private void r2s1_Click(object sender, EventArgs e)
        {

        }

        private void r2s2_Click(object sender, EventArgs e)
        {

        }

        private void r2s3_Click(object sender, EventArgs e)
        {

        }

        private void r2s4_Click(object sender, EventArgs e)
        {

        }

        private void r3s1_Click(object sender, EventArgs e)
        {

        }

        private void r3s2_Click(object sender, EventArgs e)
        {

        }

        private void r3s3_Click(object sender, EventArgs e)
        {

        }

        private void r4s1_Click(object sender, EventArgs e)
        {

        }

        private void r4s2_Click(object sender, EventArgs e)
        {

        }

        private void r5s1_Click(object sender, EventArgs e)
        {

        }
    }
}