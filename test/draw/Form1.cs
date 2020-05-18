using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Graphics graphics = pictureBox1.CreateGraphics();
             Pen pen = new Pen(Color.Red,5);
             graphics.DrawLine(pen,100,100,50,50);*/
            draw();
        }
        private void draw()
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 5);
            graphics.DrawLine(pen, 100, 100, 50, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 5);
            graphics.DrawLine(pen, 100, 100, 50, 50);
        }

        
    }
}
