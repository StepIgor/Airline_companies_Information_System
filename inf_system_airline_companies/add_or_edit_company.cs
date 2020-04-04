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
    public partial class add_or_edit_company : Form
    {
        public add_or_edit_company(List<Company> lst, DataGridView gridforcomp, BindingSource bndsrc, Boolean edit = false)
        {
            InitializeComponent();

            this.companies_list = lst; //список компаний
            this.gridforcomp = gridforcomp; //сетка компаний для обновления
            this.edit = edit; //запускаем ли мы форму для редактирования сущ. компании
            this.bndsrc = bndsrc; //обновление биндинга после окончания редактирования информации
        }

        List<Company> companies_list;
        public DataGridView gridforcomp;
        Boolean edit;
        BindingSource bndsrc;

        private void add_or_edit_company_Load(object sender, EventArgs e)
        {
            if (edit == true) //если форма запущена для редактирования
            {
                main_label.Text = "В этом окне происходит редактирование только самой основной информации. Остальные элементы можно изменить, зайдя в соответствующие разделы.";
                this.Text = "Изменить информацию о компании";
                add_now.Text = "Сохранить изменения";

                //заполнение полей имеющимися данными
                company_name.Text = companies_list[gridforcomp.SelectedRows[0].Index].name;
                company_full_name.Text = companies_list[gridforcomp.SelectedRows[0].Index].full_name;
                ceo_name.Text = companies_list[gridforcomp.SelectedRows[0].Index].ceo;
                type_of_comp.SelectedItem = companies_list[gridforcomp.SelectedRows[0].Index].type;
                country.Text = companies_list[gridforcomp.SelectedRows[0].Index].location.Split(',')[1].Trim(' ');
                city.Text = companies_list[gridforcomp.SelectedRows[0].Index].location.Split(',')[0];
                description.Text = companies_list[gridforcomp.SelectedRows[0].Index].description;
                website.Text = companies_list[gridforcomp.SelectedRows[0].Index].site;


                phone_num.Text = companies_list[gridforcomp.SelectedRows[0].Index].phone_number;

                monthCalendar1.MaxDate = DateTime.Now;
                monthCalendar1.SetDate(DateTime.Parse(companies_list[gridforcomp.SelectedRows[0].Index].year_of_foundation));


            } else {
                //если форма запущена для создания новой компании
                main_label.Text = "Введите основную информацию о новой компании. Остальные элементы можно добавить, зайдя в соответствующие разделы программы.";
                this.Text = "Добавить новую компанию";
                add_now.Text = "Добавить компанию";
                monthCalendar1.MaxDate = DateTime.Now;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //закрываем форму без изменений, если пользователь отменил редактирование
            this.Close();
        }

        private void add_now_Click(object sender, EventArgs e)
        {
            //БЛОК ПРОВЕРКИ ДАННЫХ

            if (company_name.Text.Length == 0 || company_name.Text.Length > 24)
            {
                MessageBox.Show("Название компании (неполное) должно быть до 24 символов.","Обратите внимание!");
                return;
            }

            if (company_full_name.Text.Length == 0 || company_full_name.Text.Length > 42)
            {
                MessageBox.Show("Полное название компании должно быть до 42 символов.", "Обратите внимание!");
                return;
            }

            if (!(ceo_name.Text.Length > 0 && ceo_name.Text.Length < 49 && (ceo_name.Text.Split(' ').Length == 2 || ceo_name.Text.Split(' ').Length == 3)))
            {
                MessageBox.Show("Сведения о директоре должны быть в форме \"Фамилия Имя\" или \"Фамилия Имя Отчество\" и не превышать длину в 48 символов.", "Обратите внимание!");
                return;
            }

            if (!(type_of_comp.Text == "Пассажирская" || type_of_comp.Text == "Грузовая" || type_of_comp.Text == "Смешанная"))
            {
                MessageBox.Show("Вы не выбрали тип компании.", "Обратите внимание!");
                return;
            }

            if (!(country.Text.Length > 0 && country.Text.Length < 33 && country.Text.IndexOf(',') == -1))
            {
                MessageBox.Show("Название страны должно быть по длине до 32 символов и не включать запятые.", "Обратите внимание!");
                return;
            }

            if (!(city.Text.Length > 0 && city.Text.Length < 33 && city.Text.IndexOf(',') == -1))
            {
                MessageBox.Show("Название города должно быть по длине до 32 символов и не включать запятые.", "Обратите внимание!");
                return;
            }

            if (!(description.Text.Length > 0 && description.Text.Length < 391))
            {
                MessageBox.Show("Краткое описание должно быть по длине от 1 до 390 символов.", "Обратите внимание!");
                return;
            }

            if (!(phone_num.Text.Length == 17))
            {
                MessageBox.Show("Номер телефона обязателен для ввода.", "Обратите внимание!");
                return;
            }

            if (!(website.Text.Length > 0 && website.Text.Length < 49 && website.Text.IndexOf("http://") == -1 && website.Text.IndexOf("https://") == -1 && website.Text.Split('.').Length >= 2))
            {
                MessageBox.Show("Адрес сайта должен быть длиной от 1 до 48 символов. Не нужно указывать протокол (http, https).", "Обратите внимание!");
                return;
            }

            if (edit == true)
            {
                //если редактируем существующую компанию
                //просто меняем элемент списка компаний по индексу
                companies_list[gridforcomp.SelectedRows[0].Index].name = company_name.Text;
                companies_list[gridforcomp.SelectedRows[0].Index].full_name = company_full_name.Text;
                companies_list[gridforcomp.SelectedRows[0].Index].ceo = ceo_name.Text;
                companies_list[gridforcomp.SelectedRows[0].Index].year_of_foundation = monthCalendar1.SelectionRange.Start.ToShortDateString();
                companies_list[gridforcomp.SelectedRows[0].Index].type = type_of_comp.Text;
                companies_list[gridforcomp.SelectedRows[0].Index].location = city.Text + ", " + country.Text;
                companies_list[gridforcomp.SelectedRows[0].Index].description = description.Text;
                companies_list[gridforcomp.SelectedRows[0].Index].phone_number = phone_num.Text;
                companies_list[gridforcomp.SelectedRows[0].Index].site = website.Text;

                
            } else
            {
                //если создаем компанию, то создаем объект, затем добавляем его в список
                Company new_comp = new Company(company_name.Text, company_full_name.Text, monthCalendar1.SelectionRange.Start.ToShortDateString(),"(не указано)","(не указано)", ceo_name.Text, type_of_comp.Text,0, city.Text + ", " + country.Text, description.Text,0, phone_num.Text, website.Text);
                new_comp.destination_points = new List<string>();
                companies_list.Add(new_comp);
                new_comp = null;
            }

            //обновляем биндинг, ставим флажок, что меняли данные (чтобы предупреждать пользователя о несохраненных изменениях)
            this.Close();
            Program.anything_was_changed = true;
            bndsrc.ResetBindings(false);
        }
    }
}
