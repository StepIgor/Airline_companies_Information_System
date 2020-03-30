using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inf_system_airline_companies
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            user.Text = "Пользователь";


        }

        private void user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user.Text == "Пользователь")
            {
                password.Text = "";
                password.Enabled = false;
            } else
            {
                password.Text = "";
                password.Enabled = true;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (user.Text == "Пользователь")
            {
                open_file_stage new_form = new open_file_stage();
                new_form.Show();

                this.Hide();
            }
            else
            {
                if (password.Text == "test")
                {
                    Program.is_admin = true;
                    open_file_stage new_form = new open_file_stage();
                    new_form.Show();

                    this.Hide();
                } else
                {
                    MessageBox.Show("Вы ввели неправильный пароль.", "Доступ запрещен");
                    return;
                }
            }
        }
    }
}
