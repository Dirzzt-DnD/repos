using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Made by WangZhen
 * Creation time:‎10/03/2020，‏‎17:03:15
 * A WinForm for input data
 */
namespace Six_of_one
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }
        public InputBox(string title,string prompt)
        {
            InitializeComponent();
            lblPrompt.Text= prompt;
            this.Text = title;
        }
        public string Inputvalue
        {
            get { return tbxInput.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
