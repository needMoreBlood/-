using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Market : Form
    {
        private PagePart[][] pages;
        private int currentPage;

        public Market()
        {
            InitializeComponent();
            InitPages();
            this.Load += ResizeElements;
            this.Resize += ResizeElements;
            var lenght = pages[0].Length;
            //for (var i = 0; i < lenght; i++)
            //{
            //    Controls.Add(pages[0][lenght - i - 1].PictureBox);
            //}
            foreach (var pagePart in pages[0])
            {
                Controls.Add(pagePart.GroupBox);
                Controls.Add(pagePart.Label);
            }
        }

        void InitPages()
        {
            pages = new[]
            { 
                new[]
                {
                    new PagePart(Properties.Resources.пилоны, GoToPilonsPage, "Пилоны"),
                    new PagePart(Properties.Resources.кольца, GoToRingsPage, "Кольца"),
                    new PagePart(Properties.Resources.Полотнаа, GoToCanvasesPage, "Полотна")
                },
                new[]
                {
                    new PagePart(Properties.Resources.пилон_обычный, GoToPilonsPage, "Обычный"),
                    new PagePart(Properties.Resources.подвесной_пилон, GoToRingsPage, "подвисной"),
                    new PagePart(Properties.Resources.пилон_на_подиуме, GoToCanvasesPage, "На подиуме")
                },
                new[]
                {
                    new PagePart(Properties.Resources.кольцо_без_перекладины, GoToPilonsPage, "Без перекладины"),
                    new PagePart(Properties.Resources.кольцо_с_перекладиной, GoToRingsPage, "С перекладиной")
                },
                new[]
                {
                    new PagePart(Properties.Resources.полотна, GoToPilonsPage, "Полотна"),
                    new PagePart(Properties.Resources.гамак, GoToRingsPage, "Гамак")
                }
            };
        }

        private void Update()
        {
            Controls.Clear();
            foreach (var pagePart in pages[currentPage])
            {
                Controls.Add(pagePart.GroupBox);
                Controls.Add(pagePart.Label);
            }
            re();
        }

        private void ResizeElements(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            var width = control.Width / pages[currentPage].Length;
            for (var i = 0; i < pages[currentPage].Length; i++)
            {
                pages[currentPage][i].GroupBox.Width = width;
                pages[currentPage][i].GroupBox.Height = control.Height;
                pages[currentPage][i].GroupBox.Location = new Point(width*i,0);
                ResizeElements(pages[currentPage][i].PictureBox,width / 2,control.Height/2,width,control.Height);
            }
        }

        private void re()
        {
            var control = this;
            var width = control.Width / pages[currentPage].Length;
            for (var i = 0; i < pages[currentPage].Length; i++)
            {
                pages[currentPage][i].GroupBox.Width = width;
                pages[currentPage][i].GroupBox.Height = control.Height;
                pages[currentPage][i].GroupBox.Location = new Point(width * i, 0);
                ResizeElements(pages[currentPage][i].PictureBox, width / 2, control.Height / 2, width, control.Height);
            }
        }

        private void ResizeElements(PictureBox pictureBox, int centreX, int centreY, int width, int height)
        {
            var ratio = (double) pictureBox.Image.Width / pictureBox.Image.Height;
            if (ratio < (double)width / height)
            {
                pictureBox.Width = width;
                pictureBox.Height = (int)(width / ratio);
            }
            else
            {
                pictureBox.Height = height;
                pictureBox.Width = (int) (height * ratio);
            }
            pictureBox.Location = new Point(centreX - pictureBox.Width/2,centreY - pictureBox.Height/2);
        }

        private void GoToMainPage(object sender, EventArgs e)
        {
            currentPage = 0;
            Update();
        }

        private void GoToPilonsPage(object sender, EventArgs e)
        {
            currentPage = 1;
            Update();
        }

        private void GoToRingsPage(object sender, EventArgs e)
        {
            currentPage = 2;
            Update();
        }

        private void GoToCanvasesPage(object sender, EventArgs e)
        {
            currentPage = 3;
            Update();
        }
    }
}
