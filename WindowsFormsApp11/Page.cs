using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public class Page
    {
        public PagePart[] PageParts { get; set; }
        public Label MainLabel { get; set; }
        public PictureBox BackButton { get; set; }

        public Page(PagePart[] pageParts, Label label = null, PictureBox backButton = null, Action<object, EventArgs> action = null)
        {
            PageParts = pageParts;
            MainLabel = label;
            if (backButton != null)
            {
                BackButton = backButton;
                BackButton.Click += new EventHandler(action);
            }
        }

        public void Resize(int width, int height)
        {
            var size = width / PageParts.Length;
            for(var i = 0; i < PageParts.Length; i++)
            {
                var part = PageParts[i]; 
                part.GroupBox.Location = new Point(size*i,0);
                part.GroupBox.Width = size;
                part.GroupBox.Height = height;
                if (part is PicturePagePart)
                {
                    var picturePart = (PicturePagePart) part;
                    picturePart.Resize(size,height);
                }
                if(part is OrderPagePart)
                {
                    var orderPart = (OrderPagePart)part;
                    orderPart.Resize(size, height);
                }
            }
        }
    }
    
}
