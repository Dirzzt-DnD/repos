using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/*
 * Made by WangZhen
 * ‎Creation time:10/03/2020，‏‎15:34:12
 * Double player version of SixOfOne
 */

namespace Six_of_one
{
    public partial class SixOfOne : Form
    {
        public SixOfOne()
        {
            InitializeComponent();
            picBoxes = new PictureBox[] { picbx1, picbx2, picbx3, picbx4, picbx5, picbx6 };
        }
        //Player dice
        int[] dice;
        //Player1 name and player2 name
        string player1;
        string player2;
        //Turn number
        int turn=1;
        //Record player1 and player2 score
        int scorePlayer1;
        int scorePlayer2;
        //Goal variable
        int goal;
        //picturebox index
        int n = 0;
        //Players win turns
        int player1Winturn = 0;
        int player2Winturn = 0;
        //Decide whatther run next turn
        Boolean over = true;
        PictureBox[] picBoxes;

        private void Roll_Click(object sender, EventArgs e)
        {
            //Clear picture in picture box
            clear();
            //Random dice value
            Random num1 = new Random();
            int diceQuantity = 0;
            try
            {
                if (tbxDice1.Text.Equals(""))
                {
                    MessageBox.Show("Please enter an number");
                    return;
                }
                else if (Convert.ToInt32(tbxDice1.Text) > 6 || Convert.ToInt32(tbxDice1.Text) == 0)
                {
                    MessageBox.Show("NO MORE THAN SIX DICE OR DICE QUANTITY IS 0");
                    return;
                }
                else
                {
                    //user input dice quantity and define how many element in array
                    diceQuantity = Convert.ToInt32(tbxDice1.Text);
                    dice = new int[diceQuantity];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n Please don't input character");
                return;
            }
            //Display turn
            tbxOutput.AppendText("Turn " + turn.ToString() + "\r\n");
            //Declear each element in array
            for (int x = 0; x < dice.Length; x++)
            {
                dice[x] = num1.Next(1,7);
            }
            DiceAnimation animationDice = new DiceAnimation();
            animationDice.Ainmation(picBoxes, diceQuantity, dice);
            //Reset index of picturebox
            n = 0;
            //Display game result
            tbxOutput.AppendText(player1 + "'s dice values are");
            //Run function to decide result
            ruleGame(player1, player2, dice, ref scorePlayer1, lblplayer1Score, ref player1Winturn, ref player2Winturn,lblplayer1Winturn,lblplayer2Winturn) ;
            //Record turn
            turn++;
            if (over == true)
            {
                //Change order
                rdPlayer2.Checked = true;
            }
        }

        private void Roll2_Click(object sender, EventArgs e)
        {
            //Clear picture in picture box
            clear();
            //Random dice value
            Random num2 = new Random();
            int diceQuantity = 0;
            try
            {
                if (tbxDice2.Text.Equals(""))
                {
                    MessageBox.Show("Please enter an number");
                    return;
                }
                else if (Convert.ToInt32(tbxDice2.Text) > 6 || Convert.ToInt32(tbxDice2.Text) == 0)
                {
                    MessageBox.Show("NO MORE THAN SIX DICE OR DICE QUANTITY IS 0");
                    return;
                }
                else
                {
                    //user input dice quantity and define how many element in array
                    diceQuantity = Convert.ToInt32(tbxDice2.Text);
                    dice = new int[diceQuantity];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n Please don't input character");
                return;
            }
            //Display turn
            tbxOutput.AppendText("Turn " + turn.ToString() + "\r\n");
            //Declear each element in array
            for (int x = 0; x < dice.Length; x++)
            {
                dice[x] = num2.Next(1,7);
            }
            //display animation
            DiceAnimation animationDice = new DiceAnimation();
            animationDice.Ainmation(picBoxes, diceQuantity, dice);
            //Reset index of picturebox
            n = 0;
            //Display game result
            tbxOutput.AppendText(player2 + "'s dice values are");
            //Run function to decide result
            ruleGame(player2, player1, dice,ref scorePlayer2,lblplayer2Score,ref player2Winturn,ref player1Winturn,lblplayer2Winturn,lblplayer1Winturn);
            //Record turn
            turn++;
            if (over == true)
            {
                //Change order
                rdPlayer1.Checked = true;
            }
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            //Show a Winform to input player name
            InputBox input1 = new InputBox("Name","Input player1's name");
            input1.ShowDialog();
            //Prevent player don't input name
            if (input1.Inputvalue.Equals(""))
            {
                MessageBox.Show("Please enter a name, input again");
                return;
            }
            InputBox input2 = new InputBox("Name", "Input player2's name");
            input2.ShowDialog();
            if (input2.Inputvalue.Equals(""))
            {
                MessageBox.Show("Please enter a name, input again");
                return;
            }
            //Input number of goal
            try
            {
                //Input number of goal
                InputBox input3 = new InputBox("Goal", "Input a number of goal ");
                input3.ShowDialog();
                if (input3.Inputvalue.Equals(""))
                {
                    MessageBox.Show("Please enter a number, input again");
                    return;
                }
                goal = Convert.ToInt32(input3.Inputvalue);
                if (goal < 50 || goal > 100)
                {
                    MessageBox.Show("Please enter a number between 50 and 100");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n Please don't input character");
                return;
            }
            //Display goal
            lblGoal.Text = goal.ToString();
            //Store value in player1 and player2
            //Show name by label
            player1 = input1.Inputvalue;
            lblPlayer1name.Text = input1.Inputvalue;
            player2 = input2.Inputvalue;
            lblPlayer2name.Text = input2.Inputvalue;
            reSetGame();
            //Reset winturn and turn
            player1Winturn = 0;
            player2Winturn = 0;
            lblplayer1Winturn.Text = "0";
            lblplayer2Winturn.Text = "0";
           
        }


        private void rdPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            //Change player order
            if (rdPlayer1.Checked)
            {
                Roll1.Visible = true;
                Roll2.Visible = false;
            }
        }

        private void rdPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            //Change player order
            if (rdPlayer2.Checked)
            {
                Roll1.Visible = false;
                Roll2.Visible = true;
            }
        }
        //Player1name mean that player who are playing. Player2Name mean that player who are waiting for next turn.
        //winTurn1, winTurn2,lblone and lblTwo are same reason.
        //ref for change value in scorePlayer1 or scorePlayer2
        private void ruleGame(string player1Name, string player2Name, int[] dice, ref int scorePlayer, Label lblscore, ref int winTurn1, ref int winTurn2, Label lblone,Label lblTwo)
        {
            //Count how many 1 in value
            int playerOne=0;
            //Count sum of array
            int sumPlayer = 0;
            //Count how many 1 and sum in same time
            for (int x = 0; x < dice.Length; x++)
            {
                if (dice[x] == 1)
                {
                    playerOne++;
                }
                sumPlayer += dice[x];
                tbxOutput.AppendText(dice[x].ToString() + " ");
            }
            //Count player score
            scorePlayer = scorePlayer + sumPlayer;
            tbxOutput.AppendText("\r\n");
            //According to playerOne value, programe decide to tigger which statement run
            if (playerOne == 1)
            {
                scorePlayer = scorePlayer - sumPlayer;
                tbxOutput.AppendText("Roll a 1. " + player1Name + " get nothing in the turn\r\n");
                lblscore.Text = scorePlayer.ToString();
            }
            else if (playerOne == 2)
            {
                //Clear value in scoreplayer according to ref
                scorePlayer = 0;
                tbxOutput.AppendText("snake’s eyes, " + player1Name + " score clear.\r\n");
                lblscore.Text = scorePlayer.ToString();
            }
            else if (playerOne == 3)
            {
                tbxOutput.AppendText("Dead drop " + player1Name + " lose." + player2Name + " win!\r\n");
                //Once a player win the turn. Both player score will be clear
                scorePlayer1 = 0;
                scorePlayer2 = 0;
                //Display score
                lblplayer1Score.Text = "0";
                lblplayer2Score.Text = "0";
                //Display win turn
                winTurn2++;
                lblTwo.Text = winTurn2.ToString();
                //Stop game
                over = false;
                //Display play again!
                playAgain.Visible = true;
                //Invisiable button
                Roll1.Visible = false;
                Roll2.Visible = false;
           }
            else if (playerOne >= 4)
            {
                tbxOutput.AppendText("Bboojum! " + player1Name + " win! " + player2Name + " lose.\r\n");
                //Once a player win the turn. Both player score will be clear
                scorePlayer = 0;
                scorePlayer1 = 0;
                scorePlayer2 = 0;
                //Display score
                lblplayer1Score.Text = "0";
                lblplayer2Score.Text = "0";
                //Display win turn
                winTurn1++;
                lblone.Text = winTurn1.ToString();
                //Stop game
                over = false;
                //Display play again!
                playAgain.Visible = true;
                //Invisiable button
                Roll1.Visible = false;
                Roll2.Visible = false;
            }
            else if (scorePlayer >= goal)
            {
                tbxOutput.AppendText(player1Name + " win!" + " Score is " + scorePlayer.ToString() + "\r\n");
                //Once a player win the turn. Both player score will be clear
                scorePlayer = 0;
                scorePlayer1 = 0;
                scorePlayer2 = 0;
                //Display win turn
                winTurn1++;
                lblone.Text = winTurn1.ToString();
                lblplayer1Score.Text = "0";
                lblplayer2Score.Text = "0";
                //Stop game
                over = false;
                //Display play again!
                playAgain.Visible = true;
                //Invisiable button
                Roll1.Visible = false;
                Roll2.Visible = false;
            }
            else
            {
                //If don't have any 1 in array, scorePlayer add sum of array by a variable
                tbxOutput.AppendText(player1Name + " score is " + scorePlayer + "\r\n");
                lblscore.Text = scorePlayer.ToString();
            }
        }
        
       
       
        //Clear picturebox
        private void clear()
        {
            Graphics graph1 = picbx1.CreateGraphics();
            graph1.Clear(Control.DefaultBackColor);
            Graphics graph2 = picbx2.CreateGraphics();
            graph2.Clear(Control.DefaultBackColor);
            Graphics graph3 = picbx3.CreateGraphics();
            graph3.Clear(Control.DefaultBackColor);
            Graphics graph4 = picbx4.CreateGraphics();
            graph4.Clear(Control.DefaultBackColor);
            Graphics graph5 = picbx5.CreateGraphics();
            graph5.Clear(Control.DefaultBackColor);
            Graphics graph6 = picbx6.CreateGraphics();
            graph6.Clear(Control.DefaultBackColor);

        }
        private void reSetGame()
        {
            rdPlayer1.Checked = false;
            rdPlayer2.Checked = false;
            clear();
            //Reset over
            over = true;
            //Random a number to decide order
            Random order = new Random();
            int x = order.Next(0, 101);
            //Clear turn
            turn = 1;
            //Clear output
            tbxOutput.Text = "";
            //Even number is Player1 first
            if (x % 2 == 0)
            {
                rdPlayer1.Checked = true;
                tbxOutput.AppendText(player1 + " First!\r\n");
            }
            else
            //Odd number is Player2 first
            {
                rdPlayer2.Checked = true;
                tbxOutput.AppendText(player2 + " First!\r\n");
            }
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            //Input number of goal
            InputBox input3 = new InputBox("Goal", "Input a number of goal ");
            input3.ShowDialog();
            try
            {
                if (input3.Inputvalue.Equals(""))
                {
                    MessageBox.Show("Please enter a number, input again");
                    playAgain.Visible = true;
                    return;
                }
                goal = Convert.ToInt32(input3.Inputvalue);
                if (goal < 50 || goal > 100)
                {
                    MessageBox.Show("Please enter a number between 50 and 100");
                    playAgain.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n Please don't input character");
                return;
            }
            //Display goal
            lblGoal.Text = goal.ToString();
            reSetGame();
            playAgain.Visible = false;
        }
    }
}

