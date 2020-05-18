using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHourlyPay
{
    public partial class HourlyPay : Form
    {
        public HourlyPay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hourlyPay = Convert.ToDouble(textBox1.Text);
            double rate = 6;
            double rateA = 1.5;
            if (hourlyPay < 8)
            {
                label1.Text=Convert.ToString(hourlyPay * rate);
            }
            else if(hourlyPay<14)
            {
                label1.Text = Convert.ToString((hourlyPay-8)*rate*rateA+8*rate);
            }
            else
            {
                label1.Text = Convert.ToString((hourlyPay - 8) * rate * rateA + 8 * rate+(hourlyPay-14)*2*rate);
            }
        }
    }
}
