using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window
{
    public partial class draft1 : Form
    {
        public draft1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[5];
            num[0] = 1;
            num[1] = 2;
            num[2] = 3;
            num[3] = 4;
            num[4] = 5;
            for(int x = 0; x < num.Length; x++)
            {
                textBox1.AppendText(num[x].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
