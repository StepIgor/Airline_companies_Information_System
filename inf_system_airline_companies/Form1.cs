using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace inf_system_airline_companies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Company[] companies;
        List<Company> companies_list;

        private void Form1_Load(object sender, EventArgs e)
        {

            XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

            using (FileStream fs = new FileStream(@"samples/sample.xml", FileMode.Open))
            {
                companies = (Company[])xmlsrl.Deserialize(fs);
            }

            companies_list = new List<Company>(companies);

            companyBindingSource.DataSource = companies_list;
        }

        private void gridforcomp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            del_comp_but.Enabled = true;
            edit_comp_but.Enabled = true;

            //Прячем подсказку и выводим заголовок синими буквами
            tipforfirstselection.Visible = false;
            details_company_name.Text = companies_list[gridforcomp.SelectedRows[0].Index].name;
            details_company_name.Visible = true;

            //Видимость полного названия
            details_full_name.Text = companies_list[gridforcomp.SelectedRows[0].Index].full_name;
            details_cat_full_name.Visible = true;
            details_full_name.Visible = true;

            //Видимость года основания
            details_year_of_found.Text = Convert.ToString(companies_list[gridforcomp.SelectedRows[0].Index].year_of_foundation) + " г.";
            details_year_of_found.Visible = true;
            details_cat_year.Visible = true;

            //Видимость директора
            details_ceo_name.Text = Convert.ToString(companies_list[gridforcomp.SelectedRows[0].Index].ceo);
            details_ceo_name.Visible = true;
            details_cat_ceo.Visible = true;

            //Видимость описания
            details_description.Text = companies_list[gridforcomp.SelectedRows[0].Index].description;
            details_description.Visible = true;
            details_cat_description.Visible = true;


            //Видимость телефона
            details_phone.Text = companies_list[gridforcomp.SelectedRows[0].Index].phone_number;
            details_phone.Visible = true;

            //Видимость сайта
            details_site.Text = companies_list[gridforcomp.SelectedRows[0].Index].site;
            details_site.Visible = true;


            //Видимость самолетов
            int details_planes_model_count = companies_list[gridforcomp.SelectedRows[0].Index].planes.Count;

            int details_planes_all_count = 0;

            for (int step = 0; step < companies_list[gridforcomp.SelectedRows[0].Index].planes.Count; step++)
            {
                details_planes_all_count += companies_list[gridforcomp.SelectedRows[0].Index].planes[step].count;
            }

            details_planes_count.Text = "моделей - " + Convert.ToString(details_planes_model_count) + "; всего - " + Convert.ToString(details_planes_all_count) + ";";
            details_planes_count.Visible = true;
            details_cat_planes_count.Visible = true;


            //видимость значков веба и телефона

            details_web_img.Visible = true;
            details_phone_img.Visible = true;

            //видимость кнопки открытия юридической информации

            details_open_law_info.Visible = true;

            details_open_planes_form.Visible = true;
        }

        private void hide_details_info()
        {
            del_comp_but.Enabled = false;
            edit_comp_but.Enabled = false;

            //Прячем подсказку и выводим заголовок синими буквами
            tipforfirstselection.Visible = true;
            details_company_name.Visible = false;

            //Видимость полного названия
            details_cat_full_name.Visible = false;
            details_full_name.Visible = false;

            //Видимость года основания
            details_year_of_found.Visible = false;
            details_cat_year.Visible = false;

            //Видимость директора
            details_ceo_name.Visible = false;
            details_cat_ceo.Visible = false;

            //Видимость описания
            details_description.Visible = false;
            details_cat_description.Visible = false;


            //Видимость телефона
            details_phone.Visible = false;

            //Видимость сайта
            details_site.Visible = false;

            details_planes_count.Visible = false;
            details_cat_planes_count.Visible = false;


            //видимость значков веба и телефона

            details_web_img.Visible = false;
            details_phone_img.Visible = false;

            //видимость кнопки открытия юридической информации

            details_open_law_info.Visible = false;

            details_open_planes_form.Visible = false;
        }

        private void details_open_law_info_Click(object sender, EventArgs e)
        {
            Form new_law_info_form = new law_information(companies_list, gridforcomp);

            new_law_info_form.Show();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about_form = new about_form();

            about_form.Show();
        }

        private void details_open_planes_form_Click(object sender, EventArgs e)
        {
            Form planes_if_comp_form = new planes_in_comp(companies_list, gridforcomp);

            planes_if_comp_form.Show();
        }

        private void del_comp_but_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить компанию?","Удалить",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                companies_list.Remove(companies_list[gridforcomp.SelectedRows[0].Index]);
                companyBindingSource.ResetBindings(false);
                hide_details_info();
            }
        }

        private void edit_comp_but_Click(object sender, EventArgs e)
        {
            add_or_edit_company add_or_edit = new add_or_edit_company(companies_list, gridforcomp, companyBindingSource, true);
            add_or_edit.ShowDialog();
            
        }

        private void add_comp_but_Click(object sender, EventArgs e)
        {
            add_or_edit_company add_or_edit = new add_or_edit_company(companies_list, gridforcomp, companyBindingSource, false);
            add_or_edit.ShowDialog();
        }
    }

    public class Plane
    {
        public string name { get; set; }
        public int count { get; set; }
        public long cost;
        public int speed;
        public string type { get; set; }
        public int volume;
        public int distance;
        public int payload_capacity;

        public Plane()
        {

        }

        public Plane(string name, int count, int speed, long cost, string type, int volume, int distance, int payload_capacity)
        {
            this.name = name;
            this.count = count;
            this.speed = speed;
            this.cost = cost;
            this.type = type;
            this.volume = volume;
            this.distance = distance;
            this.payload_capacity = payload_capacity;
        }

    }


    public class Company
    {
        public string name { get; set; }
        public string full_name { get; set; }
        public string year_of_foundation { get; set; }
        public string tax_number { get; set; }
        public string certificate { get; set; }
        public string ceo { get; set; }
        public string type { get; set; }
        public long cost { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public int number_of_employees { get; set; }
        public string phone_number { get; set; }
        public string site { get; set; }
        public List<String> destination_points { get; set; }
        public List<Plane> planes = new List<Plane>();

        public Company()
        {

        }

        public Company(string name, string full_name, string year_of_foundation, string tax_number, string certificate, string ceo, string type, long cost, string location, string description, int number_of_employees, string phone_number, string site)
        {
            this.name = name;
            this.full_name = full_name;
            this.year_of_foundation = year_of_foundation;
            this.tax_number = tax_number;
            this.certificate = certificate;
            this.ceo = ceo;
            this.type = type;
            this.cost = cost;
            this.location = location;
            this.description = description;
            this.number_of_employees = number_of_employees;
            this.phone_number = phone_number;
            this.site = site;
        }

    }


}
