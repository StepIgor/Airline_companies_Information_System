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
    }
}
