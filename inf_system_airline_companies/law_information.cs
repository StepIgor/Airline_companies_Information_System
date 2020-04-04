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

            //передаем грид компаний
            //и список компаний
            this.gridforcomp = gridforcomp;
            this.companies_list = lst;
        }

        List<Company> companies_list;
        public DataGridView gridforcomp;

        private void law_information_Load(object sender, EventArgs e)
        {

            //проверяем права админа
            if (Program.is_admin == false)
            {
                //морозим кнопки редактирования
                add_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
                del_dest_point_but.Enabled = false;

                lawinf_changecount_but.Enabled = false;
                lawinf_change_compcost_but.Enabled = false;
                lawinf_change_cert.Enabled = false;
                lawinf_change_tax.Enabled = false;
            }

            //адаптивный заголовок
            this.Text = companies_list[gridforcomp.SelectedRows[0].Index].name.ToString() + " | Юридическая информация";


            //автоматич. подстановка имеющейся информации
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
            //при выделении строки в списке пунктов назначения проверяем права админа
            if (companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Count > 0 && destination_listbox.SelectedIndex != -1)
            {
                if (Program.is_admin == false)
                {
                    return;
                }
                edit_dest_point_but.Enabled = true;
                del_dest_point_but.Enabled = true;
            }
        }

        private void del_dest_point_but_Click(object sender, EventArgs e)
        {
            //удаление пункта назначения

            if (destination_listbox.SelectedIndex == -1)
            {
                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
                return;
            }

            if (companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Count > 0)
            {
                //предварительно уточняем намерения пользователя
                int saved_index = destination_listbox.SelectedIndex;
                if (MessageBox.Show("Удалить выделенный пункт назначения?","Требуется подтверждение",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Remove(companies_list[gridforcomp.SelectedRows[0].Index].destination_points[saved_index]);

                    //обновление отображения Listbox
                    destination_listbox.DataSource = null;
                    destination_listbox.DataSource = companies_list[gridforcomp.SelectedRows[0].Index].destination_points;

                    del_dest_point_but.Enabled = false;
                    edit_dest_point_but.Enabled = false;

                    //ставим флаг наличия изменений
                    Program.anything_was_changed = true;
                }
            } else
            {
                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
            }
        }

        private void edit_dest_point_but_Click(object sender, EventArgs e)
        {
            //редактирование пункта назначения
            if (destination_listbox.SelectedIndex == -1)
            {
                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
                return;
            }

            if (companies_list[gridforcomp.SelectedRows[0].Index].destination_points.Count > 0 && destination_listbox.SelectedIndex != -1)
            {
                //вызываем форму редактирования

                add_or_edit_dest_point edit_form = new add_or_edit_dest_point(companies_list[gridforcomp.SelectedRows[0].Index].destination_points, destination_listbox.SelectedIndex, true);

                edit_form.ShowDialog();
            }
            else
            {
                //если выделения нет, морозим кнопки редактирования

                del_dest_point_but.Enabled = false;
                edit_dest_point_but.Enabled = false;
            }
        }

        private void law_information_Activated(object sender, EventArgs e)
        {
            //если сделали фокус на форме

            //нужно обновить всю информацию (например, после закрытия формы редактирования)

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
            //добавление пункта назначения

            add_or_edit_dest_point edit_form = new add_or_edit_dest_point(companies_list[gridforcomp.SelectedRows[0].Index].destination_points, destination_listbox.SelectedIndex, false);

            edit_form.ShowDialog();
        }

        private void lawinf_changecount_but_Click(object sender, EventArgs e)
        {
            //изменить количество сотруников

            change_law_number_details new_form = new change_law_number_details(companies_list[gridforcomp.SelectedRows[0].Index],"employees");

            new_form.ShowDialog();
        }

        private void lawinf_change_compcost_but_Click(object sender, EventArgs e)
        {
            //изменить стоимость компании

            change_law_number_details new_form = new change_law_number_details(companies_list[gridforcomp.SelectedRows[0].Index], "cost");

            new_form.ShowDialog();
        }

        private void lawinf_change_tax_Click(object sender, EventArgs e)
        {
            //изменить налоговый номер

            change_law_number_details new_form = new change_law_number_details(companies_list[gridforcomp.SelectedRows[0].Index], "tax");

            new_form.ShowDialog();
        }

        private void lawinf_change_cert_Click(object sender, EventArgs e)
        {
            //изменить лицензию на право деятельности

            change_certificate new_form = new change_certificate(companies_list[gridforcomp.SelectedRows[0].Index]);

            new_form.ShowDialog();
        }
    }
}
