using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight=Convert.ToDouble(textBox1.Text);
            double height=Convert.ToDouble(textBox2.Text);
            double BMI = weight / (height*height);

        }

        
    }
}
