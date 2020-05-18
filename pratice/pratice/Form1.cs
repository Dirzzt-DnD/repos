using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int answer = r.Next(1, 10);
            int guess = Convert.ToInt32(textBox1.Text);
            if (guess < answer)
            {
                label1.Text = "low";
            }
            else if (answer > guess)
            {
                label1.Text = "high";
            }
            else
            {
                label1.Text = "correct";
            }
        }
    }
}
