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
    public partial class SuccesForm : Form
    {
        public SuccesForm(string text)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Massage.Text = text;
            AcceptButton.Click += (x, y) => Close();
            Massage.Location = new Point(Width/2 - Massage.Width/2, 70);
        }
    }
}
