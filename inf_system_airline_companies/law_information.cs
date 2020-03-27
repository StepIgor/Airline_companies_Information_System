using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //для деления больших чисел на разряды

namespace inf_system_airline_companies
{
    public partial class law_information : Form
    {
        public law_information(List<Company> lst, DataGridView gridforcomp)
        {
            InitializeComponent();

            this.gridforcomp = gridforcomp;
            this.companies_list = lst;
        }

        List<Company> companies_list;
        public DataGridView gridforcomp;

        private void law_information_Load(object sender, EventArgs e)
        {
            this.Text = companies_list[gridforcomp.SelectedRows[0].Index].name.ToString() + " | Юридическая информация";

            lawinf_count_empl.Text = companies_list[gridforcomp.SelectedRows[0].Index].number_of_employees.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")) + " чел.";
            if (companies_list[gridforcomp.SelectedRows[0].Index].cost == 0)
            {
                lawinf_comp_cost.Text = "Во владении государства (0 руб.)";
            } else
            {
                lawinf_comp_cost.Text = companies_list[gridforcomp.SelectedRows[0].Index].cost.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")) + " руб.";
            }


            lawinf_tax_num.Text = companies_list[gridforcomp.SelectedRows[0].Index].tax_number.ToString();
            lawinf_cert_inf.Text = companies_list[gridforcomp.SelectedRows[0].Index].certificate;


            //отображение пунктов назначения в Listbox

            destination_listbox.DataSource = companies_list[gridforcomp.SelectedRows[0].Index].destination_points;
        }

        private void destination_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Count > 0 && destination_listbox.SelectedIndex != -1)
            {
                edit_dest_point_but.Enabled = true;
                del_dest_point_but.Enabled = true;
            }
        }

        private void del_dest_point_but_Click(object sender, EventArgs e)
        {
            if (destination_listbox.SelectedIndex == -1)
            {
                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
                return;
            }

            if (companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Count > 0)
            {
                if (MessageBox.Show("Удалить выделенный пункт назначения?","Требуется подтверждение",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Remove(companies_list[gridforcomp.SelectedRows[0].Index].destination_points[destination_listbox.SelectedIndex]);

                    destination_listbox.DataSource = null;
                    destination_listbox.DataSource = companies_list[gridforcomp.SelectedRows[0].Index].destination_points;

                    del_dest_point_but.Enabled = false;
                    edit_dest_point_but.Enabled = false;
                }
            } else
            {
                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
            }
        }

        private void edit_dest_point_but_Click(object sender, EventArgs e)
        {
            if (destination_listbox.SelectedIndex == -1)
            {
                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
                return;
            }

            if (companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Count > 0 && destination_listbox.SelectedIndex != -1)
            {
                add_or_edit_dest_point edit_form = new add_or_edit_dest_point(companies_list[gridforcomp.SelectedRows[0].Index].destination_points, destination_listbox.SelectedIndex, true);

                edit_form.ShowDialog();
            }
            else
            {
                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
            }
        }

        private void law_information_Activated(object sender, EventArgs e)
        {
            destination_listbox.DataSource = null;
            destination_listbox.DataSource = companies_list[gridforcomp.SelectedRows[0].Index].destination_points;

            lawinf_count_empl.Text = companies_list[gridforcomp.SelectedRows[0].Index].number_of_employees.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")) + " чел.";
            if (companies_list[gridforcomp.SelectedRows[0].Index].cost == 0)
            {
                lawinf_comp_cost.Text = "Во владении государства (0 руб.)";
            }
            else
            {
                lawinf_comp_cost.Text = companies_list[gridforcomp.SelectedRows[0].Index].cost.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")) + " руб.";
            }


            lawinf_tax_num.Text = companies_list[gridforcomp.SelectedRows[0].Index].tax_number.ToString();
            lawinf_cert_inf.Text = companies_list[gridforcomp.SelectedRows[0].Index].certificate;
        }

        private void add_dest_point_but_Click(object sender, EventArgs e)
        {
            add_or_edit_dest_point edit_form = new add_or_edit_dest_point(companies_list[gridforcomp.SelectedRows[0].Index].destination_points, destination_listbox.SelectedIndex, false);

            edit_form.ShowDialog();
        }

        private void lawinf_changecount_but_Click(object sender, EventArgs e)
        {
            change_law_number_details new_form = new change_law_number_details(companies_list[gridforcomp.SelectedRows[0].Index],"employees");

            new_form.ShowDialog();
        }

        private void lawinf_change_compcost_but_Click(object sender, EventArgs e)
        {
            change_law_number_details new_form = new change_law_number_details(companies_list[gridforcomp.SelectedRows[0].Index], "cost");

            new_form.ShowDialog();
        }

        private void lawinf_change_tax_Click(object sender, EventArgs e)
        {
            change_law_number_details new_form = new change_law_number_details(companies_list[gridforcomp.SelectedRows[0].Index], "tax");

            new_form.ShowDialog();
        }
    }
}
