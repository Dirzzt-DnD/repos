using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDraw
{
    public partial class DemoDraw : Form
    {
        public DemoDraw()
        {
            InitializeComponent();
        }

        private void changed(object sender, EventArgs e)
        {
            Graphics graPaper = pbxDrawing.CreateGraphics();
            Pen pBlack = new Pen(Color.Black, 5);
            graPaper.DrawRectangle(pBlack, 100, 50, 200, 200);
            graPaper.DrawLine(pBlack, 100, 50, 300, 250);
            graPaper.DrawEllipse(pBlack, 100, 50, 200, 200);
        }
    }
}
