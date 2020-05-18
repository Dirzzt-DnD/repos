using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void justBotton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(tbxNum1.Text);
            int num2 = Convert.ToInt32(tbxNum2.Text);
            double result = num1 * num2;
            outputBox.Text="Result = "+result;
        }

    }
}
