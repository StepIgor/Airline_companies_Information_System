using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace inf_system_airline_companies
{
    public partial class visualisation : Form
    {
        public visualisation(List<Company> cmp_list)
        {
            InitializeComponent();

            this.companies_list = cmp_list;
        }

        List<Company> companies_list;

        private void visualisation_Load(object sender, EventArgs e)
        {

        }

        private void type_1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = type_1.Checked;
        }

        private void type_2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = type_2.Checked;
        }

        private void generate_text_Click(object sender, EventArgs e)
        {
            out_put.Text = "Отчёт от " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n";

            if (type_1.Checked == true)
            {
                //ПО ВСЕМ В СОВОКУПНОСТИ

                out_put.Text += "Сформирован по всем компаниям в базе в совокупности.\n----------\n";

                if (by_type_1.Checked == true)
                {
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
                    out_put.Text += by_price_1.Text + "\n----------\n";

                    long min = 999999999999999;
                    string min_name = "";
                    long max = -1;
                    string max_name = "";
                    long avg_sum = 0;

                    foreach (Company cmp in companies_list)
                    {
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

                    avg_sum = avg_sum / companies_list.Count;

                    out_put.Text += string.Format("Самая дешевая компания:\n{0,-15}{1,20} Руб.\n\n", min_name, min.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Самая дорогая компания:\n{0,-15}{1,20} Руб.\n\n", max_name, max.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Средняя стоимость компании:\n{0,25} Руб.", avg_sum.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                }


                if (by_loc_1.Checked == true)
                {
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
                    List<string> location_names = new List<string>();    //содержит названия стран
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
                        out_put.Text += string.Format("{0,-35}{1,5}\n",location_names[elem], locations_count[elem]);
                    }

                }



                if (by_emp_1.Checked == true)
                {
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

                    out_put.Text += string.Format("Минимальное кол-во сотрудников:\n{0,-25}{1,10} Чел.\n\n", min_name, min.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Максимальное кол-во сотрудников:\n{0,-25}{1,10} Чел.\n\n", max_name, max.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Среднее кол-во сотрудников:{0,8} Чел.",avg_sum.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                }




                if (by_dest_p_1.Checked == true)
                {
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
                        out_put.Text += String.Format("{0,-25}{1,15}\n", planes_names[elem], planes_count[elem]);
                    }

                }


                if (by_model_type_1.Checked == true)
                {
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

                    out_put.Text += string.Format("Самая дешевая модель:\n{0,-15}{1,20} Руб.\n\n", min_name, min.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Самая дорогая модель:\n{0,-15}{1,20} Руб.\n\n", max_name, max.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    out_put.Text += string.Format("Средняя стоимость самолета:\n{0,25} Руб.\n\n", avg_count.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                }


            } else
            {
                //ПО КАЖДОЙ ОТДЕЛЬНО

                out_put.Text += "Сформирован по каждой отдельной компании.\n----------\n";

                if (by_price_2.Checked == true)
                {
                    out_put.Text += by_price_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        out_put.Text += string.Format("{0,-15}{1,20} Руб.\n",cmp.name, cmp.cost.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

                if (by_emp_2.Checked == true)
                {
                    out_put.Text += by_emp_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        out_put.Text += string.Format("{0,-15}{1,20} Чел.\n", cmp.name, cmp.number_of_employees.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

                if (by_plane_type_2.Checked == true)
                {
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
                    out_put.Text += by_plane_cost_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        long avg_cost = 0;

                        foreach (Plane plane in cmp.planes)
                        {
                            avg_cost += plane.cost;
                        }

                        avg_cost = avg_cost / cmp.planes.Count;

                        out_put.Text += string.Format("{0,-15}{1,20} Руб.\n",cmp.name,avg_cost.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

                if (by_total_count_plane_2.Checked == true)
                {
                    out_put.Text += by_total_count_plane_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        long total_planes = 0;

                        foreach (Plane plane in cmp.planes)
                        {
                            total_planes += plane.count;
                        }

                        out_put.Text += string.Format("{0,-15}{1,20}\n", cmp.name, total_planes.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }


                if (by_avg_distance_2.Checked == true)
                {
                    out_put.Text += by_avg_distance_2.Text + "\n----------\n";

                    foreach (Company cmp in companies_list)
                    {
                        int avg_distance = 0;

                        foreach (Plane plane in cmp.planes)
                        {
                            avg_distance += plane.distance;
                        }

                        avg_distance = avg_distance / cmp.planes.Count;

                        out_put.Text += string.Format("{0,-15}{1,20} Км\n",cmp.name,avg_distance.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")));
                    }
                }

            }

            out_put.Text += String.Format("\n\n\nВсего компаний в базе:{0,18}",companies_list.Count.ToString());
        }
    }
}
