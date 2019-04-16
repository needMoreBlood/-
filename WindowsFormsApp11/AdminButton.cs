using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public class AdminButton
    {
        public PictureBox Button { get; private set; }

        public AdminButton(int windowWith)
        {
            Button = new PictureBox
            {
                Image = Properties.Resources.settings,
                BackColor = Color.White,
                Height = 35,
                Width = 35,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(windowWith - 48, 13),
                Anchor = AnchorStyles.Right | AnchorStyles.Top
            };
            Button.Click += (x, y) =>
            {
                var adminForm = new Login();
                adminForm.ShowDialog();
            };
        }
    }
}
