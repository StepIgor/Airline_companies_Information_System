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
    public partial class add_or_edit_dest_point : Form
    {
        public add_or_edit_dest_point(List<String> dest_list, int selected_row, bool edit = false)
        {
            InitializeComponent();

            this.dest_list = dest_list;
            this.selected_row = selected_row;
            this.edit = edit;
        }

        List<String> dest_list;
        int selected_row;
        bool edit;

        private void add_or_edit_dest_point_Load(object sender, EventArgs e)
        {
            if (edit == true)
            {
                this.Text = "Редактировать";
                accept.Text = "Применить";

                country.Text = dest_list[selected_row].Split(',')[1].Trim(' ');
                city.Text = dest_list[selected_row].Split(',')[0];
            } else
            {
                this.Text = "Добавить";
                accept.Text = "Добавить";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (!(country.Text.Length > 0 && country.Text.Length < 33 && country.Text.IndexOf(',') == -1))
            {
                MessageBox.Show("Название страны должно быть по длине до 32 символов и не включать запятые.", "Обратите внимание!");
                return;
            }

            if (!(city.Text.Length > 0 && city.Text.Length < 33 && city.Text.IndexOf(',') == -1))
            {
                MessageBox.Show("Название города должно быть по длине до 32 символов и не включать запятые.", "Обратите внимание!");
                return;
            }

            if (edit == true)
            {
                dest_list[selected_row] = city.Text + ", " + country.Text;
            } else {
                dest_list.Add(city.Text + ", " + country.Text);
            }

            this.Close();
        }
    }
}
