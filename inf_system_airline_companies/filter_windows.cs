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
