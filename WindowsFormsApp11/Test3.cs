using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Test3 : Form
    {
        public Test3()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            var size = control.Size.Width / 3;

            pictureBox1.Location = new Point(- 5, 0);
            pictureBox1.Width = size;
            pictureBox1.Height = control.Size.Height;

            pictureBox3.Location = new Point(size*2 - 5,0);
            pictureBox3.Width = size;
            pictureBox3.Height = control.Size.Height;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
