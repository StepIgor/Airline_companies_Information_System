using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //деление чисел на разряды

namespace inf_system_airline_companies
{
    public partial class planes_in_comp : Form
    {
        public planes_in_comp(List<Company> cmp_lst, DataGridView gridforcomp)
        {
            InitializeComponent();

            //передаем сетку самолетов и список компаний

            this.gridforcomp = gridforcomp;
            this.companies_list = cmp_lst;
        }

        public DataGridView gridforcomp;
        public List<Company> companies_list;
        public int row_selected; //для фиксированного обращения к списку компаний (через него обращение к самолетам)
        int start_length_for_comp_list; //стартовая длина списка компаний. для защиты программы от сбоев.

        private void planes_in_comp_Load(object sender, EventArgs e)
        {
            //предварительное заполнение + проверка прав админа + выделение строки
            start_length_for_comp_list = companies_list.Count;

            if (Program.is_admin == false) add_plane.Enabled = false;

            this.Text = companies_list[gridforcomp.SelectedRows[0].Index].name + " | Самолеты компании";

            header.Text = companies_list[gridforcomp.SelectedRows[0].Index].name + " > Самолёты";

            planeBindingSource.DataSource = companies_list[gridforcomp.SelectedRows[0].Index].planes;

            row_selected = gridforcomp.SelectedRows[0].Index;

            if (companies_list[gridforcomp.SelectedRows[0].Index].planes.Count > 0)
            gridforplanes_CellClick(gridforplanes,null);
        }

        private void gridforplanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //если выбрали самолет в списке (кликом)

            if (companies_list[gridforcomp.SelectedRows[0].Index].planes.Count == 0) return; //в пустом списке нечего отображать

            //проверка прав админа
            if (Program.is_admin == true)
            {
                edit_plane.Enabled = true;
                delete_plane.Enabled = true;
            }

            //отображение характеристик
            details_cost.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].cost.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")) + " Руб";
            details_speed.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].speed.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")) + " Км / Ч";
            details_distance.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].distance.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")) + " Км";

            //как мы помним, часть полей варьируется в зависимости от типа самолета
            if (companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].type == "Пассажирский")
            {
                details_vol.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].volume.ToString() + " Чел.";
                details_payload_label.Visible = false;
                details_payload.Visible = false;
            }
            else
            {
                details_vol.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].volume.ToString() + " М²";
                details_payload.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].payload_capacity.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")) + " Кг";
                details_payload_label.Visible = true;
                details_payload.Visible = true;
            }
        }

        private void hide_details_info()
        {
            //спрятать информацию о самолете (хар-ки)

            details_payload_label.Visible = false;
            details_payload.Visible = false;

            details_cost.Text = "";
            details_speed.Text = "";
            details_distance.Text = "";
            details_vol.Text = "";

            edit_plane.Enabled = false;
            delete_plane.Enabled = false;
        }

        private void delete_plane_Click(object sender, EventArgs e)
        {
            //запрос на удаление самолета

            if (MessageBox.Show("Вы действительно хотите удалить самолёт?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                companies_list[row_selected].planes.Remove(companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index]);
                planeBindingSource.ResetBindings(false);
                //прячем старую информацию
                hide_details_info();
                //активируем флаг наличия изменений
                Program.anything_was_changed = true;
                //очищаем строку поиска
                search_bar.Text = "";
            }
        }

        private void edit_plane_Click(object sender, EventArgs e)
        {
            search_bar.Text = "";

            //редактировать информацию о модели

            add_or_edit_plane new_form = new add_or_edit_plane(companies_list[row_selected].planes, gridforplanes, planeBindingSource, true);
            new_form.ShowDialog();
        }

        private void add_plane_Click(object sender, EventArgs e)
        {
            search_bar.Text = "";

            //добавить новую модель

            add_or_edit_plane new_form = new add_or_edit_plane(companies_list[row_selected].planes, gridforplanes, planeBindingSource, false);
            new_form.ShowDialog();
        }

        private void planes_in_comp_Activated(object sender, EventArgs e)
        {
            //сфокусировались на форме, обновили информацию
            //проверили, не удалили ли эту компанию в основном окне

            try
            { 
                gridforplanes_CellClick(gridforplanes, null);
            } catch (Exception)
            {
                this.Close();
            }

            //защита от изменений списка компаний во время просмотра списка самолетов
            if (companies_list.Count != start_length_for_comp_list)
            {
                this.Close();
            }
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            //строка поиска обновляется сразу же

            //заморозка биндинга, чтобы не было ошибок
            planeBindingSource.SuspendBinding();

            if (search_bar.Text.Length == 0)
            {
                //при пустой строке нужно отобразить все
                for (int elem = 0; elem < companies_list[row_selected].planes.Count; elem++)
                {
                    gridforplanes.Rows[elem].Visible = true;
                }
            } else
            {
                //проверка на наличие подстроки в названии модели
                for (int elem = 0; elem < companies_list[row_selected].planes.Count; elem++)
                {
                    if (companies_list[row_selected].planes[elem].name.IndexOf(search_bar.Text) == -1)
                    {
                        gridforplanes.Rows[elem].Visible = false;
                    } else
                    {
                        gridforplanes.Rows[elem].Visible = true;
                    }
                    
                }
            }

            //продолжаем привязку
            planeBindingSource.ResumeBinding();
            //прячем старую информацию (хар-ки)
            hide_details_info();
        }

        private void sort_model_CheckedChanged(object sender, EventArgs e)
        {
            //если поменяли тип сортировки ( по имени )

            companies_list[row_selected].planes.Sort((x,y) => x.name.CompareTo(y.name));

            planeBindingSource.ResetBindings(false);
            hide_details_info();
            //переактивировали поиск
            search_bar_TextChanged(this, null);
        }

        private void sort_count_CheckedChanged(object sender, EventArgs e)
        {
            //если поменяли тип сортировки ( по кол-ву экз. )

            companies_list[row_selected].planes.Sort((x, y) => x.count.CompareTo(y.count));

            planeBindingSource.ResetBindings(false);
            hide_details_info();
            //переактивировали поиск
            search_bar_TextChanged(this, null);
        }

        private void sort_type_CheckedChanged(object sender, EventArgs e)
        {
            //если поменяли тип сортировки ( по типу )

            companies_list[row_selected].planes.Sort((x, y) => x.type.CompareTo(y.type));

            planeBindingSource.ResetBindings(false);
            hide_details_info();
            //переактивировали поиск
            search_bar_TextChanged(this, null);
        }

        private void gridforplanes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //даем возможность выбора самолетов клавиатурой (пробелом выделение)

            if (e.KeyChar == ' ')
            {
                gridforplanes_CellClick(this, null);
            }
        }
    }
}
