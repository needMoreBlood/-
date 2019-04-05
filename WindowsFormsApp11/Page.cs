using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public class Page
    {
        public PagePart[] pageParts { get; set; }
        public Action<object, EventArgs> BackAction { get; set; }
        public Label MainLabel { get; set; }
    }
}
