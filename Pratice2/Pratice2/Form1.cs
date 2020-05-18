using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Maximum=1000;
            trackBar2.Minimum = -10;
            trackBar2.SmallChange = 1;
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = -100;
            trackBar1.SmallChange = 1;
            try
            {
                int convert = Convert.ToInt32(1.8 * trackBar2.Value + 32);
                trackBar1.Value = convert;
            }
            catch(Exception overvalue)
            {
                MessageBox.Show("overvalue!!!!!");
            }
            c2.Text = trackBar2.Value.ToString();
            f2.Text = trackBar1.Value.ToString();
        }
    }
}
