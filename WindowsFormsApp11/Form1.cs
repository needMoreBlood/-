using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            index++;
            Main.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ff = new Order();
            ff.Show();
    
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            index++;
            Main.SelectedIndex = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            Main.SelectedIndex = index;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            index= index+2;
            Main.SelectedIndex = index;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index - 2;
            Main.SelectedIndex = index;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            index = index + 3;
            Main.SelectedIndex = index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index - 3;
            Main.SelectedIndex = index;
        }
    }
}
