using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExecrise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Graphics graPaper = pBox.CreateGraphics();
            //Create a new object of Graphics to draw picture
            graPaper.FillEllipse(Brushes.White, 50, 100, 100, 100);
            //Create snowmen face,asign colors,location and size
            graPaper.FillEllipse(Brushes.White, 75, 50, 50, 50);
            //Create snowmen body,asign colors,location and size
            graPaper.FillEllipse(Brushes.Black, 85, 65, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 105, 65, 10, 10);
            //Draw eye,asign colors,location and size
            Pen penBlack = new Pen(Color.Black, 3);
            //Create object of Pen to draw hand and mouth
            graPaper.DrawLine(penBlack, 85, 85, 115, 87);
            graPaper.DrawLine(penBlack, 75, 115, 35, 160);
            //draw snowmen's hands,asign colors,location and size
            graPaper.DrawLine(penBlack, 125, 115, 165, 160);
            //draw snowmen's mouth,asign colors,location and size
        }
    }
}
