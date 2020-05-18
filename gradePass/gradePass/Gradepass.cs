using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradePass
{
    public partial class Gradepass : Form
    {
        public Gradepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grade = Convert.ToDouble(textBox1.Text);
            if (grade < 50)
            {
                label1.Text="Fall";
            }
            else
            {
                label1.Text = "Pass";
            }
        }
    }
}
