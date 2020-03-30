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
                Program.opened_file = last_opened_radio.Text;
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
    }
}
