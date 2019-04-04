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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex != 0 || 
            //    comboBox1.SelectedIndex != 1 || 
            //    comboBox1.SelectedIndex != 2)
            
            //    {
            //        comboBox2.Enabled = true;
            //        //textbox3.enabled = true;
            //    }
            //    else
            //    {
            //    comboBox2.Enabled = false;
            //}
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 ||
                comboBox1.SelectedIndex != 1 ||
                comboBox1.SelectedIndex != 2)

            {
                comboBox2.Enabled = true;
                //textbox3.enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }
    }
}
