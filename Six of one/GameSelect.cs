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
 * Creation time:22/03/2020，‏‎22:47:01
 * A WinForm for selecting different version of SixOfOne game
 */
namespace Six_of_one
{
    public partial class GameSelect : Form
    {
        public GameSelect()
        {
            InitializeComponent();
        }

        private void singlePlayer_Click(object sender, EventArgs e)
        {
            SingleVer singlePlayer = new SingleVer();
            //Display single player version 
            singlePlayer.ShowDialog();
        }

        private void twoPlayer_Click(object sender, EventArgs e)
        {
            //Display double player version 
            SixOfOne doubleGame = new SixOfOne();
            doubleGame.ShowDialog();
        }
    }
}
