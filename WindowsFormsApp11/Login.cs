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
    public partial class LoginDialog : Form
    {
        private Data Data { get; }

        public LoginDialog(Data data)
        {
            Data = data;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            PasswordBox.PasswordChar = '•';
            CancelButton.Click += (x, y) => { Close();};
            AcceptButton.Click += EnterAction;
        }
        void EnterAction(object x, EventArgs y)
        {
            CheckPassword(LoginBox.Text, PasswordBox.Text);
        }

        private void CheckPassword(string login, string password)
        {
            if (login == "admin" && password == "password")
            {
                var adminForm = new AdminForm(Data);
                Data.LogData("Вход в режим администратора.");
                adminForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Data.LogData("Неудачная попытка входа.");
            }
        }
    }
}
