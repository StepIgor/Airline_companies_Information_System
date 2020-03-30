using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace inf_system_airline_companies
{
    public partial class open_file_stage : Form
    {
        public open_file_stage()
        {
            InitializeComponent();
        }

        private void open_file_stage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void start_but_Click(object sender, EventArgs e)
        {
            if (create_new_file.Checked == true)
            {
                Program.opened_file = "<new>";
            } else if(open_demo.Checked == true)
            {
                Program.opened_file = "<sample>";
            } else if(select_my_file.Checked == true)
            {
                Program.opened_file = file_name.Text;
            } else if(last_opened_radio.Checked == true)
            {
                if (System.IO.File.Exists(last_opened_radio.Text))
                {
                    Program.opened_file = last_opened_radio.Text;
                } else
                {
                    MessageBox.Show("Данного файла уже не существует по указанному пути.");
                    return;
                }
                
            }

            Form1 new_form = new Form1();

            new_form.Show();

            this.Hide();
        }

        private void select_file_but_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                file_name.Text = openFileDialog1.FileName;
                Program.opened_file = openFileDialog1.FileName;
            }
        }

        private void select_my_file_CheckedChanged(object sender, EventArgs e)
        {
            if (select_my_file.Checked == true)
            {
                select_file_but.Enabled = true;
                if (file_name.Text != "")
                {
                    Program.opened_file = file_name.Text;
                }
            } else
            {
                select_file_but.Enabled = false;
            }
        }

        private void open_file_stage_Load(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") != null && Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System").GetValue("last_opened") != null)
            {
                last_opened_radio.Text = Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System").GetValue("last_opened").ToString();
                last_opened_radio.Enabled = true;
            } else
            {
                last_opened_radio.Text = "Вы еще не открывали файлы";
            }
        }
    }
}
