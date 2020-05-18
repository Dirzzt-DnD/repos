using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics graph = picWine.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Red,5);
            graph.DrawRectangle(p, 0, 0,5,5);
        }

        private void trackWine_Scroll(object sender, EventArgs e)
        {
            trackWine.Maximum = Convert.ToInt32(tbxCapacity.Text);
            bMax.Text = trackWine.Maximum.ToString();
            bMid.Text = (trackWine.Maximum / 2).ToString();
            tbxWine.Text = trackWine.Value.ToString ();
            double m = trackWine.Maximum;
            double v = trackWine.Value;
            double warnning = (m - v) / m;
            if (warnning <= 0.05)
            {
                warnWord.Visible = true;
                warnWord.Text = string.Format("{0:n3}", warnning);
            }
            else
            {
                warnWord.Visible = false;
            }
        }

        private void redChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (redChecked.Checked == true)
            {
                picWine.BackColor = Color.Maroon;
            }
        }

        private void whiteChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteChecked.Checked == true)
            {
                picWine.BackColor = Color.White;
            }
        }
    }
}
