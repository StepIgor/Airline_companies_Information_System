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
    public partial class filter_windows : Form
    {
        public filter_windows(List<Company> cmp_lst, DataGridView gridforcmp)
        {
            InitializeComponent();

            this.companies_list = cmp_lst;
            this.gridforcompany = gridforcmp;
        }

        public List<Company> companies_list;
        DataGridView gridforcompany;

        private void filter_windows_Load(object sender, EventArgs e)
        {

        }

        private void use_filter_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (use_filter_checkbox.Checked == true)
            {
                filter_set_group.Enabled = true;
            } else
            {
                filter_set_group.Enabled = false;
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {   
            //ВАЛИДАЦИЯ ПОЛЕЙ

            if (use_filter_checkbox.Checked == true)
            {
                if (name_fil.Checked == true)
                {
                    if (!(name_fil_textbox.Text.Length > 0 && name_fil_textbox.Text.Length <= 24))
                    {
                        MessageBox.Show("Фильтр по названию компании должен быть длиной от 1 до 24 символов.","Внимание");
                        return;
                    }
                }

                if (date_fil.Checked == true)
                {
                    if (min_date.Text == "" && max_date.Text == "")
                    {
                        MessageBox.Show("Фильтр по дате основания компании должен иметь хотя бы одно заполненное поле.", "Внимание");
                        return;
                    }

                    string[] check_split_min = min_date.Text.Split('.');
                    string[] check_split_max = max_date.Text.Split('.');

                    if(min_date.Text.Length > 0 && check_split_min.Count() != 3){
                        MessageBox.Show("Фильтр по дате основания,а точнее поле ОТ имеет неправильное заполение. Соблюдайте образец: 19.05.2000", "Внимание");
                        return;
                    }

                    if (max_date.Text.Length > 0 && check_split_max.Count() != 3)
                    {
                        MessageBox.Show("Фильтр по дате основания,а точнее поле ДО имеет неправильное заполение. Соблюдайте образец: 19.05.2000", "Внимание");
                        return;
                    }

                    if (check_split_min.Count() == 3)
                    {
                        foreach (string elem in check_split_min)
                        {
                            if (!Int32.TryParse(elem, out _))
                            {
                                MessageBox.Show("Поле ОТ фильтра ДАТА ОСНОВАНИЯ КОМПАНИИ имеет буквы, что не правильно. Соблюдайте образец: 19.05.2000", "Внимание");
                                return;
                            }
                        }
                    }
                        
                    if (check_split_max.Count() == 3)
                    {
                        foreach (string elem in check_split_max)
                        {
                            if (!Int32.TryParse(elem, out _))
                            {
                                MessageBox.Show("Поле ДО фильтра ДАТА ОСНОВАНИЯ КОМПАНИИ имеет буквы, что не правильно. Соблюдайте образец: 19.05.2000", "Внимание");
                                return;
                            }
                        }
                    }

                    

                    try
                    {
                        if (min_date.Text.Length > 0)
                        {
                            DateTime try_min_date = DateTime.Parse(min_date.Text);
                        }
                        if (max_date.Text.Length > 0)
                        {
                            DateTime try_max_date = DateTime.Parse(max_date.Text);
                        }
                        
                    } catch (Exception)
                    {
                        MessageBox.Show("Фильтр по дате неправильно заполнен. Соблюдайте образец: 19.05.2000", "Внимание");
                        return;
                    }


                    if (min_date.Text.Length > 0 && max_date.Text.Length > 0 && DateTime.Parse(min_date.Text) > DateTime.Parse(max_date.Text))
                    {
                        MessageBox.Show("В фильтре ДАТА ОСНОВАНИЯ неправильно выставлен диапазон.", "Внимание");
                        return;
                    }
                }


                if (ceo_fil.Checked == true)
                {
                    if (!(ceo_name.Text.Length > 0 && ceo_name.Text.Length <= 48))
                    {
                        MessageBox.Show("Фильтр по владельцу должен иметь длину от 1 до 48 символов.", "Внимание");
                        return;
                    }
                }


                if (cost_fil.Checked == true)
                {
                    if(cost_max.Text.Length == 0 && cost_min.Text.Length == 0)
                    {
                        MessageBox.Show("Хотя бы одно поле в фильтре цены компании должно быть заполнено.", "Внимание");
                        return;
                    }

                    if (cost_min.Text.Length > 0 && !long.TryParse(cost_min.Text, out _))
                    {
                        MessageBox.Show("Поле ОТ в фильтре ЦЕНА КОМПАНИИ заполнено неверно.", "Внимание");
                        return;
                    }

                    if (cost_max.Text.Length > 0 && !long.TryParse(cost_max.Text, out _))
                    {
                        MessageBox.Show("Поле ДО в фильтре ЦЕНА КОМПАНИИ заполнено неверно.", "Внимание");
                        return;
                    }

                    if (cost_min.Text.Length > 0 && cost_max.Text.Length > 0 && long.Parse(cost_min.Text) > long.Parse(cost_max.Text))
                    {
                        MessageBox.Show("В фильтре ЦЕНА КОМПАНИИ неправильно выставлен диапазон.", "Внимание");
                        return;
                    }
                }


                if (loc_fil.Checked == true)
                {
                    if (country_fil.Text.Length == 0)
                    {
                        MessageBox.Show("Поле СТРАНА в фильтре РАСПОЛОЖЕНИЕ обязательно для заполнения", "Внимание");
                        return;
                    }

                    if (country_fil.Text.Length > 32) {
                        MessageBox.Show("Поле СТРАНА в фильтре РАСПОЛОЖЕНИЕ должно быть до 32 символов по размеру.", "Внимание");
                        return;
                    }

                    if (city_fil.Text.Length > 32)
                    {
                        MessageBox.Show("Поле ГОРОД в фильтре РАСПОЛОЖЕНИЕ должно быть до 32 символов по размеру.", "Внимание");
                        return;
                    }
                }


                if (num_emp_fil.Checked == true)
                {
                    if (min_empl.Text.Length == 0 && max_empl.Text.Length == 0)
                    {
                        MessageBox.Show("Хотя бы одно поле в фильтре КОЛ-ВО СОТРУДНИКОВ должно быть заполнено.", "Внимание");
                        return;
                    }

                    if (min_empl.Text.Length > 0 && !int.TryParse(min_empl.Text, out _))
                    {
                        MessageBox.Show("Неправильно заполнено поле ОТ в фильтре КОЛ-ВО СОТРУДНИКОВ.", "Внимание");
                        return;
                    }

                    if (max_empl.Text.Length > 0 && !int.TryParse(max_empl.Text, out _))
                    {
                        MessageBox.Show("Неправильно заполнено поле ДО в фильтре КОЛ-ВО СОТРУДНИКОВ.", "Внимание");
                        return;
                    }

                    if (min_empl.Text.Length > 0 && max_empl.Text.Length > 0 && int.Parse(min_empl.Text) > int.Parse(max_empl.Text))
                    {
                        MessageBox.Show("В фильтре КОЛ-ВО СОТРУДНИКОВ неправильно выставлен диапазон.", "Внимание");
                        return;
                    }
                }


                if (dest_p_count_fil.Checked == true)
                {
                    if (min_dest_p_count.Text.Length == 0 && max_dest_p_count.Text.Length == 0)
                    {
                        MessageBox.Show("Хотя бы одно поле в фильтре КОЛ-ВО ПУНКТОВ НАЗНАЧЕНИЯ должно быть заполнено.", "Внимание");
                        return;
                    }

                    if (min_dest_p_count.Text.Length > 0 && !int.TryParse(min_dest_p_count.Text, out _))
                    {
                        MessageBox.Show("Неправильно заполнено поле ОТ в фильтре КОЛ-ВО ПУНКТОВ НАЗНАЧЕНИЯ.", "Внимание");
                        return;
                    }

                    if (max_dest_p_count.Text.Length > 0 && !int.TryParse(max_dest_p_count.Text, out _))
                    {
                        MessageBox.Show("Неправильно заполнено поле ДО в фильтре КОЛ-ВО ПУНКТОВ НАЗНАЧЕНИЯ.", "Внимание");
                        return;
                    }

                    if (min_dest_p_count.Text.Length > 0 && max_dest_p_count.Text.Length > 0 && int.Parse(min_dest_p_count.Text) > int.Parse(max_dest_p_count.Text))
                    {
                        MessageBox.Show("В фильтре КОЛ-ВО ПУНКТОВ НАЗНАЧЕНИЯ неправильно выставлен диапазон.", "Внимание");
                        return;
                    }
                }


                if (desti_p_content_fil.Checked == true)
                {
                    if (country_fil_dest.Text.Length == 0)
                    {
                        MessageBox.Show("Поле СТРАНА в фильтре ОСУЩЕСТВЛ. ПОЛЁТЫ В обязательно для заполнения", "Внимание");
                        return;
                    }

                    if (country_fil_dest.Text.Length > 32)
                    {
                        MessageBox.Show("Поле СТРАНА в фильтре ОСУЩЕСТВЛ. ПОЛЁТЫ В должно быть до 32 символов по размеру.", "Внимание");
                        return;
                    }

                    if (city_fil_dest.Text.Length > 32)
                    {
                        MessageBox.Show("Поле ГОРОД в фильтре ОСУЩЕСТВЛ. ПОЛЁТЫ В должно быть до 32 символов по размеру.", "Внимание");
                        return;
                    }
                }


                if (model_count_fil.Checked == true)
                {
                    if (min_model_count.Text.Length == 0 && max_model_count.Text.Length == 0)
                    {
                        MessageBox.Show("Хотя бы одно поле в фильтре КОЛ-ВО МОДЕЛЕЙ САМОЛЁТОВ должно быть заполнено.", "Внимание");
                        return;
                    }

                    if (min_model_count.Text.Length > 0 && !int.TryParse(min_model_count.Text, out _))
                    {
                        MessageBox.Show("Неправильно заполнено поле ОТ в фильтре КОЛ-ВО МОДЕЛЕЙ САМОЛЁТОВ.", "Внимание");
                        return;
                    }

                    if (max_model_count.Text.Length > 0 && !int.TryParse(max_model_count.Text, out _))
                    {
                        MessageBox.Show("Неправильно заполнено поле ДО в фильтре КОЛ-ВО МОДЕЛЕЙ САМОЛЁТОВ.", "Внимание");
                        return;
                    }

                    if (min_model_count.Text.Length > 0 && max_model_count.Text.Length > 0 && int.Parse(min_model_count.Text) > int.Parse(max_model_count.Text))
                    {
                        MessageBox.Show("В фильтре КОЛ-ВО МОДЕЛЕЙ САМОЛЁТОВ неправильно выставлен диапазон.", "Внимание");
                        return;
                    }
                }


                if (model_content_fil.Checked == true)
                {
                    if (!(models_content_enum.Text.Length > 0 && models_content_enum.Text.Length < 257))
                    {
                        MessageBox.Show("Поле фильтра ПО ИМЕНАМ МОДЕЛЕЙ САМОЛЁТОВ должно быть длиной от 1 до 256 символов. Деление - ;", "Внимание");
                        return;
                    }
                }
            }

            //НЕПОСРЕДСТВЕННО ФИЛЬРАЦИЯ


            this.Hide();
        }

        private void name_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = name_fil.Checked;
        }

        private void date_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = date_fil.Checked;
        }

        private void type_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = type_fil.Checked;
        }

        private void ceo_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = ceo_fil.Checked;
        }

        private void cost_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = cost_fil.Checked;
        } 

        private void loc_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = loc_fil.Checked;
        }

        private void emp_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox7.Enabled = num_emp_fil.Checked;
        }

        private void dest_p_count_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox8.Enabled = dest_p_count_fil.Checked;
        }

        private void dest_p_content_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox9.Enabled = desti_p_content_fil.Checked;
        }

        private void model_count_fil_CheckedChanged(object sender, EventArgs e)
        {
            groupBox10.Enabled = model_count_fil.Checked;
        }

        private void model_content_CheckedChanged(object sender, EventArgs e)
        {
            groupBox11.Enabled = model_content_fil.Checked;
            if (model_content_fil.Checked == true)
            MessageBox.Show("Указывайте модели самолетов через ТОЧКУ С ЗАПЯТОЙ. Кавычки не писать.");
        }
    }
}
