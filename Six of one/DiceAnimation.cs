using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

/*
 * Made by WangZhen
 * Creation time:16/03/2020，‏‎15:51:14
 * AnimationDice Class is for displayong dice value picture and playing dice animation
 */



namespace Six_of_one
{
    class DiceAnimation
    {
        //=============================================
        // Reference A1: externally sourced code
        // Purpose: change Animation to run better
        // Date:  26/03/2020
        // Source: My teacher Tan Han Kee
        // Author: Sergey Berezovskiy
        //=============================================
        public void Ainmation(PictureBox[] animationDice,int length,int[]diceValue)
        {
            //Roll number for display different picture
            Random picRandom = new Random();
            //For store different value
            int[] valueRandom = new int[6];
            //Control times of animation 
            for (int y = 0; y < 10; y++)
            {
                  for(int x = 0; x < length; x++)
                {
                    int pic = picRandom.Next(1, 7);
                    valueRandom[x] = pic;
                    DetectValue(animationDice[x], valueRandom[x]);
                    System.Threading.Thread.Sleep(100);
                }
            }
            //=============================================
            // End reference A1

            //Match correct dice value to dice value picture
            for (int z = 0; z < length; z++)
            {
                DetectValue(animationDice[z], diceValue[z]);
            }
        }
        //The picture of dice value is 1
        private void Value1Dice(PictureBox picbxDice)
        {
            Graphics diceValue1 = picbxDice.CreateGraphics();
            diceValue1.Clear(Control.DefaultBackColor);
            Pen p = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Black);
            diceValue1.DrawRectangle(p, 0, 0, 50, 50);
            diceValue1.FillEllipse(brush, 20, 20, 10, 10);
        }
        //The picture of dice value is 2
        private void Value2Dice(PictureBox picbxDice)
        {
            Graphics diceValue2 = picbxDice.CreateGraphics();
            diceValue2.Clear(Control.DefaultBackColor);
            Pen p = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Black);
            diceValue2.DrawRectangle(p, 0, 0, 50, 50);
            diceValue2.FillEllipse(brush, 5, 5, 10, 10);
            diceValue2.FillEllipse(brush, 35, 35, 10, 10);
        }
        //The picture of dice value is 3
        private void Value3Dice(PictureBox picbxDice)
        {
            Graphics diceValue3 = picbxDice.CreateGraphics();
            diceValue3.Clear(Control.DefaultBackColor);
            Pen p = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Black);
            diceValue3.DrawRectangle(p, 0, 0, 50, 50);
            diceValue3.FillEllipse(brush, 20, 20, 10, 10);
            diceValue3.FillEllipse(brush, 5, 5, 10, 10);
            diceValue3.FillEllipse(brush, 35, 35, 10, 10);
        }
        //The picture of dice value is 4
        private void Value4Dice(PictureBox picbxDice)
        {
            Graphics diceValue4 = picbxDice.CreateGraphics();
            diceValue4.Clear(Control.DefaultBackColor);
            Pen p = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Black);
            diceValue4.DrawRectangle(p, 0, 0, 50, 50);
            diceValue4.FillEllipse(brush, 5, 5, 10, 10);
            diceValue4.FillEllipse(brush, 35, 5, 10, 10);
            diceValue4.FillEllipse(brush, 35, 35, 10, 10);
            diceValue4.FillEllipse(brush, 5, 35, 10, 10);
        }
        //The picture of dice value is 5
        private void Value5Dice(PictureBox picbxDice)
        {
            Graphics diceValue5 = picbxDice.CreateGraphics();
            diceValue5.Clear(Control.DefaultBackColor);
            Pen p = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Black);
            diceValue5.DrawRectangle(p, 0, 0, 50, 50);
            diceValue5.FillEllipse(brush, 20, 20, 10, 10);
            diceValue5.FillEllipse(brush, 5, 5, 10, 10);
            diceValue5.FillEllipse(brush, 35, 5, 10, 10);
            diceValue5.FillEllipse(brush, 35, 35, 10, 10);
            diceValue5.FillEllipse(brush, 5, 35, 10, 10);
        }
        //The picture of dice value is 6
        private void Value6Dice(PictureBox picbxDice)
        {
            Graphics diceValue6 = picbxDice.CreateGraphics();
            diceValue6.Clear(Control.DefaultBackColor);
            Pen p = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Black);
            diceValue6.DrawRectangle(p, 0, 0, 50, 50);
            diceValue6.DrawRectangle(p, 0, 0, 50, 50);
            diceValue6.FillEllipse(brush, 5, 5, 10, 10);
            diceValue6.FillEllipse(brush, 35, 5, 10, 10);
            diceValue6.FillEllipse(brush, 35, 35, 10, 10);
            diceValue6.FillEllipse(brush, 5, 35, 10, 10);
            diceValue6.FillEllipse(brush, 20, 35, 10, 10);
            diceValue6.FillEllipse(brush, 20, 5, 10, 10);
        }
        //Detect dice value to match dice value picture
        private void DetectValue(PictureBox picbxDice,int detect)
        {
                if (detect == 1)
                {
                Value1Dice(picbxDice);
                }
                else if (detect == 2)
                {
                   Value2Dice(picbxDice);
                }
                else if (detect == 3)
                {
                    Value3Dice(picbxDice);
                }
                else if (detect == 4)
                {
                    Value4Dice(picbxDice);
                }
                else if (detect == 5)
                {
                    Value5Dice(picbxDice);
                }
                else if (detect == 6)
                {
                    Value6Dice(picbxDice);
                }
            }

    }
   
}