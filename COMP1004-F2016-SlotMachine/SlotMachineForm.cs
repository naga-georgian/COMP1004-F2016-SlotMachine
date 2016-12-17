using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_SlotMachine
{
    public partial class SlotMachineForm : Form
    {
        private int playerMoney = 500;
        private int winnings = 0;
        private int jackpot = 5000;
        private float turn = 0.0f;
        private int playerBet = 0;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            MessageBox.Show(stats, "Player Stats");
        }

        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            playerMoney = 500;
            winnings = 0;
            jackpot = 5000;
            turn = 0;
            playerBet = 5;
            winNumber = 0;
            lossNumber = 0;
            winRatio = 0.0f;

            // reset labels
            lbl_Jackpot.Text = jackpot.ToString();
            lbl_Credits.Text = playerMoney.ToString();
            lbl_Bet.Text = playerBet.ToString();
        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                lbl_Paid.Text = "JACKPOT!!";
                MessageBox.Show("You Won the $" + jackpot + " Jackpot!!", "Jackpot!!");
                playerMoney += jackpot;
                jackpot = 1000;
            }
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;
            lbl_Paid.Text = "Won: $" + winnings;
            resetFruitTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            lbl_Paid.Text = "Lost!";
            resetFruitTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;
        }

        /* When this function is called it determines the betLine results.
        e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " " };
            int[] outCome = { 0, 0, 0 };


            // for each reel
            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;

                if (checkRange(outCome[spin], 1, 27))
                {  // 41.5% probability
                    betLine[spin] = "blank";
                    blanks++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.blank);
                }
                else if (checkRange(outCome[spin], 28, 37))
                { // 15.4% probability
                    betLine[spin] = "Grapes";
                    grapes++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.grapes);
                }
                else if (checkRange(outCome[spin], 38, 46))
                { // 13.8% probability
                    betLine[spin] = "Banana";
                    bananas++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.banana);
                }
                else if (checkRange(outCome[spin], 47, 54))
                { // 12.3% probability
                    betLine[spin] = "Orange";
                    oranges++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.orange);
                }
                else if (checkRange(outCome[spin], 55, 59))
                { //  7.7% probability
                    betLine[spin] = "Cherry";
                    cherries++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.cherry);
                }
                else if (checkRange(outCome[spin], 60, 62))
                { //  4.6% probability
                    betLine[spin] = "Bar";
                    bars++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.bar);
                }
                else if (checkRange(outCome[spin], 63, 64))
                { //  3.1% probability
                    betLine[spin] = "Bell";
                    bells++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.bell);
                }
                else if (checkRange(outCome[spin], 65, 65))
                { //  1.5% probability
                    betLine[spin] = "Seven";
                    sevens++;
                    setReelPicture(spin, COMP1004_F2016_SlotMachine.Properties.Resources.seven);
                }
            }
            return betLine;
        }

        //--------------------------------------------------------------------------------
        // Sets picture of the reel with corresponding spin number
        //--------------------------------------------------------------------------------
        public void setReelPicture(int spin, Image resultImage)
        {
            if (spin == 0)
            {
                pictureBox_Reel1.Image = resultImage;
            }
            else if (spin == 1)
            {
                pictureBox_Reel2.Image = resultImage;
            }
            else
            {
                pictureBox_Reel3.Image = resultImage;
            }
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings = playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings = playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings = playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings = playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings = playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings = playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }
        }

        //--------------------------------------------------------------------------------
        // The user clicked the SPIN button - validate that they are able to play and
        // spin the reels!
        //--------------------------------------------------------------------------------
        private void SpinPictureBox_Click(object sender, EventArgs e)
        {
            if (playerMoney <= 0)
            {
                if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetAll();
                }
            }
            else if (playerBet > playerMoney)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
            }
            else if (playerBet < 0)
            {
                MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
            }
            else if (playerBet <= playerMoney)
            {
                playerMoney -= playerBet;
                spinResult = Reels();
                lbl_Credits.Text = playerMoney.ToString();

                fruits = spinResult[0] + " - " + spinResult[1] + " - " + spinResult[2];
                determineWinnings();
                lbl_Credits.Text = playerMoney.ToString();
                turn++;

                // increment the jackpot
                jackpot++;
                lbl_Jackpot.Text = jackpot.ToString();

                // check if the user ran out of money from their last spin
                if (playerMoney <= 0)
                {
                    if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        resetAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount");
            }
        }

        //--------------------------------------------------------------------------------
        // Set the labels and default player bet on load
        //--------------------------------------------------------------------------------
        private void SlotMachineForm_Load(object sender, EventArgs e)
        {
            // set labels
            lbl_Credits.Text = playerMoney.ToString();
            lbl_Jackpot.Text = jackpot.ToString();
            lbl_Bet.Text = "5";
            lbl_Paid.Text = "0";

            // default bet amount
            playerBet = 5;
        }

        //--------------------------------------------------------------------------------
        // BET BUTTONS - set the label and playerBet if the user has enough money to
        //               place the bet
        //--------------------------------------------------------------------------------
        private void pictureBox_Bet1_Click(object sender, EventArgs e)
        {
            if (playerMoney < 1)
            {
                MessageBox.Show("You don't have enough money to place that bet!", "Insufficient Funds");
            }
            else
            {
                lbl_Bet.Text = "1";
                playerBet = 1;
            }
        }

        private void pictureBox_Bet5_Click(object sender, EventArgs e)
        {
            if (playerMoney < 5)
            {
                MessageBox.Show("You don't have enough money to place that bet!", "Insufficient Funds");
            }
            else
            {
                lbl_Bet.Text = "5";
                playerBet = 5;
            }
        }

        private void pictureBox_Bet25_Click(object sender, EventArgs e)
        {
            if (playerMoney < 25)
            {
                MessageBox.Show("You don't have enough money to place that bet!", "Insufficient Funds");
            }
            else
            {
                lbl_Bet.Text = "25";
                playerBet = 25;
            }
        }

        private void pictureBox_Bet50_Click(object sender, EventArgs e)
        {
            if (playerMoney < 50)
            {
                MessageBox.Show("You don't have enough money to place that bet!", "Insufficient Funds");
            }
            else
            {
                lbl_Bet.Text = "50";
                playerBet = 50;
            }
        }

        private void pictureBox_Bet100_Click(object sender, EventArgs e)
        {
            if (playerMoney < 100)
            {
                MessageBox.Show("You don't have enough money to place that bet!", "Insufficient Funds");
            }
            else
            {
                lbl_Bet.Text = "100";
                playerBet = 100;
            }
        }


        //--------------------------------------------------------------------------------
        // The user clicked the reset button - Reset all the values and labels to default
        //--------------------------------------------------------------------------------
        private void pictureBox_Reset_Click(object sender, EventArgs e)
        {
            resetAll();
            lbl_Credits.Text = playerMoney.ToString();
            lbl_Bet.Text = playerBet.ToString();
        }

        //--------------------------------------------------------------------------------
        // Close the application
        //--------------------------------------------------------------------------------
        private void pictureBox_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------------------------------
        // Show the player stats when the user clicks the STATS button
        //--------------------------------------------------------------------------------
        private void btn_Stats_Click(object sender, EventArgs e)
        {
            showPlayerStats();
        }
    }

}
