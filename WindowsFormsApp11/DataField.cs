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

        public DataField(string label)
        {
            Label = new Label
            {
                Text = label,
                BackColor = Color.White,
                Font = new Font("Minion Pro", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.Gray
            };
            TextBox = new TextBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Minion Pro", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                
                
            };
        }
    }
}
