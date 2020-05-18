using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics d = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black,5);
            d.DrawEllipse(pen, 50, 50, 200, 100);
        }
    }
}
