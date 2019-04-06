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
        private Page[] Pages { get; set; }
        private int currentPage;

        public Market()
        {
            InitializeComponent();
            InitPages();
            UpdatePage();
            this.Load += ResizeElements;
            this.Resize += ResizeElements;
        }

        void InitPages()
        {
            Pages = new[]
            { 
                new Page(
                    new[]
                    {
                        new PicturePagePart(Properties.Resources.пилоны, GoToPolesPage, "Пилоны"),
                        new PicturePagePart(Properties.Resources.кольца, GoToRingsPage, "Кольца"),
                        new PicturePagePart(Properties.Resources.Полотнаа, GoToCanvasesPage, "Полотона")
                    },
                    new Label
                    {
                        AutoSize = true,
                        BackColor = System.Drawing.Color.White,
                        Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                        ForeColor = System.Drawing.Color.CadetBlue,
                        Location = new Point(10,10)
                        
                    }
                ),
                new Page(
            new[]
                    {
                        new PicturePagePart(Properties.Resources.пилон_на_подиуме, GoToOrderTablePolePage, "На подиуме"),
                        new PicturePagePart(Properties.Resources.пилон_обычный, GoToOrderPolePage, "Классический"),
                        new PicturePagePart(Properties.Resources.подвесной_пилон, GoToOrderChinesePolePage, "Подвесной")
                    },
                    backButton: new PictureBox
                    {
                        Image = Properties.Resources.back,
                        BackColor = Color.White,
                        Height = 30,
                        Width = 30,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(10,10)
                    },
                    action: GoToMainPage
                    
                ),
                new Page(
            new[]
                    {
                        new PicturePagePart(Properties.Resources.кольцо_без_перекладины, GoToOrderRingPage, "Без перекладины"),
                        new PicturePagePart(Properties.Resources.кольцо_с_перекладиной, GoToOrderRingWithPage, "С перекладиной"),
                    },
            backButton: new PictureBox
            {
                Image = Properties.Resources.back,
                BackColor = Color.White,
                Height = 30,
                Width = 30,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(10,10)
            },
            action: GoToMainPage
                ),
                new Page(new[]
                    {
                        new PicturePagePart(Properties.Resources.полотна, GoToOrderCanvasesPage, "Полотна"),
                        new PicturePagePart(Properties.Resources.гамак, GoToOrderHammockPage, "Гамак"),
                    },
                    backButton: new PictureBox
                    {
                        Image = Properties.Resources.back,
                        BackColor = Color.White,
                        Height = 30,
                        Width = 30,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(10,10)
                    },
                    action: GoToMainPage
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.пилон_на_подиуме, GoToPolesPage, ""),
                        new OrderPagePart("Пилон на подиуме", "Описание:", new string[0]), 
                    },
                backButton: new PictureBox
                {
                    Image = Properties.Resources.back,
                    BackColor = Color.White,
                    Height = 30,
                    Width = 30,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10,10)
                },
                action: GoToPolesPage
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.пилон_обычный, GoToPolesPage, ""),
                        new OrderPagePart("Пилон", "Описание:", new string[0]),
                    },
                backButton: new PictureBox
                {
                    Image = Properties.Resources.back,
                    BackColor = Color.White,
                    Height = 30,
                    Width = 30,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10,10)
                },
                action: GoToPolesPage
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.подвесной_пилон, GoToPolesPage, ""),
                        new OrderPagePart("Подвесной пилон", "Описание:", new string[0]),
                    },
                backButton: new PictureBox
                {
                    Image = Properties.Resources.back,
                    BackColor = Color.White,
                    Height = 30,
                    Width = 30,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10,10)
                },
                action: GoToPolesPage
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.кольцо_без_перекладины, GoToPolesPage, ""),
                        new OrderPagePart("Кольцо", "Описание:", new string[0]),
                    },
                backButton: new PictureBox
                {
                    Image = Properties.Resources.back,
                    BackColor = Color.White,
                    Height = 30,
                    Width = 30,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10,10)
                },
                action: GoToRingsPage
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.кольцо_с_перекладиной, GoToPolesPage, ""),
                        new OrderPagePart("Кольцо с перекладиной", "Описание:", new string[0]),
                    },
                backButton: new PictureBox
                {
                    Image = Properties.Resources.back,
                    BackColor = Color.White,
                    Height = 30,
                    Width = 30,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10,10)
                },
                action: GoToRingsPage
                ),
                new Page(
                    new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.полотна, GoToPolesPage, ""),
                        new OrderPagePart("Полотна", "Описание:", new string[0]),
                    },
                    backButton: new PictureBox
                    {
                        Image = Properties.Resources.back,
                        BackColor = Color.White,
                        Height = 30,
                        Width = 30,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(10,10)
                    },
                    action: GoToCanvasesPage
                ),
                new Page(
                    new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.гамак, GoToPolesPage, ""),
                        new OrderPagePart("Гамак", "Описание:", new string[0]),
                    },
                    backButton: new PictureBox
                    {
                        Image = Properties.Resources.back,
                        BackColor = Color.White,
                        Height = 30,
                        Width = 30,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(10,10)
                    },
                    action: GoToCanvasesPage
                )
            };
        }

        private void UpdatePage()
        {
            Controls.Clear();
            if(Pages[currentPage].BackButton != null)
                Controls.Add(Pages[currentPage].BackButton);
            if (Pages[currentPage].MainLabel != null)
                Controls.Add(Pages[currentPage].MainLabel);
            foreach (var pagePart in Pages[currentPage].PageParts)
            {
                Controls.Add(pagePart.GroupBox);
            }
            Pages[currentPage].Resize(Width - 13, Height - 38);
        }

        private void ResizeElements(object sender, EventArgs e)
        {
            Pages[currentPage].Resize(Width - 13 , Height - 38);
        }

        private void GoToMainPage(object sender, EventArgs e)
        {
            currentPage = 0;
            UpdatePage();
        }

        private void GoToPolesPage(object sender, EventArgs e)
        {
            currentPage = 1;
            UpdatePage();
        }

        private void GoToRingsPage(object sender, EventArgs e)
        {
            currentPage = 2;
            UpdatePage();
        }

        private void GoToCanvasesPage(object sender, EventArgs e)
        {
            currentPage = 3;
            UpdatePage();
        }

        private void GoToOrderTablePolePage(object sender, EventArgs e)
        {
            currentPage = 4;
            UpdatePage();
        }
        private void GoToOrderPolePage(object sender, EventArgs e)
        {
            currentPage = 5;
            UpdatePage();
        }
        private void GoToOrderChinesePolePage(object sender, EventArgs e)
        {
            currentPage = 6;
            UpdatePage();
        }

        private void GoToOrderRingPage(object sender, EventArgs e)
        {
            currentPage = 7;
            UpdatePage();
        }

        private void GoToOrderRingWithPage(object sender, EventArgs e)
        {
            currentPage = 8;
            UpdatePage();
        }

        private void GoToOrderCanvasesPage(object sender, EventArgs e)
        {
            currentPage = 9;
            UpdatePage();
        }

        private void GoToOrderHammockPage(object sender, EventArgs e)
        {
            currentPage = 10;
            UpdatePage();
        }

    }
}
