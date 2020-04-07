using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //деление больших чисел на разряды
using System.Windows.Forms.DataVisualization.Charting; //отображение диаграммы (круговой)


namespace inf_system_airline_companies
{
    public partial class visualisation : Form
    {
        public visualisation(List<Company> cmp_list)
        {
            InitializeComponent();

            //передаем список компаний

            this.companies_list = cmp_list;
        }

        List<Company> companies_list;

        private void visualisation_Load(object sender, EventArgs e)
        {
            //очищаем диаграмму
            chart1.Series.Clear();

            // Форматировать диаграмму
            chart1.BackColor = Color.LightGray;

            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineColor = Color.LightGray;

            // Форматировать область диаграммы
            chart1.ChartAreas[0].BackColor = Color.LightGray;
        }

        private void type_1_CheckedChanged(object sender, EventArgs e)
        {
            //если нужен отчет 1 типа
            groupBox1.Enabled = type_1.Checked;
        }

        private void type_2_CheckedChanged(object sender, EventArgs e)
        {
            //если нужен отчет 2 типа
            groupBox2.Enabled = type_2.Checked;
        }

        private void generate_text_Click(object sender, EventArgs e)
        {
            //генерация отчета
            //out_put - текст отчета

            if (companies_list.Count == 0)
            {
                MessageBox.Show("Данных нет. Строить отчеты нет смысла.","Отчет по пустым данным?");
                return;
            }

            //общий заголовок с датой
            out_put.Text = "Отчёт от " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n";

            if (type_1.Checked == true)
            {
                //ПО ВСЕМ В СОВОКУПНОСТИ тип 1

                //общий заголовок для этого типа
                out_put.Text += "Сформирован по всем компаниям в базе в совокупности.\n----------\n";

                if (by_type_1.Checked == true)
                {
                    //по типу компаний

                    out_put.Text +=  by_type_1.Text + "\n----------\n";

                    int type_a = 0;
                    int type_b = 0;
                    int type_c = 0;

                    foreach (Company cmp in companies_list)
                    {
                        if (cmp.type == "Пассажирская")
                        {
                            type_a += 1;
                        } else if (cmp.type == "Грузовая")
                        {
                            type_b += 1;
                        } else
                        {
                            type_c += 1;
                        }
                    }

                    out_put.Text += string.Format("Пассажирских:{0,25}\n",Convert.ToString(type_a));
                    out_put.Text += string.Format("Грузовых:{0,29}\n", Convert.ToString(type_b));
                    out_put.Text += string.Format("Смешанных:{0,28}\n", Convert.ToString(type_c));

                }


                if (by_price_1.Checked == true)
                {
                    //по цене

                    out_put.Text += by_price_1.Text + "\n----------\n";
                    out_put.Text += "ОБРАТИТЕ ВНИМАНИЕ:\nВ отчёт не включаются компании, находящиеся в гос. собственности (0 руб.)\n----------\n";

                    //требуется предварительная проверка. у нас не должны быть в списке только компании, наход. в гос. собственности (угроза деления на 0!)

                    int total_zero = 0;
                    int total_cmp = companies_list.Count;

                    foreach (Company cmp in companies_list)
                    {
                        if (cmp.cost == 0)
                        {
                            total_zero += 1;
                        }
                    }

                    //если все компании в гос. собственности
                    if (total_zero == total_cmp)
                    {
                        out_put.Text += "Этот тип отчета нельзя сформировать с текущими данными.";
                        return;
                    }

                    long min = 999999999999999;
                    string min_name = "";
                    long max = -1;
                    string max_name = "";
                    long avg_sum = 0;

                    foreach (Company cmp in companies_list)
                    {
                        if (cmp.cost == 0) continue; //0 (гос. собственность) не берем в расчеты
                        avg_sum += cmp.cost;

                        if (cmp.cost > max)
                        {
                            max = cmp.cost;
                            max_name = cmp.name;
                        } 

                        if (cmp.cost < min)
                        {
                            min = cmp.cost;
                            min_name = cmp.name;
                        }
                    }

                    avg_sum = avg_sum / (total_cmp - total_zero);

                    out_put.Text += string.Format("Самая дешевая компания:\n{0,-24}{1,20} Руб.\n\n", min_name, min.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Самая дорогая компания:\n{0,-24}{1,20} Руб.\n\n", max_name, max.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Средняя стоимость компании:\n{0,25} Руб.", avg_sum.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                }


                if (by_loc_1.Checked == true)
                {
                    //по расположению

                    List<string> country_names = new List<string>();    //содержит названия стран
                    List<int> country_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                    foreach (Company cmp in companies_list)
                    {
                        if (country_names.IndexOf(cmp.location.Split(',')[1].Trim(' ')) == -1)
                        {
                            country_names.Add(cmp.location.Split(',')[1].Trim(' '));
                            country_count.Add(0);
                        }
                    }


                    foreach (Company cmp in companies_list)
                    {
                        country_count[country_names.IndexOf(cmp.location.Split(',')[1].Trim(' '))] += 1;
                    }

                    out_put.Text += by_loc_1.Text + "\n----------\n";


                    for (int elem = 0; elem < country_names.Count; elem++)
                    {
                        out_put.Text += string.Format("{0,-35}{1,5}\n", country_names[elem], country_count[elem]);
                    }

                }


                if (by_loc_and_city_1.Checked == true)
                {
                    //по расположению с учетом города

                    List<string> location_names = new List<string>();    //содержит названия стран и городов
                    List<int> locations_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                    foreach (Company cmp in companies_list)
                    {
                        if (location_names.IndexOf(cmp.location) == -1)
                        {
                            location_names.Add(cmp.location);
                            locations_count.Add(0);
                        }
                    }


                    foreach (Company cmp in companies_list)
                    {
                        locations_count[location_names.IndexOf(cmp.location)] += 1;
                    }

                    out_put.Text += by_loc_and_city_1.Text + "\n----------\n";


                    for (int elem = 0; elem < location_names.Count; elem++)
                    {
                        out_put.Text += string.Format("{0,-40}{1,7}\n",location_names[elem], locations_count[elem]);
                    }

                }



                if (by_emp_1.Checked == true)
                {
                    //по кол-ву сотрудников

                    out_put.Text += by_emp_1.Text + "\n----------\n";

                    int min = 999999999;
                    string min_name = "";
                    int max = -1;
                    string max_name = "";
                    int avg_sum = 0;

                    foreach (Company cmp in companies_list)
                    {
                        avg_sum += cmp.number_of_employees;

                        if (cmp.number_of_employees > max)
                        {
                            max = cmp.number_of_employees;
                            max_name = cmp.name;
                        }

                        if (cmp.number_of_employees < min)
                        {
                            min = cmp.number_of_employees;
                            min_name = cmp.name;
                        }
                    }

                    avg_sum = avg_sum / companies_list.Count;

                    out_put.Text += string.Format("Минимальное кол-во сотрудников:\n{0,-25}{1,18} Чел.\n\n", min_name, min.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Максимальное кол-во сотрудников:\n{0,-25}{1,18} Чел.\n\n", max_name, max.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Среднее кол-во сотрудников:{0,16} Чел.",avg_sum.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                }




                if (by_dest_p_1.Checked == true)
                {
                    //по пунктам назначения с уч. города

                    List<string> destination_names = new List<string>();    //содержит названия стран и городов
                    List<int> destination_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                    foreach (Company cmp in companies_list)
                    {
                        foreach (string dest in cmp.destination_points)
                        {
                            if (destination_names.IndexOf(dest) == -1)
                            {
                                destination_names.Add(dest);
                                destination_count.Add(0);
                            }
                        }
                    }


                    foreach (Company cmp in companies_list)
                    {
                        foreach (string dest in cmp.destination_points)
                        {
                            destination_count[destination_names.IndexOf(dest)] += 1;
                        }
                    }

                    out_put.Text += by_dest_p_1.Text + "\n----------\n";


                    for (int elem = 0; elem < destination_names.Count; elem++)
                    {
                        out_put.Text += String.Format("{0,-35}{1,5}\n", destination_names[elem], destination_count[elem]);
                    }

                }



                if (by_pop_model_1.Checked == true)
                {
                    //по моделям самолетов

                    List<string> planes_names = new List<string>();    //содержит названия моделей
                    List<int> planes_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                    foreach (Company cmp in companies_list)
                    {
                        foreach (Plane plane in cmp.planes)
                        {
                            if (planes_names.IndexOf(plane.name) == -1)
                            {
                                planes_names.Add(plane.name);
                                planes_count.Add(0);
                            }
                        }
                    }


                    foreach (Company cmp in companies_list)
                    {
                        foreach (Plane plane in cmp.planes)
                        {
                            planes_count[planes_names.IndexOf(plane.name)] += 1;
                        }
                    }

                    out_put.Text += by_pop_model_1.Text + "\n----------\n";


                    for (int elem = 0; elem < planes_names.Count; elem++)
                    {
                        out_put.Text += String.Format("{0,-24}{1,15}\n", planes_names[elem], planes_count[elem]);
                    }

                }


                if (by_model_type_1.Checked == true)
                {
                    //по типам самолетов

                    int type_a = 0;
                    int type_b = 0;

                    foreach (Company cmp in companies_list)
                    {
                        foreach (Plane plane in cmp.planes)
                        {
                            if (plane.type == "Пассажирский")
                            {
                                type_a += 1;
                            } else
                            {
                                type_b += 1;
                            }
                        }
                    }

                    out_put.Text += by_model_type_1.Text + "\n----------\n";

                    out_put.Text += string.Format("Пассажирский:{0,25}\n",type_a.ToString());
                    out_put.Text += string.Format("Грузовой:{0,29}\n", type_b.ToString());
                }


                if (by_model_price.Checked == true)
                {
                    //по цене модели самолета

                    long max = -1;
                    long min = 999999999999999999;
                    string min_name = "";
                    string max_name = "";
                    long avg_count = 0;
                    long total_planes = 0;

                    foreach (Company cmp in companies_list)
                    {
                        foreach (Plane plane in cmp.planes)
                        {
                            avg_count += plane.cost;
                            total_planes += 1;
                            if (plane.cost > max)
                            {
                                max = plane.cost;
                                max_name = plane.name;
                            }

                            if (plane.cost < min)
                            {
                                min = plane.cost;
                                min_name = plane.name;
                            }
                        }
                    }

                    out_put.Text += by_model_price.Text + "\n----------\n";

                    avg_count = avg_count / total_planes;

                    out_put.Text += string.Format("Самая дешевая модель:\n{0,-24}{1,20} Руб.\n\n", min_name, min.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Самая дорогая модель:\n{0,-24}{1,20} Руб.\n\n", max_name, max.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Средняя стоимость самолета:\n{0,25} Руб.\n\n", avg_count.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                }


            } else
            {
                //ПО КАЖДОЙ ОТДЕЛЬНО тип 2

                out_put.Text += "Сформирован по каждой отдельной компании.\n----------\n";

                if (by_price_2.Checked == true)
                {
                    //по цене

                    out_put.Text += by_price_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        out_put.Text += string.Format("{0,-24}{1,20} Руб.\n",cmp.name, cmp.cost.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

                if (by_emp_2.Checked == true)
                {
                    //по кол-ву сотрудников

                    out_put.Text += by_emp_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        out_put.Text += string.Format("{0,-24}{1,20} Чел.\n", cmp.name, cmp.number_of_employees.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

                if (by_plane_type_2.Checked == true)
                {
                    //по типу самолетов

                    out_put.Text += by_plane_type_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        int type_a = 0;
                        int type_b = 0;

                        foreach (Plane plane in cmp.planes)
                        {
                            if (plane.type == "Пассажирский")
                            {
                                type_a += plane.count;
                            } else
                            {
                                type_b += plane.count;
                            }
                        }

                        out_put.Text += string.Format("{0,-25}\n\tПассажирских:{1,15}\n\tГрузовых:{2,19}\n\n",cmp.name,type_a.ToString(),type_b.ToString());
                    }
                }


                if (by_plane_cost_2.Checked == true)
                {
                    //средняя стоим. самолета

                    out_put.Text += by_plane_cost_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        long avg_cost = 0;

                        foreach (Plane plane in cmp.planes)
                        {
                            avg_cost += plane.cost;
                        }

                        if (cmp.planes.Count != 0)
                        {
                            avg_cost = avg_cost / cmp.planes.Count;
                        } else
                        {
                            avg_cost = 0;
                        }
                        

                        out_put.Text += string.Format("{0,-24}{1,20} Руб.\n",cmp.name,avg_cost.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

                if (by_total_count_plane_2.Checked == true)
                {
                    //всего экз. самолетов

                    out_put.Text += by_total_count_plane_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        long total_planes = 0;

                        foreach (Plane plane in cmp.planes)
                        {
                            total_planes += plane.count;
                        }

                        out_put.Text += string.Format("{0,-24}{1,20}\n", cmp.name, total_planes.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }


                if (by_avg_distance_2.Checked == true)
                {
                    //средняя дистанция перелета

                    out_put.Text += by_avg_distance_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        int avg_distance = 0;

                        foreach (Plane plane in cmp.planes)
                        {
                            avg_distance += plane.distance;
                        }

                        if (cmp.planes.Count != 0)
                        {
                            avg_distance = avg_distance / cmp.planes.Count;
                        } else
                        {
                            avg_distance = 0;
                        }
                        

                        out_put.Text += string.Format("{0,-24}{1,20} Км\n",cmp.name,avg_distance.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

            }

            //общий конец для всех типов отчетов

            out_put.Text += String.Format("\n\n\nВсего компаний в базе:{0,18}",companies_list.Count.ToString());
        }

        private void build_chart_Click(object sender, EventArgs e)
        {
            //ВИЗУАЛИЗАЦИЯ вкладка 2 (круговая диаграмма)

            if (companies_list.Count == 0)
            {
                MessageBox.Show("В базе нет данных. Строить визуализацию бессмысленно.","Визуализация по пустым данным?");
                return;
            }


            //очистка диаграммы
            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.Series.Add("data");


            if (price_diag.Checked == true)
            {
                //цены на компании

                chart1.Titles.Add(price_diag.Text);
                chart1.Titles[0].Font = new Font("Utopia", 16);

                List<long> y = new List<long>();
                List<string> x = new List<string>();

                foreach (Company cmp in companies_list)
                {
                    y.Add(cmp.cost);
                    x.Add(cmp.name);
                }

                chart1.Series[0].Points.DataBindXY(x, y);
                
                
            }


            if (emp_diag.Checked == true)
            {
                //кол-во сотрудников

                chart1.Titles.Add(emp_diag.Text);
                chart1.Titles[0].Font = new Font("Utopia", 16);

                List<int> y = new List<int>();
                List<string> x = new List<string>();

                foreach (Company cmp in companies_list)
                {
                    y.Add(cmp.number_of_employees);
                    x.Add(cmp.name);
                }

                chart1.Series[0].Points.DataBindXY(x, y);


            }

            if (country_diag.Checked == true)
            {
                //располржение по странам

                chart1.Titles.Add(country_diag.Text);
                chart1.Titles[0].Font = new Font("Utopia", 16);

                List<string> country_names = new List<string>();    //содержит названия стран
                List<int> country_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                foreach (Company cmp in companies_list)
                {
                    if (country_names.IndexOf(cmp.location.Split(',')[1].Trim(' ')) == -1)
                    {
                        country_names.Add(cmp.location.Split(',')[1].Trim(' '));
                        country_count.Add(0);
                    }
                }


                foreach (Company cmp in companies_list)
                {
                    country_count[country_names.IndexOf(cmp.location.Split(',')[1].Trim(' '))] += 1;
                }


                chart1.Series[0].Points.DataBindXY(country_names, country_count);
            }


            if (by_country_and_city_diag.Checked == true)
            {
                //расположение по странам и городам

                chart1.Titles.Add(by_country_and_city_diag.Text);
                chart1.Titles[0].Font = new Font("Utopia", 16);

                List<string> location_names = new List<string>();    //содержит названия стран и городов
                List<int> locations_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                foreach (Company cmp in companies_list)
                {
                    if (location_names.IndexOf(cmp.location) == -1)
                    {
                        location_names.Add(cmp.location);
                        locations_count.Add(0);
                    }
                }


                foreach (Company cmp in companies_list)
                {
                    locations_count[location_names.IndexOf(cmp.location)] += 1;
                }


                chart1.Series[0].Points.DataBindXY(location_names, locations_count);
            }



            if (country_dest_diag.Checked == true)
            {
                //пункты назначения - страны

                chart1.Titles.Add(country_dest_diag.Text);
                chart1.Titles[0].Font = new Font("Utopia", 16);

                List<string> destination_names = new List<string>();    //содержит названия стран
                List<int> destination_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                foreach (Company cmp in companies_list)
                {
                    foreach (string dest in cmp.destination_points)
                    {
                        if (destination_names.IndexOf(dest.Split(',')[1].Trim(' ')) == -1)
                        {
                            destination_names.Add(dest.Split(',')[1].Trim(' '));
                            destination_count.Add(0);
                        }
                    }
                }


                foreach (Company cmp in companies_list)
                {
                    foreach (string dest in cmp.destination_points)
                    {
                        destination_count[destination_names.IndexOf(dest.Split(',')[1].Trim(' '))] += 1;
                    }
                }


                chart1.Series[0].Points.DataBindXY(destination_names, destination_count);
            }


            if (country_and_city_dest_diag.Checked == true)
            {
                //пункты назначения - страны и города

                chart1.Titles.Add(country_and_city_dest_diag.Text);
                chart1.Titles[0].Font = new Font("Utopia", 16);

                List<string> destination_names = new List<string>();    //содержит названия стран
                List<int> destination_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                foreach (Company cmp in companies_list)
                {
                    foreach (string dest in cmp.destination_points)
                    {
                        if (destination_names.IndexOf(dest) == -1)
                        {
                            destination_names.Add(dest);
                            destination_count.Add(0);
                        }
                    }
                }


                foreach (Company cmp in companies_list)
                {
                    foreach (string dest in cmp.destination_points)
                    {
                        destination_count[destination_names.IndexOf(dest)] += 1;
                    }
                }


                chart1.Series[0].Points.DataBindXY(destination_names, destination_count);
            }


            if (plane_model_diag.Checked == true)
            {
                //модели самолетов

                chart1.Titles.Add(plane_model_diag.Text);
                chart1.Titles[0].Font = new Font("Utopia", 16);

                List<string> planes_names = new List<string>();    //содержит названия моделей
                List<int> planes_count = new List<int>();          //содержит кол-во совпадений - соответств. по индексу

                foreach (Company cmp in companies_list)
                {
                    foreach (Plane plane in cmp.planes)
                    {
                        if (planes_names.IndexOf(plane.name) == -1)
                        {
                            planes_names.Add(plane.name);
                            planes_count.Add(0);
                        }
                    }
                }


                foreach (Company cmp in companies_list)
                {
                    foreach (Plane plane in cmp.planes)
                    {
                        planes_count[planes_names.IndexOf(plane.name)] += 1;
                    }
                }

                chart1.Series[0].Points.DataBindXY(planes_names, planes_count);
            }


            //тип диаграммы всегда один - круговая
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //подписи в качестве значений?
            if (label_is_val.Checked == true)
            {
                chart1.Series[0].IsValueShownAsLabel = true;
            }
            else
            {
                chart1.Series[0].IsValueShownAsLabel = false;
            }


            //показывать ли подписи?
            if (show_labels.Checked == false)
            {
                chart1.Series[0]["PieLabelStyle"] = "Disabled";

            }
            else
            {

            }

            //использовать 3д?
            if (use_3d.Checked == true)
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            } else
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        private void show_labels_CheckedChanged(object sender, EventArgs e)
        {
            //включен ли переключатель подписей в качестве значений
            label_is_val.Enabled = show_labels.Checked;
        }
    }
}
