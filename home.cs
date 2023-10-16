using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сash_register
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void ent_acc(object sender, EventArgs e)
        {
            Log log = new Log();
            log.Show();
        }

        private void reg_acc(object sender, PaintEventArgs e)
        {
        }

        private void exit(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Уверены что хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
        }
    }
}
