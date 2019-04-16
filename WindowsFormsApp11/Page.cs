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
            var borderSize = 1;
            width -= borderSize;
            var size = width / PageParts.Length;
            for(var i = 0; i < PageParts.Length - 1; i++)
            {
                var part = PageParts[i]; 
                part.GroupBox.Location = new Point((size)*i + borderSize, borderSize);
                part.GroupBox.Width = size - borderSize;
                part.GroupBox.Height = height - 2* borderSize;
                switch (part)
                {
                    case PicturePagePart picturePart:
                        picturePart.Resize(picturePart.GroupBox.Width, picturePart.GroupBox.Height);
                        break;
                    case OrderPagePart orderPart:
                        orderPart.Resize(orderPart.GroupBox.Width, orderPart.GroupBox.Height);
                        break;
                }
            }
            var lastPart = PageParts[PageParts.Length - 1];
            lastPart.GroupBox.Location = new Point(size * (PageParts.Length - 1) + borderSize, borderSize);
            lastPart.GroupBox.Width = width - size * (PageParts.Length - 1) - borderSize;
            lastPart.GroupBox.Height = height - 2 * borderSize;
            switch (lastPart)
            {
                case PicturePagePart picturePart1:
                    picturePart1.Resize(picturePart1.GroupBox.Width, picturePart1.GroupBox.Height);
                    break;
                case OrderPagePart orderPart1:
                    orderPart1.Resize(orderPart1.GroupBox.Width, orderPart1.GroupBox.Height);
                    break;
            }
        }
    }
    
}
