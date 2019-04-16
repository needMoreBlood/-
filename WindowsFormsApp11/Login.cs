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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            PasswordBox.PasswordChar = '•';
            CancelButton.Click += (x, y) => { Close();};
            AcceptButton.Click += EnterAction;
            PasswordBox.Enter += EnterAction;
        }
        void EnterAction(object x, EventArgs y)
        {
            CheckPassword(LoginBox.Text, PasswordBox.Text);
        }

        private void CheckPassword(string login, string password)
        {
            if (login == "admin" && password == "password")
            {
                var adminForm = new AdminForm();
                adminForm.Show();
                adminForm.TopMost = true;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
