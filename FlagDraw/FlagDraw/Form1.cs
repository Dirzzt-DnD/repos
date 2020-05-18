using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void FlagD(int x, int y, int z)
        {
            Graphics drawFlag = pictureBox1.CreateGraphics();
            drawFlag.FillRectangle(Brushes.Black, x, y, z,z/3);
            drawFlag.FillRectangle(Brushes.Red, x, y + z / 3, z, z / 3);
            drawFlag.FillEllipse(Brushes.Yellow, x + z / 3, y + z / 6, z / 3, z / 3);
        }
        private void drawFlag_Click(object sender, EventArgs e)
        {
            FlagD(50,50, 200);

        }
    }
}
