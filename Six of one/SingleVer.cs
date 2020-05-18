using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Made by WangZhen
 * Creation time:22/03/2020,‏‎17:44:12
 * Single player version of SixOfOne
 */
namespace Six_of_one
{
    public partial class SingleVer : Form
    {
        public SingleVer()
        {
            InitializeComponent();
            picBoxes = new PictureBox[] { picbx1, picbx2, picbx3, picbx4, picbx5, picbx6 };
        }
        //Player1 dice
        int[] dice;
        //Player1 name and player2 name
        string player1;
        string systemName="System";
        //Turn number
        int turn = 1;
        //Record player1 and player2 score
        int scorePlayer1;
        int scoreSystem;
        //Goal variable
        int goal;
        //picturebox index
        int n = 0;
        //Players win turns
        int player1Winturn = 0;
        int systemWinturn = 0;
        //Decide whatther run next turn
        Boolean over = true;
        //Store PictureBox
        PictureBox[] picBoxes;

        private void Roll1_Click(object sender, EventArgs e)
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
            }catch(Exception ex)
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
            //display animation
            DiceAnimation animationDice = new DiceAnimation();
            animationDice.Ainmation(picBoxes, diceQuantity, dice);
            //Reset index of picturebox
            n = 0;
            //Display game result
            tbxOutput.AppendText(player1 + "'s dice values are");
            ruleGame(player1, systemName, dice, ref scorePlayer1, lblplayer1Score, ref player1Winturn, ref systemWinturn, lblplayer1Winturn, lblsystemWinturn);
            //Reset index
            n = 0;
            //Record turn
            turn++;
            if (over == true)
            {
                //Change order
                rdSystem.Checked = true;
            }

        }
        //Player1name mean that player who are playing. Player2Name mean that player who are waiting for next turn.
        //winTurn1, winTurn2,lblone and lblTwo are same reason.
        //ref for change value in scorePlayer1 or scorePlayer2
        private void systemPlayer()
        {
            
            //Delay time of showing picture
            System.Threading.Thread.Sleep(5000);
            //Clear picture in picture box
            clear();
            //Random dice value
            Random num2 = new Random();
            Random quantity = new Random();
            int diceQuantity = 0;
            //Decide dice quantity by value of goal
            if (goal > 75)
            {
                //Decide dice quantity by system score
                if (scoreSystem == 0)
                {
                    diceQuantity = 6;
                    dice = new int[diceQuantity];
                }
                else if (scoreSystem > (goal - 10))
                {
                    diceQuantity = 1;
                    dice = new int[diceQuantity];
                }
                else if (scoreSystem > (goal / 2))
                {
                    diceQuantity = 4;
                    dice = new int[diceQuantity];
                }
                else
                {
                    diceQuantity = quantity.Next(4, 6);
                    dice = new int[diceQuantity];
                }
            }else if (goal < 75)
            {
                //Decide dice quantity by system score
                if (scoreSystem == 0)
                {
                    diceQuantity = 4;
                    dice = new int[diceQuantity];
                }
                else if (scoreSystem > (goal - 10))
                {
                    diceQuantity = 1;
                    dice = new int[diceQuantity];
                }
                else
                {
                    diceQuantity = quantity.Next(4, 6);
                    dice = new int[diceQuantity];
                }
            }
            //Display turn
            tbxOutput.AppendText("Turn " + turn.ToString() + "\r\n");
            lblsystemDice.Text = diceQuantity.ToString();
            //Application.DoEvents();
            tbxOutput.AppendText("System running.....\r\n");
            //Slow down to prevent display too fast
            System.Threading.Thread.Sleep(3000);
            //Declear each element in array
            for (int x = 0; x < dice.Length; x++)
            {
                dice[x] = num2.Next(1,7);
            }
            //Updata information
            Application.DoEvents();
            //Display animation
            DiceAnimation animationDice = new DiceAnimation();
            animationDice.Ainmation(picBoxes, diceQuantity, dice);
            //Display game result
            tbxOutput.AppendText(systemName + " throws " + diceQuantity + " dice(s)\r\n");
            //Slow down to prevent display too fast
            System.Threading.Thread.Sleep(1000);
            tbxOutput.AppendText(systemName + "'s dice values are");
            //Slow down to prevent display too fast
            System.Threading.Thread.Sleep(1000);
            //Run function to decide result
            ruleGame(systemName, player1,dice, ref scoreSystem, lblsystemScore, ref systemWinturn, ref player1Winturn, lblsystemWinturn, lblplayer1Winturn);
            //Reset index
            n = 0;
            //Record turn
            turn++;
            if (over == true)
            {
                //Change order
                rdPlayer1.Checked = true;
            }
        }
        private void ruleGame(string player1Name, string player2Name, int[] dice, ref int scorePlayer, Label lblscore, ref int winTurn1, ref int winTurn2, Label lblone, Label lblTwo)
        {
            //Count how many 1 in value
            int playerOne = 0;
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
                scoreSystem = 0;
                //Display score
                lblplayer1Score.Text = "0";
                lblsystemScore.Text = "0";
                //Display win turn
                winTurn2++;
                lblTwo.Text = winTurn2.ToString();
                //Display play again!
                playAgain.Visible = true;
                //Invisiable button
                Roll1.Visible = false;
                //Stop game
                over = false;
            }
            else if (playerOne >= 4)
            {
                tbxOutput.AppendText("Bboojum! " + player1Name + " win! " + player2Name + " lose.\r\n");
                //Once a player win the turn. Both player score will be clear
                scorePlayer = 0;
                scorePlayer1 = 0;
                scoreSystem = 0;
                //Display score
                lblplayer1Score.Text = "0";
                lblsystemScore.Text = "0";
                //Display win turn
                winTurn1++;
                lblone.Text = winTurn1.ToString();
                //Display play again!
                playAgain.Visible = true;
                //Invisiable button
                Roll1.Visible = false;
                //Stop game
                over = false;
            }
            else if (scorePlayer >= goal)
            {
                tbxOutput.AppendText(player1Name + " win!" + " Score is " + scorePlayer.ToString() + "\r\n");
                //Once a player win the turn. Both player score will be clear
                scorePlayer = 0;
                scorePlayer1 = 0;
                scoreSystem = 0;
                //Display win turn
                winTurn1++;
                lblone.Text = winTurn1.ToString();
                lblplayer1Score.Text = "0";
                lblsystemScore.Text = "0";
                //Display play again!
                playAgain.Visible = true;
                //Invisiable button
                Roll1.Visible = false;
                //Stop game
                over = false;
            }
            else
            {
                //If don't have any 1 in array, scorePlayer add sum of array by a variable
                tbxOutput.AppendText(player1Name + " score is " + scorePlayer + "\r\n");
                lblscore.Text = scorePlayer.ToString();
            }
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            //Show a Winform to input player name
            InputBox input1 = new InputBox("Name", "Input player1's name");
            input1.ShowDialog();
            //Prevent player don't input name
            if (input1.Inputvalue.Equals(""))
            {
                MessageBox.Show("Please enter a name, input again");
                return;
            }
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message +"\r\n Please don't input character");
                return;
            }
            //Display goal
            lblGoal.Text = goal.ToString();
            //Store value in player1
            //Show name by label
            player1 = input1.Inputvalue;
            lblPlayer1name.Text = input1.Inputvalue;
            player1Winturn = 0;
            systemWinturn = 0;
            lblplayer1Winturn.Text = "0";
            lblsystemWinturn.Text = "0";
            //ResetGame
            reSetGame();
        }
        private void reSetGame()
        {
            //Reset over
            over = true;
            //Clear picturebox
            clear();
            //Reset radio button
            rdPlayer1.Checked = false;
            rdSystem.Checked = false;
            //Random a number to decide order
            Random order = new Random();
            int x = order.Next(0, 101);
            //Clear turn
            turn = 1;
            //Clear output
            tbxOutput.Text = "";
            //Clear label of quantity of dice
            lblsystemDice.Text = "";
            //Even number is Player1 first
            if (x % 2 == 0)
            {
                rdPlayer1.Checked = true;
                tbxOutput.AppendText(player1 + " First!\r\n");
            }
            else
            //Odd number is Player2 first
            {
                tbxOutput.AppendText(systemName + " First!\r\n");
                rdSystem.Checked = true;
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
      
        private void rdPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            
            //Change player order
            if (rdPlayer1.Checked)
            {
                Roll1.Visible = true;
            }
        }
        private void rdSystem_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdSystem.Checked) 
            {
                Roll1.Visible = false;
                //For prevent task stop
                Application.DoEvents();
                //Slow down to prevent display too fast
                System.Threading.Thread.Sleep(3000);
                systemPlayer();
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
            playAgain.Visible = false;
            reSetGame();
            
        }
    }
}
