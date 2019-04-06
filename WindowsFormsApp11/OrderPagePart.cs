using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public class OrderPagePart : PagePart
    {
        public Label TitleLabel { get; set; }
        public Label DiscriptionLabel { get; set; }
        public  PictureBox OkButton { get; set; }
        public PictureBox CancelButton { get; set; }
        public Label[] DataLabels { get; set; }
        public TextBox[] DataTextBoxs { get; set; }
        public Dictionary<string, TextBox> DataBoxs { get; private set; } = new Dictionary<string, TextBox>();

        public OrderPagePart(string title, string discription, string[] fields)
        {
            GroupBox = new GroupBox
            {
                BackColor = Color.White
                
            };
            TitleLabel = new Label
            {
                AutoSize = true,
                Text = title,
                Font = new Font("Minion Pro", 21.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.CadetBlue
            };
            GroupBox.Controls.Add(TitleLabel);
            DiscriptionLabel = new Label
            {
                Text = discription,
                Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Black
            };
            GroupBox.Controls.Add(DiscriptionLabel);
            DataLabels = new Label[fields.Length];
            DataTextBoxs = new TextBox[fields.Length];
            for (var i =0;i< fields.Length; i++)
            {
                DataLabels[i] = new Label
                {
                    Text = fields[i]
                };
                DataTextBoxs[i] = new TextBox();

                GroupBox.Controls.Add(DataLabels[i]);
                GroupBox.Controls.Add(DataTextBoxs[i]);
            }

            OkButton = new PictureBox
            {
                Image = Properties.Resources.success,
                BackColor = Color.Transparent,
                Height = 40,
                Width = 40,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            GroupBox.Controls.Add(OkButton);
        }

        public void Resize(int width, int height)
        {
            GroupBox.Width = width - 5;
            GroupBox.Height = height - 1;
            TitleLabel.Location = new Point(10,10);
            DiscriptionLabel.Location = new Point(10, 30 + TitleLabel.Height);
            DiscriptionLabel.Width = width - 20;

            OkButton.Location = new Point(width/2 - 20, height - 50);
            //OkButton.Location = new Point(0,0);

        }
    }
}
