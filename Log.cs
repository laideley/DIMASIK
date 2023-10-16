using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сash_register
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Enter(object sender, EventArgs e)
        {
            string[] login = File.ReadAllLines(@"C:\app\log.txt");
            string[] password = File.ReadAllLines(@"C:\app\log.txt");
            if (login_.Text.Length < 2 || password_.Text.Length < 2)
            {
                MessageBox.Show("Текстовые поля меньше двух символов");
            }
            else
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login_.Text == "admin" && password_.Text == "admin")
                    {
                       // Acc.access = "admin";
                        MessageBox.Show("Добро пожаловать уважаемый Админ");
                        this.Close();
                        break;
                    }

                    else if (login_.Text == "rab" && password_.Text == "rab")
                    {
                        // Acc.access = "admin";
                        MessageBox.Show("Добро пожаловать уважаемый Админ");
                        this.Close();
                        break;
                    }

                    else if (login_.Text == login[i] & password_.Text == password[i])
                    {
                       // Acc.access = "user";
                        MessageBox.Show("Добро пожаловать");
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }

                }
            }
        }
    }
}
