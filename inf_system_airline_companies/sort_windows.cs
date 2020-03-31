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
    public partial class sort_windows : Form
    {
        public sort_windows(List<Company> cmp_list, BindingSource bndsrc, DataGridView gridforcomp)
        {
            InitializeComponent();

            this.companies_list = cmp_list;
            this.companyBindingSource = bndsrc;
            this.gridforcomp = gridforcomp;
        }

        public List<Company> companies_list;
        BindingSource companyBindingSource;
        DataGridView gridforcomp;
        public Form1 parent_form;

        List<String> available_for_sort;
        List<String> used_in_sort;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void one_level_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (one_level_radio.Checked == true)
            {
                groupBox1.Enabled = true;
            } else
            {
                groupBox1.Enabled = false;
            }
        }

        private void multilevel_sort_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (multilevel_sort_radio.Checked == true)
            {
                group2.Enabled = true;
            } else
            {
                group2.Enabled = false;
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (one_level_radio.Checked == true)
            {
                //ОДНОУРОВНЕВАЯ СОРТИРОВКА

                if (by_name.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.name.CompareTo(y.name));
                    } else
                    {
                        companies_list.Sort((x, y) => y.name.CompareTo(x.name));
                    }
                }

                if (by_date.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => DateTime.Parse(x.year_of_foundation).CompareTo(DateTime.Parse(y.year_of_foundation)));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => DateTime.Parse(y.year_of_foundation).CompareTo(DateTime.Parse(x.year_of_foundation)));
                    }
                }

                if (by_type.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.type.CompareTo(y.type));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => y.type.CompareTo(x.type));
                    }
                }

                if (by_ceo.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.ceo.CompareTo(y.ceo));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => y.ceo.CompareTo(x.ceo));
                    }
                }


                if (by_cost.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.cost.CompareTo(y.cost));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => y.cost.CompareTo(x.cost));
                    }
                }


                if (by_loc.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.location.CompareTo(y.location));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => y.location.CompareTo(x.location));
                    }
                }


                if (by_empl.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.number_of_employees.CompareTo(y.number_of_employees));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => y.number_of_employees.CompareTo(x.number_of_employees));
                    }
                }


                if (by_planes.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.planes.Count.CompareTo(y.planes.Count));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => y.planes.Count.CompareTo(x.planes.Count));
                    }
                }

                if (by_dest_p.Checked == true)
                {
                    if (by_incr.Checked == true)
                    {
                        companies_list.Sort((x, y) => x.destination_points.Count.CompareTo(y.destination_points.Count));
                    }
                    else
                    {
                        companies_list.Sort((x, y) => y.destination_points.Count.CompareTo(x.destination_points.Count));
                    }
                }

            } else
            {
                //МНОГОУРОВНЕВАЯ СОРТИРОВКА

                if (used_in_sort.Count == 0)
                {
                    return;
                }

                IOrderedEnumerable<Company> temp_enum = null;

                for (int step = 0; step < used_in_sort.Count; step++)
                {
                    //ПЕРВАЯ СТАДИЯ СОРТИРОВКИ
                    if (step == 0)
                    {
                        switch (used_in_sort[step])
                        {
                            case "Имя компании":
                                temp_enum = companies_list.OrderBy((x) => x.name);
                                break;
                            case "Дата основания":
                                temp_enum = companies_list.OrderBy((x) => DateTime.Parse(x.year_of_foundation));
                                break;
                            case "Тип компании":
                                temp_enum = companies_list.OrderBy((x) => x.type);
                                break;
                            case "Стоимость компании":
                                temp_enum = companies_list.OrderBy((x) => x.cost);
                                break;
                            case "Владелец компании":
                                temp_enum = companies_list.OrderBy((x) => x.ceo);
                                break;
                            case "Расположение":
                                temp_enum = companies_list.OrderBy((x) => x.location);
                                break;
                            case "Кол-во сотрудников":
                                temp_enum = companies_list.OrderBy((x) => x.number_of_employees);
                                break;
                            case "Кол-во моделей самол.":
                                temp_enum = companies_list.OrderBy((x) => x.planes.Count);
                                break;
                            case "Кол-во пунктов назначения":
                                temp_enum = companies_list.OrderBy((x) => x.destination_points.Count);
                                break;
                            case "(УБЫВ) Имя компании":
                                temp_enum = companies_list.OrderByDescending((x) => x.name);
                                break;
                            case "(УБЫВ) Дата основания":
                                temp_enum = companies_list.OrderByDescending((x) => DateTime.Parse(x.year_of_foundation));
                                break;
                            case "(УБЫВ) Тип компании":
                                temp_enum = companies_list.OrderByDescending((x) => x.type);
                                break;
                            case "(УБЫВ) Стоимость компании":
                                temp_enum = companies_list.OrderByDescending((x) => x.cost);
                                break;
                            case "(УБЫВ) Владелец компании":
                                temp_enum = companies_list.OrderByDescending((x) => x.ceo);
                                break;
                            case "(УБЫВ) Расположение":
                                temp_enum = companies_list.OrderByDescending((x) => x.location);
                                break;
                            case "(УБЫВ) Кол-во сотрудников":
                                temp_enum = companies_list.OrderByDescending((x) => x.number_of_employees);
                                break;
                            case "(УБЫВ) Кол-во моделей самол.":
                                temp_enum = companies_list.OrderByDescending((x) => x.planes.Count);
                                break;
                            case "(УБЫВ) Кол-во пунктов назначения":
                                temp_enum = companies_list.OrderByDescending((x) => x.destination_points.Count);
                                break;
                        }
                    } else
                    {
                        //ОСТАЛЬНЫЕ СТАДИИ

                        switch (used_in_sort[step])
                        {
                            case "Имя компании":
                                temp_enum = temp_enum.ThenBy((x) => x.name);
                                break;
                            case "Дата основания":
                                temp_enum = temp_enum.ThenBy((x) => DateTime.Parse(x.year_of_foundation));
                                break;
                            case "Тип компании":
                                temp_enum = temp_enum.ThenBy((x) => x.type);
                                break;
                            case "Стоимость компании":
                                temp_enum = temp_enum.ThenBy((x) => x.cost);
                                break;
                            case "Владелец компании":
                                temp_enum = temp_enum.ThenBy((x) => x.ceo);
                                break;
                            case "Расположение":
                                temp_enum = temp_enum.ThenBy((x) => x.location);
                                break;
                            case "Кол-во сотрудников":
                                temp_enum = temp_enum.ThenBy((x) => x.number_of_employees);
                                break;
                            case "Кол-во моделей самол.":
                                temp_enum = temp_enum.ThenBy((x) => x.planes.Count);
                                break;
                            case "Кол-во пунктов назначения":
                                temp_enum = temp_enum.ThenBy((x) => x.destination_points.Count);
                                break;
                            case "(УБЫВ) Имя компании":
                                temp_enum = temp_enum.ThenByDescending((x) => x.name);
                                break;
                            case "(УБЫВ) Дата основания":
                                temp_enum = temp_enum.ThenByDescending((x) => DateTime.Parse(x.year_of_foundation));
                                break;
                            case "(УБЫВ) Тип компании":
                                temp_enum = temp_enum.ThenByDescending((x) => x.type);
                                break;
                            case "(УБЫВ) Стоимость компании":
                                temp_enum = temp_enum.ThenByDescending((x) => x.cost);
                                break;
                            case "(УБЫВ) Владелец компании":
                                temp_enum = temp_enum.ThenByDescending((x) => x.ceo);
                                break;
                            case "(УБЫВ) Расположение":
                                temp_enum = temp_enum.ThenByDescending((x) => x.location);
                                break;
                            case "(УБЫВ) Кол-во сотрудников":
                                temp_enum = temp_enum.ThenByDescending((x) => x.number_of_employees);
                                break;
                            case "(УБЫВ) Кол-во моделей самол.":
                                temp_enum = temp_enum.ThenByDescending((x) => x.planes.Count);
                                break;
                            case "(УБЫВ) Кол-во пунктов назначения":
                                temp_enum = temp_enum.ThenByDescending((x) => x.destination_points.Count);
                                break;
                        }
                    }

                    
                }

                //КОД, ОБНОВЛЯЮЩИЙ СОДЕРЖИМОЕ DATAGRIDVIEW И СПИСКА. ПРЯМОЕ ИЗМЕНЕНИЕ ПРИВОДИТ К СБОЮ РАБОТЫ GRID, ПОЭТОМУ ИСПОЛЬЗУЕТСЯ ПОЭЛЕМЕНТНОЕ ОБНОВЛЕНИЕ.

                int last_size = companies_list.Count;

                foreach (Company cmp in temp_enum.ToList())
                {
                    companies_list.Add(cmp);
                }

                for (int elem = 0; elem < last_size; elem++)
                {
                    companies_list.RemoveAt(0);
                }

            }


            companyBindingSource.ResetBindings(false);

            parent_form.hide_details_info();
            this.Hide();

        }

        private void sort_windows_Load(object sender, EventArgs e)
        {
            if (available_for_sort == null)
            {
                available_for_sort = new List<string>();
                used_in_sort = new List<string>();

                available_for_sort.Add("Имя компании");
                available_for_sort.Add("Дата основания");
                available_for_sort.Add("Тип компании");
                available_for_sort.Add("Стоимость компании");
                available_for_sort.Add("Владелец компании");
                available_for_sort.Add("Расположение");
                available_for_sort.Add("Кол-во сотрудников");
                available_for_sort.Add("Кол-во моделей самол.");
                available_for_sort.Add("Кол-во пунктов назначения");

                available_for_sort.Add("(УБЫВ) Имя компании");
                available_for_sort.Add("(УБЫВ) Дата основания");
                available_for_sort.Add("(УБЫВ) Тип компании");
                available_for_sort.Add("(УБЫВ) Стоимость компании");
                available_for_sort.Add("(УБЫВ) Владелец компании");
                available_for_sort.Add("(УБЫВ) Расположение");
                available_for_sort.Add("(УБЫВ) Кол-во сотрудников");
                available_for_sort.Add("(УБЫВ) Кол-во моделей самол.");
                available_for_sort.Add("(УБЫВ) Кол-во пунктов назначения");

                available.DataSource = available_for_sort;
                in_use.DataSource = used_in_sort;
            }

            


        }

        private void add_in_use_Click(object sender, EventArgs e)
        {
            if (available.SelectedIndex == -1 || available_for_sort.Count < 1)
            {
                return;
            }

            used_in_sort.Add(available_for_sort[available.SelectedIndex]);
            available_for_sort.Remove(available_for_sort[available.SelectedIndex]);

            if (used_in_sort.Count > 1)
            {
                switch_up.Enabled = true;
                switch_down.Enabled = true;
            } else
            {
                switch_down.Enabled = false;
                switch_up.Enabled = false;
            }

            if (available_for_sort.Count == 0)
            {
                add_in_use.Enabled = false;
            } else
            {
                add_in_use.Enabled = true;
            }

            if (used_in_sort.Count == 0)
            {
                delete_from_use.Enabled = false;
            } else
            {
                delete_from_use.Enabled = true;
            }

            available.DataSource = null;
            available.DataSource = available_for_sort;

            in_use.DataSource = null;
            in_use.DataSource = used_in_sort;
        }

        private void delete_from_use_Click(object sender, EventArgs e)
        {
            if (in_use.SelectedIndex == -1 || used_in_sort.Count < 1)
            {
                return;
            }

            available_for_sort.Add(used_in_sort[in_use.SelectedIndex]);
            used_in_sort.Remove(used_in_sort[in_use.SelectedIndex]);

            if (used_in_sort.Count > 1)
            {
                switch_up.Enabled = true;
                switch_down.Enabled = true;
            }
            else
            {
                switch_down.Enabled = false;
                switch_up.Enabled = false;
            }

            if (available_for_sort.Count == 0)
            {
                add_in_use.Enabled = false;
            }
            else
            {
                add_in_use.Enabled = true;
            }

            if (used_in_sort.Count == 0)
            {
                delete_from_use.Enabled = false;
            }
            else
            {
                delete_from_use.Enabled = true;
            }

            available.DataSource = null;
            available.DataSource = available_for_sort;

            in_use.DataSource = null;
            in_use.DataSource = used_in_sort;
        }

        private void switch_up_Click(object sender, EventArgs e)
        {
            if (in_use.SelectedIndex == -1 || used_in_sort.Count < 2 || in_use.SelectedIndex == 0)
            {
                return;
            }

            string temp = "";

            temp = used_in_sort[in_use.SelectedIndex];

            used_in_sort[in_use.SelectedIndex] = used_in_sort[in_use.SelectedIndex - 1];
            used_in_sort[in_use.SelectedIndex - 1] = temp;

            in_use.DataSource = null;
            in_use.DataSource = used_in_sort;
        }

        private void switch_down_Click(object sender, EventArgs e)
        {
            if (in_use.SelectedIndex == -1 || used_in_sort.Count < 2 || in_use.SelectedIndex == used_in_sort.Count-1)
            {
                return;
            }

            string temp = "";

            temp = used_in_sort[in_use.SelectedIndex];

            used_in_sort[in_use.SelectedIndex] = used_in_sort[in_use.SelectedIndex + 1];
            used_in_sort[in_use.SelectedIndex + 1] = temp;

            in_use.DataSource = null;
            in_use.DataSource = used_in_sort;
        }
    }
}
