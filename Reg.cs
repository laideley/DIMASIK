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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            if (log.Text.Length < 2 || pass1.Text.Length < 2 || pass2.Text.Length < 2)
            {
                MessageBox.Show("Текстовые поля меньше двух символов");
            }
            else
            {
                string[] login = File.ReadAllLines(@"C:\app\log.txt");
                if (login.Contains(log.Text))
                {
                    MessageBox.Show("Логин уже занят");
                }
                else if (pass1.Text == pass2.Text)
                {
                    string l = @"C:\app\log.txt";
                    string p = @"C:\app\pass.txt";
                    File.AppendAllText(l, (log.Text + "\n"));
                    File.AppendAllText(p, (pass1.Text + "\n"));
                    MessageBox.Show("Регистрация успешна");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
        }
    }
}
