using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp11
{
    public class PicturePagePart : PagePart
    {
        public Label TitleLabel { get; set; }
        public PictureBox PictureBox { get; set; }
        public PicturePagePart(Bitmap image, Action<object, EventArgs> action, string labelText)
        {

            TitleLabel = new Label
            {
                Text = labelText,
                AutoSize = true,
                Font = new Font("Minion Pro", 21.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.CadetBlue
            };
            TitleLabel.Click += new EventHandler(action);
            PictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            PictureBox.Click += new System.EventHandler(action);
            GroupBox = new GroupBox();
            GroupBox.Controls.Add(TitleLabel);
            GroupBox.Controls.Add(PictureBox);
        }

        public void Resize(int width, int height)
        {
            var ratio = (double)PictureBox.Image.Width / PictureBox.Image.Height;
            if (ratio < (double)width / height)
            {
                PictureBox.Width = width;
                PictureBox.Height = (int)(width / ratio);
            }
            else
            {
                PictureBox.Height = height;
                PictureBox.Width = (int)(height * ratio);
            }
            PictureBox.Location = new Point((GroupBox.Width - PictureBox.Width) / 2, (GroupBox.Height - PictureBox.Height) / 2);
            //TitleLabel.Location = new Point(0, 0);
            TitleLabel.Location = new Point(width - TitleLabel.Width - 4, height - TitleLabel.Height - 6);

        }
    }
}
