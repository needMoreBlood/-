using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Market : Form
    {
        private Page[] Pages { get; set; }
        private Dictionary<string, Page> Pages1 { get; set; }
        private int currentPage;
        private AdminButton adminButton;

        public Market()
        {
            InitializeComponent();
            BackColor = Color.Black;
            InitPages();
            adminButton = new AdminButton(ClientSize.Width);
            UpdatePage();
            Load += ResizeElements;
            Resize += ResizeElements;
        }

        void InitPages()
        {
            Pages = new[]
            { 
                new Page(
            new[]
                    {
                        new PicturePagePart(Properties.Resources.пилоны, GoToPageAction(1), "Пилоны"),
                        new PicturePagePart(Properties.Resources.кольца, GoToPageAction(2), "Кольца"),
                        new PicturePagePart(Properties.Resources.Полотнаа, GoToPageAction(3), "Полотона")
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
                        new PicturePagePart(Properties.Resources.пилон_на_подиуме, GoToPageAction(4), "На подиуме"),
                        new PicturePagePart(Properties.Resources.пилон_обычный, GoToPageAction(5), "Классический"),
                        new PicturePagePart(Properties.Resources.подвесной_пилон, GoToPageAction(6), "Подвесной")
                    },
                    backButton: new BackButton(GoToPageAction(0))
                    
                ),
                new Page(
            new[]
                    {
                        new PicturePagePart(Properties.Resources.кольцо_без_перекладины, GoToPageAction(7), "Без перекладины"),
                        new PicturePagePart(Properties.Resources.кольцо_с_перекладиной, GoToPageAction(8), "С перекладиной"),
                    },
                    backButton:  new BackButton(GoToPageAction(0))
                ),
                new Page(new[]
                    {
                        new PicturePagePart(Properties.Resources.полотна, GoToPageAction(9), "Полотна"),
                        new PicturePagePart(Properties.Resources.гамак, GoToPageAction(10), "Гамак"),
                    },
                    backButton: new BackButton(GoToPageAction(0))
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.пилон_на_подиуме, null, ""),
                        new OrderPagePart("Пилон на подиуме", "Пилон разборный на подиуме\n2 режима- динамика и статика\nматериал - ...\nцвет - стандартный\nподиум разборный (6 сегментов)", new string[] {"ФИО", "Телефон", "E-mail", "Адрес","Длина", "Диаметр"}), 
                    },
                backButton:  new BackButton(GoToPageAction(1))
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.пилон_обычный, null, ""),
                        new OrderPagePart("Пилон", "Описание:", new string[] {"ФИО"}),
                    },
                backButton:  new BackButton(GoToPageAction(1))
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.подвесной_пилон, null, ""),
                        new OrderPagePart("Подвесной пилон", "Описание:", new string[] {"ФИО"}),
                    },
                backButton:  new BackButton(GoToPageAction(1))
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.кольцо_без_перекладины, null, ""),
                        new OrderPagePart("Кольцо", "Описание:", new string[] {"ФИО"}),
                    },
                backButton:  new BackButton(GoToPageAction(2))
                ),
                new Page(
                new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.кольцо_с_перекладиной, null, ""),
                        new OrderPagePart("Кольцо с перекладиной", "Описание:", new string[] {"ФИО"}),
                    },
                backButton:  new BackButton(GoToPageAction(2))
                ),
                new Page(
                    new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.полотна, null, ""),
                        new OrderPagePart("Полотна", "Описание:", new string[] {"ФИО"}),
                    },
                    backButton: new BackButton(GoToPageAction(3))
                ),
                new Page(
                    new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.гамак, null, ""),
                        new OrderPagePart("Гамак", "Описание:", new string[] {"ФИО"}),
                    },
                    backButton:  new BackButton(GoToPageAction(3))
                )
            };
        }

        private void UpdatePage()
        {
            Controls.Clear();
            Controls.Add(adminButton.Button);
            if(Pages[currentPage].BackButton != null)
                Controls.Add(Pages[currentPage].BackButton.Button);
            if (Pages[currentPage].MainLabel != null)
                Controls.Add(Pages[currentPage].MainLabel);
            foreach (var pagePart in Pages[currentPage].PageParts)
                Controls.Add(pagePart.GroupBox);
            Pages[currentPage].Resize(ClientSize.Width, ClientSize.Height);
        }

        private Action<object, EventArgs> GoToPageAction(int page)
        {
            return (x, y) =>
            {
                currentPage = page;
                UpdatePage();
            };
        }

        private void ResizeElements(object sender, EventArgs e)
        {
            Pages[currentPage].Resize(ClientSize.Width, ClientSize.Height);
        }
    }
}
