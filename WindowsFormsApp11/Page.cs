using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public class Page
    {
        public PagePart[] PageParts { get; private set; }
        public Label MainLabel { get; private set; }
        public BackButton BackButton { get; private set; }

        public Page(PagePart[] pageParts, Label label = null, BackButton backButton = null)
        {
            PageParts = pageParts;
            MainLabel = label;
            BackButton = backButton;
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
