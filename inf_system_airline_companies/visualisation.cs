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
                    out_put.Text += "Распределение по типам компаний\n----------\n";

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

                    out_put.Text += "Пассажирских:\t\t\t" + Convert.ToString(type_a) + "\n";
                    out_put.Text += "Грузовых:\t\t\t\t" + Convert.ToString(type_b) + "\n";
                    out_put.Text += "Смешанных:\t\t\t\t" + Convert.ToString(type_c) + "\n";

                }





            } else
            {
                //ПО КАЖДОЙ ОТДЕЛЬНО

                
            }

            out_put.Text += "\n\n\nВсего в базе компаний:\t\t" + companies_list.Count.ToString();
        }
    }
}
