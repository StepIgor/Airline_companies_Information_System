using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;
using System.Drawing;
using System.Diagnostics;

namespace inf_system_airline_companies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Company[] companies;
        public List<Company> companies_list;
        sort_windows sort_window;
        public filter_windows filter_window;

        public bool filter_was_used = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                if (Program.opened_file == "<sample>")
                {
                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(@"samples/sample.xml", FileMode.Open))
                    {
                        companies = (Company[])xmlsrl.Deserialize(fs);
                    }

                    companies_list = new List<Company>(companies);

                    companyBindingSource.DataSource = companies_list;
                }
                else if (Program.opened_file == "<new>")
                {
                    companies_list = new List<Company>();

                    companyBindingSource.DataSource = companies_list;
                }
                else
                {
                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(Program.opened_file, FileMode.Open))
                    {
                        companies = (Company[])xmlsrl.Deserialize(fs);
                    }

                    companies_list = new List<Company>(companies);

                    companyBindingSource.DataSource = companies_list;

                    if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                    {
                        Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                    }

                    Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
                }

                refresh_title();

                if (Program.is_admin == false)
                {
                    add_comp_but.Enabled = false;
                }

                sort_window = new sort_windows(companies_list, companyBindingSource, gridforcomp);

                filter_window = new filter_windows(companies_list, gridforcomp);

            } catch (Exception)
            {
                MessageBox.Show("При открытии файла произошла ошибка. Вероятно, данные повреждены.", "Ошибка!");
                this.Close();
            }

        }

        private void gridforcomp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (companies_list.Count == 0 || gridforcomp.SelectedRows[0].Index == -1)
            {
                return;
            }


            if (Program.is_admin == true)
            {
                del_comp_but.Enabled = true;
                edit_comp_but.Enabled = true;
            }
            

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

        public void hide_details_info()
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

            new_law_info_form.ShowDialog();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about_form = new about_form();

            about_form.ShowDialog();
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
                Program.anything_was_changed = true;
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

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
                if (save_as_dialog.ShowDialog() != DialogResult.Cancel)
                {
                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(save_as_dialog.FileName, FileMode.Create))
                    {
                        xmlsrl.Serialize(fs, companies_list.ToArray());
                    }

                    Program.opened_file = save_as_dialog.FileName;
                    refresh_title();
                    Program.anything_was_changed = false;
                }
                else
                {
                    return;
                }
            } catch (Exception)
            {
                MessageBox.Show("Ошибка при записи данных.");
                return;
            }
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.anything_was_changed == true)
                {
                    if (MessageBox.Show("Имеются несохраненные изменения. Продолжить без сохранения?", "Вы уверены?", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                if (load_file_dialog.ShowDialog() != DialogResult.Cancel)
                {
                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(load_file_dialog.FileName, FileMode.Open))
                    {
                        companies = (Company[])xmlsrl.Deserialize(fs);
                    }

                    companies_list = new List<Company>(companies);

                    companyBindingSource.DataSource = companies_list;

                    companyBindingSource.ResetBindings(false);

                    Program.opened_file = load_file_dialog.FileName;

                    refresh_title();
                    hide_details_info();
                    cancel_filter_interface();

                    Program.anything_was_changed = false;


                    if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                    {
                        Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                    }

                    Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
                }

            } catch (Exception)
            {
                MessageBox.Show("Ошибка при чтении данных.");
                return;
            }
        }

        private void refresh_title()
        {
            if (Program.opened_file == "<sample>")
            {
                this.Text = "ИСС \"Авиатранспортные компании\" - Образец";
            } else if (Program.opened_file == "<new>")
            {
                this.Text = "ИСС \"Авиатранспортные компании\" - Новый файл";
            } else
            {
                this.Text = "ИСС \"Авиатранспортные компании\" - " + Program.opened_file;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.opened_file == "<sample>")
            {
                MessageBox.Show("Файл-образец защищен от записи. Используйте пункт \"Сохранить как\".","Предупреждение");
                return;
            } if (Program.opened_file == "<new>")
            {
                сохранитьКакToolStripMenuItem_Click(сохранитьКакToolStripMenuItem, null);
                return;
            } else
            {
                try
                {
                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(Program.opened_file, FileMode.Open))
                    {
                        xmlsrl.Serialize(fs, companies_list.ToArray());
                    }

                    Program.anything_was_changed = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при записи данных.");
                    return;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.anything_was_changed == true)
            {
                if (MessageBox.Show("Имеются несохраненные изменения. Вы уверены, что хотите закрыть программу без сохранения?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            if (Program.opened_file != "<sample>" && Program.opened_file != "<new>")
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                }

                Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
            }
        }

        private void details_phone_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(details_phone.Text);
        }

        private void details_site_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(details_site.Text);
        }

        private void открытьФайлобразецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.anything_was_changed == true)
            {
                if (MessageBox.Show("Имеются несохраненные изменения. Продолжить без сохранения?","Предупреждение",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            if (Program.opened_file != "<sample>" && Program.opened_file != "<new>")
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                }

                Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
            }

            try
            {
                XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                using (FileStream fs = new FileStream(@"samples/sample.xml", FileMode.Open))
                {
                    companies = (Company[])xmlsrl.Deserialize(fs);
                }

                companies_list = new List<Company>(companies);

                companyBindingSource.DataSource = companies_list;

                companyBindingSource.ResetBindings(false);

                Program.opened_file = "<sample>";

                refresh_title();
                hide_details_info();
                cancel_filter_interface();

                Program.anything_was_changed = false;

            } catch (Exception)
            {
                MessageBox.Show("Возникла ошибка при чтении файла-образца. Проверьте его наличие и целостность.", "Ошибка!");
                return;
            }

            
        }

        private void создатьНовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.is_admin == false)
            {
                MessageBox.Show("Создание нового файла в режиме пользователя невозможно.", "Отказано в доступе");
                return;
            }

            if (Program.anything_was_changed == true)
            {
                if (MessageBox.Show("Имеются несохраненные изменения. Продолжить без сохранения?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            if (Program.opened_file != "<sample>" && Program.opened_file != "<new>")
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                }

                Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
            }

            Program.anything_was_changed = false;

            companies_list.Clear();

            companyBindingSource.ResetBindings(false);

            Program.opened_file = "<new>";

            refresh_title();
            cancel_filter_interface();
            hide_details_info();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (details_planes_count.Visible == true)
            {
                int details_planes_model_count = companies_list[gridforcomp.SelectedRows[0].Index].planes.Count;

                int details_planes_all_count = 0;

                for (int step = 0; step < companies_list[gridforcomp.SelectedRows[0].Index].planes.Count; step++)
                {
                    details_planes_all_count += companies_list[gridforcomp.SelectedRows[0].Index].planes[step].count;
                }

                details_planes_count.Text = "моделей - " + Convert.ToString(details_planes_model_count) + "; всего - " + Convert.ToString(details_planes_all_count) + ";";
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sort_but_Click(object sender, EventArgs e)
        {
            
            sort_window.parent_form = this;
            sort_window.companies_list = companies_list;
            sort_window.ShowDialog();
            
        }

        private void filter_but_Click(object sender, EventArgs e)
        {
            filter_window.parent_window = this;
            filter_window.companyBindingSource = companyBindingSource;
            filter_window.companies_list = companies_list;
            filter_was_used = true;
            filter_window.ShowDialog();
        }


        private void cancel_filter_interface()
        {
            filter_but.FlatStyle = FlatStyle.System;
            filter_but.BackColor = SystemColors.Control;

            filter_window.use_filter_checkbox.Checked = false;
        }

        private void visual_but_Click(object sender, EventArgs e)
        {
            visualisation new_visual_windows = new visualisation(companies_list);

            new_visual_windows.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Windows\System32\notepad.exe", "Help.txt");
            } catch (Exception)
            {
                MessageBox.Show("Ошибка при открытии файла со справкой.", "Ошибка");
            }
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
