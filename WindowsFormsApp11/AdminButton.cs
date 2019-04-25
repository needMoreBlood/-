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

        public AdminButton(Data data, int windowWith)
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
                Data.LogData("Открыто окно администратора.");
                var adminForm = new Login(data);
                adminForm.ShowDialog();
            };
        }
    }
}
