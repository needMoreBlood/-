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
        private Page MainPage { get; set; }
        private Page PilonsPage { get; set; }
        private Page SilksPage { get; set; }
        private Page RingsPage { get; set; }
        private Page PilonWithStagePage { get; set; }
        private Page PilonPage { get; set; }
        private Page PilonChineesPage { get; set; }
        private Page RingPage { get; set; }
        private Page RingWithBlockPage { get; set; }
        private Page SilkPage { get; set; }
        private Page SilkHammokPage { get; set; }
        private Page CurrentPage { get; set; }

        private Data Data { get; set; }

        private AdminButton adminButton;

        public Market()
        {
            Data = new Data();
            Data.LogData("---------------------------Новая сессия.---------------------------");
            InitializeComponent();
            InitPages();
            InitBackBattons();

            CurrentPage = MainPage;
            adminButton = new AdminButton(Data, ClientSize.Width);

            UpdatePage();
            //Load += ResizeElements;
            Resize += ResizeElements;
        }

        void InitBackBattons()
        {
            PilonWithStagePage.AddBackBatton(new BackButton(GetChangePageAction(PilonsPage)));
            PilonPage.AddBackBatton(new BackButton(GetChangePageAction(PilonsPage)));
            PilonChineesPage.AddBackBatton(new BackButton(GetChangePageAction(PilonsPage)));

            RingPage.AddBackBatton(new BackButton(GetChangePageAction(RingsPage)));
            RingWithBlockPage.AddBackBatton(new BackButton(GetChangePageAction(RingsPage)));

            SilkPage.AddBackBatton(new BackButton(GetChangePageAction(SilksPage)));
            SilkHammokPage.AddBackBatton(new BackButton(GetChangePageAction(SilksPage)));

            PilonsPage.AddBackBatton(new BackButton(GetChangePageAction(MainPage)));
            RingsPage.AddBackBatton(new BackButton(GetChangePageAction(MainPage)));
            SilksPage.AddBackBatton(new BackButton(GetChangePageAction(MainPage)));

        }
        
        void InitPages()
        {

            PilonWithStagePage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.пилон_на_подиуме, null, ""),
                    new OrderPagePart(Data,"Пилон на подиуме",
                        @"Пилон разборный на подиуме\n2 режима- динамика и статика
Материал - ...
Цвет - стандартный
Подиум разборный (6 сегментов)",
                        new string[] {"Длина", "Диаметр"}),
                });

            PilonPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.пилон_обычный, null, ""),
                    new OrderPagePart(Data,"Пилон", "Описание:", new string[] {"ФИО"}),
                });

            PilonChineesPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.подвесной_пилон, null, ""),
                    new OrderPagePart(Data,"Подвесной пилон", "Описание:", new string[] {"ФИО"}),
                });

            RingPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.кольцо_без_перекладины, null, ""),
                    new OrderPagePart(Data,"Кольцо", "Описание:", new string[] {"ФИО"}),
                });

            RingWithBlockPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.кольцо_с_перекладиной, null, ""),
                    new OrderPagePart(Data,"Кольцо с перекладиной", "Описание:", new string[] {"ФИО"}),
                });

            SilkPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.полотна, null, ""),
                    new OrderPagePart(Data,"Полотна", "Описание:", new string[] {"ФИО"}),
                });

            SilkHammokPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.гамак, null, ""),
                    new OrderPagePart(Data,"Гамак", "Описание:", new string[] {"ФИО"}),
                });

            PilonsPage = new Page(new PagePart[]
                    {
                        new PicturePagePart(Properties.Resources.пилон_на_подиуме, GetChangePageAction(PilonWithStagePage), "На подиуме"),
                        new PicturePagePart(Properties.Resources.пилон_обычный, GetChangePageAction(PilonPage), "Классический"),
                        new PicturePagePart(Properties.Resources.подвесной_пилон, GetChangePageAction(PilonChineesPage), "Подвесной")
                    });

            RingsPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.кольцо_без_перекладины, GetChangePageAction(RingPage), "Без перекладины"),
                    new PicturePagePart(Properties.Resources.кольцо_с_перекладиной, GetChangePageAction(RingWithBlockPage), "С перекладиной"),
                });

            SilksPage = new Page(new PagePart[]
                {
                    new PicturePagePart(Properties.Resources.полотна, GetChangePageAction(SilkPage), "Полотна"),
                    new PicturePagePart(Properties.Resources.гамак, GetChangePageAction(SilkHammokPage), "Гамак"),
                });

            MainPage = new Page(new PagePart[]
            {
                new PicturePagePart(Properties.Resources.пилоны, GetChangePageAction(PilonsPage), "Пилоны"),
                new PicturePagePart(Properties.Resources.кольца, GetChangePageAction(RingsPage), "Кольца"),
                new PicturePagePart(Properties.Resources.Полотнаа, GetChangePageAction(SilksPage), "Полотона")
            });
        }

        private void UpdatePage()
        {
            Controls.Clear();
            Controls.Add(adminButton.Button);

            if(CurrentPage.BackButton != null)
                Controls.Add(CurrentPage.BackButton.Button);

            if (CurrentPage.MainLabel != null)
                Controls.Add(CurrentPage.MainLabel);

            foreach (var pagePart in CurrentPage.PageParts)
                Controls.Add(pagePart.GroupBox);
            CurrentPage.Resize(ClientSize.Width, ClientSize.Height);
        }

        private Action<object, EventArgs> GetChangePageAction(Page page)
        {
            {
                return (x, y) =>
                {
                    CurrentPage = page;

                    Data.LogData("Страница изменена");
                    UpdatePage();
                };
            }
        }

        private void ResizeElements(object sender, EventArgs e)
        {
            CurrentPage.Resize(ClientSize.Width, ClientSize.Height);
        }
    }
}
