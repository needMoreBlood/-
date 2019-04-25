using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public class DataField
    {
        public Label Label { get; private set; }
        public TextBox TextBox { get; private set; }
        public string Data => TextBox.Text;

        public DataField(string label)
        {
            Label = new Label
            {
                Text = label,
                BackColor = Color.White,
                Font = new Font("Minion Pro", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.CadetBlue
            };
            TextBox = new TextBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.FromArgb(100, 100, 100),

            };
        }
    }
}
