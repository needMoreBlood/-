using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public class OrderPagePart : PagePart
    {
        public Label TitleLabel { get; set; }
        public Label DiscriptionLabel { get; set; }
        public  PictureBox OkButton { get; set; }
        public DataField[] DataFields { get; set; }

        public OrderPagePart(string title, string discription, string[] fields)
        {
            GroupBox = new GroupBox();

            TitleLabel = new Label
            {
                AutoSize = true,
                Text = title,
                Font = new Font("Minion Pro", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.CadetBlue,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            DiscriptionLabel = new Label
            {
                Text = discription,
                AutoSize = true,
                Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Gray,
                BackColor = Color.White

            };
            var pictureBox = new PictureBox
            {
                Image = Properties.Resources.white,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Size = new Size(10000,10000),
                Location = new Point(-5,-5)
            };
            DataFields = new DataField[fields.Length];
            for (var i = 0;i < fields.Length; i++)
            {
                DataFields[i] = new DataField(fields[i]);

                GroupBox.Controls.Add(DataFields[i].Label);
                GroupBox.Controls.Add(DataFields[i].TextBox);
            }
            OkButton = new PictureBox
            {
                Image = Properties.Resources.success,
                Height = 40,
                Width = 40,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White
            };
            GroupBox.Controls.Add(TitleLabel);

            GroupBox.Controls.Add(DiscriptionLabel);
            GroupBox.Controls.Add(OkButton);
            GroupBox.Controls.Add(pictureBox);
        }

        public void Resize(int width, int height)
        {
            var border = 30;
            TitleLabel.Location = new Point(20,20);
            DiscriptionLabel.Location = new Point(23, 40 + TitleLabel.Height);
            DiscriptionLabel.MaximumSize = new Size( width - 43,0);

            var dataStartHeight = DiscriptionLabel.Location.Y + DiscriptionLabel.Height + 20;

            DataFields[0].Label.Location = new Point(border - 4, dataStartHeight);
            dataStartHeight += DataFields[0].Label.Height;
            DataFields[0].TextBox.Location = new Point(border, dataStartHeight);
            DataFields[0].TextBox.Width = width - 2*border;

            dataStartHeight += DataFields[0].TextBox.Height + 7;

            var textBoxWidth = width / 2 - (int)(border * 1.5);

            for (var i = 1; i < DataFields.Length; i++)
            {
               
                DataFields[i].Label.Location = new Point(border - 4 + (width/2 - border / 2) *((i-1)%2), dataStartHeight);

                DataFields[i].TextBox.Location = new Point(border + (width / 2 - border / 2) * ((i - 1) % 2), dataStartHeight + DataFields[i].Label.Height);
                if ((i - 1) % 2 == 1)
                    dataStartHeight += DataFields[i].TextBox.Height + 7 + DataFields[i].Label.Height; ;

                DataFields[i].TextBox.Width = textBoxWidth;
            }

            OkButton.Location = new Point(width/2 - 20, height - 50);
        }
    }
}
