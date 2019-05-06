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
    public partial class RegistrationForm : Form
    {
        private Page Page { get; set; }
        public RegistrationForm(Data data)
        {
            InitializeComponent();

            Page = new Page(new []{new RegistrationPagePart(data)}, backButton: new BackButton((x,y) => Close()));
            Resize += ResizeElements;
            UpdatePage();
        }

        private void UpdatePage()
        {
            Controls.Clear();
            
            Controls.Add(Page.BackButton.Button);
            

            foreach (var pagePart in Page.PageParts)
                Controls.Add(pagePart.GroupBox);
            Page.Resize(ClientSize.Width, ClientSize.Height);
        }

        private void ResizeElements(object sender, EventArgs e)
        {
            Page.Resize(ClientSize.Width, ClientSize.Height);
        }
    }
}
