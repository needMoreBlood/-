using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp11
{
    public class PagePart
    {
        public PictureBox PictureBox{ get; private set; }
        public Label Label { get; private set; }
        public GroupBox GroupBox { get; private set; }

        public PagePart(Bitmap image, Action<object, EventArgs> action, string labelText)
        {
            PictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Label = new Label
            {
                Text = labelText
            };
            PictureBox.Click += new System.EventHandler(action);
            GroupBox = new GroupBox();
            GroupBox.Controls.Add(PictureBox);
        }
    }
}
