using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    class RegistrationPagePart : PagePart
    {
        public Label TitleLabel { get; set; }
        public PictureBox OkButton { get; set; }
        public DataField[] DataFields { get; set; }

        private readonly string[] standartFields = { "ФИО", "Адресс", "Телефон", "E-mail" };

        public RegistrationPagePart(Data data)
        {
            GroupBox = new GroupBox();

            TitleLabel = new Label
            {
                AutoSize = true,
                Text = "Регистрация",
                Font = new Font("Minion Pro", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.CadetBlue,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            var pictureBox = new PictureBox
            {
                Image = Properties.Resources.white,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Size = new Size(10000, 10000),
                Location = new Point(-5, -5)
            };

            DataFields = new DataField[4];

            for (var i = 0; i < standartFields.Length; i++)
            {
                DataFields[i] = new DataField(standartFields[i]);
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

            OkButton.Click += (sender, args) =>
            {
                if (Check())
                {
                    var user = new User(DataFields[0].TextBox.Text,
                        DataFields[1].TextBox.Text,
                        DataFields[2].TextBox.Text,
                        DataFields[3].TextBox.Text);
                    data.AddUser(user);
                    var succ = new SuccesForm("Регистрация прошла успешно.");
                    succ.ShowDialog();
                    //TODO Окно успеха
                    foreach (var dataField in DataFields)
                    {
                        dataField.TextBox.Text = "";
                    }
                    Data.LogData("Регистрация: " + user);
                }
                var error = new SuccesForm("Не все поля запонены.");
                error.ShowDialog();
                //TODO Окно неудачи.
            };
            GroupBox.Controls.Add(TitleLabel);
            
            GroupBox.Controls.Add(OkButton);
            GroupBox.Controls.Add(pictureBox);
        }

        private bool Check()
        {
            foreach (var dataField in DataFields)
            {
                if (dataField.TextBox.Text.Length == 0)
                    return false;
            }
            return true;
        }

        public void Resize(int width, int height)
        {
            var border = 30;

            TitleLabel.Location = new Point(50, 20);

            var dataStartHeight = 40 + TitleLabel.Height;

            for (var i = 0; i < 2; i++)
            {
                DataFields[i].Label.Location = new Point(border - 4, dataStartHeight);
                dataStartHeight += DataFields[i].Label.Height;

                DataFields[i].TextBox.Location = new Point(border, dataStartHeight);
                DataFields[i].TextBox.Width = width - 2 * border;
                dataStartHeight += DataFields[0].TextBox.Height + 7;
            }

            var textBoxWidth = width / 2 - (int)(border * 1.5);

            for (var i = 2; i < DataFields.Length; i++)
            {
                DataFields[i].Label.Location =
                    new Point(border - 4 + (width / 2 - border / 2) * (i % 2), dataStartHeight);
                DataFields[i].TextBox.Location = new Point(border + (width / 2 - border / 2) * (i % 2),
                    dataStartHeight + DataFields[i].Label.Height);
                if (i % 2 == 1)
                    dataStartHeight += DataFields[i].TextBox.Height + 7 + DataFields[i].Label.Height;
                DataFields[i].TextBox.Width = textBoxWidth;
            }

            OkButton.Location = new Point(width / 2 - 20, height - 50);
        }

    }
}