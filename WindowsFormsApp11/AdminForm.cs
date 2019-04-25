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
    public partial class AdminForm : Form
    {
        public AdminForm(Data data)
        {
            InitializeComponent();
            foreach (var order in data.Orders)
            {
                listBox1.Items.Add(order);
            }
        }
    }
}
