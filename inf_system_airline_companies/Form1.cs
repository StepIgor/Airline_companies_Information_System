using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization; //де-  и сериализация объектов
using System.IO; //проверка наличия файлов
using Microsoft.Win32; //копировать сайт и телефон в буфер обмена + работа с реестром
using System.Drawing; //кнопка фильтра (её цвет)
using System.Diagnostics; //запустить блокнот с файлом Help.txt

namespace inf_system_airline_companies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Company[] companies; //промежуточная стадия для десериализации
        public List<Company> companies_list; //основа программы - список компаний из файла
        sort_windows sort_window; //окно сортировки (объявляем сразу, чтобы потом прятать, сохраняя параметры пользователя)
        public filter_windows filter_window; //окно фильтра (объявляем сразу, чтобы потом прятать, сохраняя параметры пользователя)

        public bool filter_was_used = false; //использовали ли мы фильтр хотя бы раз? понадобится для правильного взаимодействия сортировки и фильтра

        private void Form1_Load(object sender, EventArgs e)
        {
            //при запуске формы пытаемся считать файл, путь которого указан в глобальной переменной, значение которой было установлено в предыдущей форме

            try
            {
                if (Program.opened_file == @"samples/sample.xml")
                {
                    //если это образец

                    Program.opened_file = "<sample>";

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
                    //если это новый файл (пустой)

                    companies_list = new List<Company>();

                    companyBindingSource.DataSource = companies_list;
                }
                else
                {
                    //если ранее сохраненный файл

                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(Program.opened_file, FileMode.Open))
                    {
                        companies = (Company[])xmlsrl.Deserialize(fs);
                    }

                    companies_list = new List<Company>(companies);

                    companyBindingSource.DataSource = companies_list;

                    //сохраняем путь в реестр, чтобы при след. запуске программы предложить пользователю продолжить с ним работу

                    if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                    {
                        //создаем ветку
                        Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                    }

                    //устанавливаем ключ - значение
                    Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
                }

                //обновляем заголовок окна (там указан путь к файлу для удобства пользователя)
                refresh_title();

                //глобальная переменная (мы администратор?)
                if (Program.is_admin == false)
                {
                    add_comp_but.Enabled = false;
                }

                //создаются окна сортировки и фильтра (потом просто прячутся, чтобы сохранять параметры)

                sort_window = new sort_windows(companies_list, companyBindingSource, gridforcomp);

                filter_window = new filter_windows(companies_list, gridforcomp);

            } catch (Exception)
            {
                //если что-то пошло не так. Этот код не совсем полезен, т.к. есть уже предварительная проверка файла на предыдущей форме
                MessageBox.Show("При открытии файла произошла ошибка. Вероятно, данные повреждены.", "Ошибка!");
                this.Close();
            }

        }

        public void gridforcomp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //если выбираем какую-то компанию из списка (кликом)


            //проверяем, не пуст ли список и есть ли выделение строки
            if (companies_list.Count == 0 || gridforcomp.SelectedRows[0].Index == -1)
            {
                return;
            }

            //проверка прав администратора
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

            //подсчет сделан не только по моделям, но и по экземплярам
            details_planes_count.Text = "М - " + Convert.ToString(details_planes_model_count) + "; Э - " + Convert.ToString(details_planes_all_count) + ";";
            details_planes_count.Visible = true;
            details_cat_planes_count.Visible = true;


            //видимость значков веба и телефона

            details_web_img.Visible = true;
            details_phone_img.Visible = true;

            //видимость кнопки открытия юридической информации и пунктов назначения

            details_open_law_info.Visible = true;

            details_open_planes_form.Visible = true;
        }

        public void hide_details_info()
        {
            //если нужно спрятать информацию о выделенной компании (после фильтра, сортировки, когда выделение строки может быть снято)
            //информация отображается в правой части окна

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
            //открываем окно с юридической информацией и пунктами назначения

            Form new_law_info_form = new law_information(companies_list, gridforcomp);

            new_law_info_form.ShowDialog();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //окно О программе

            Form about_form = new about_form();

            about_form.ShowDialog();
        }

        private void details_open_planes_form_Click(object sender, EventArgs e)
        {
            //открыть окно с самолетами в компании

            Form planes_if_comp_form = new planes_in_comp(companies_list, gridforcomp);

            planes_if_comp_form.Show();
        }

        private void del_comp_but_Click(object sender, EventArgs e)
        {
            //удаление компании из списка с предварительным вопросом
            if (MessageBox.Show("Вы действительно хотите удалить компанию?","Удалить",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                companies_list.Remove(companies_list[gridforcomp.SelectedRows[0].Index]);
                companyBindingSource.ResetBindings(false);
                //прячем информацию об уже удаленной компании из правой части окна
                hide_details_info();
                //активируем флаг наличия несохраненных изменений
                Program.anything_was_changed = true;
            }
        }

        private void edit_comp_but_Click(object sender, EventArgs e)
        {
            //редактировать компанию

            add_or_edit_company add_or_edit = new add_or_edit_company(companies_list, gridforcomp, companyBindingSource, true);
            add_or_edit.parent_form = this;
            add_or_edit.ShowDialog();
            
        }

        private void add_comp_but_Click(object sender, EventArgs e)
        {
            //добавить новую компанию

            add_or_edit_company add_or_edit = new add_or_edit_company(companies_list, gridforcomp, companyBindingSource, false);
            add_or_edit.ShowDialog();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //процесс сохранения данных пользователя в файл (сериализация)
            //предварительно проверяем, есть ли доступ на запись

            try
            {
                if (save_as_dialog.ShowDialog() != DialogResult.Cancel)
                {
                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(save_as_dialog.FileName, FileMode.Create))
                    {
                        xmlsrl.Serialize(fs, companies_list.ToArray());
                    }

                    Program.opened_file = save_as_dialog.FileName;
                    //обновляем заголовок с новым путем для файла
                    refresh_title();
                    //сбрасываем флаг наличия несохр. изменений
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
            //открыть существующий файл
            //проверяется доступ на чтение и исправность файла

            try
            {
                if (Program.anything_was_changed == true)
                {
                    //если флаг несохраненных изменений активирован, то предупреждаем пользователя
                    //что он не все сохранил

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

                    //обновляем путь, заголовок окна, прячем информацию о старых данных, сбрасываем флаг наличия несохр. изменений

                    Program.opened_file = load_file_dialog.FileName;

                    refresh_title();
                    hide_details_info();
                    //отменяем примененный фильтр
                    cancel_filter_interface();

                    Program.anything_was_changed = false;

                    //обновляем информацию о последнем открытом файле в реестре

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
            //функция просто обновляет путь в заголовке окна (для удобства пользователя)

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
            //сохранение изменений в текущий файл

            if (Program.opened_file == "<sample>")
            {
                //просто так образец нельзя переписать
                MessageBox.Show("Файл-образец защищен от записи. Используйте пункт \"Сохранить как\".","Предупреждение");
                return;
            } if (Program.opened_file == "<new>")
            {
                //если файл новый, то нужно получить новый путь
                сохранитьКакToolStripMenuItem_Click(сохранитьКакToolStripMenuItem, null);
                return;
            } else
            {
                //простая сериализация с проверкой доступа на запись

                try
                {
                    XmlSerializer xmlsrl = new XmlSerializer(typeof(Company[]));

                    using (FileStream fs = new FileStream(Program.opened_file, FileMode.Open))
                    {
                        xmlsrl.Serialize(fs, companies_list.ToArray());
                    }

                    //сброс флага наличия несохр. изменений
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
            //если закрываем форму (а значит и программу)

            //предупреждаем пользователя, если есть несохраненные изменения
            if (Program.anything_was_changed == true)
            {
                if (MessageBox.Show("Имеются несохраненные изменения. Вы уверены, что хотите закрыть программу без сохранения?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            //если открыт свой файл, то сохраняем его в реестр, как последний редактируемый

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
            //копируем номер телефона в буфер
            Clipboard.SetText(details_phone.Text);
        }

        private void details_site_Click(object sender, EventArgs e)
        {
            //копируем сайт в буфер
            Clipboard.SetText(details_site.Text);
        }

        private void открытьФайлобразецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем файл-образец

            //предупреждаем пользователя, если он не сохранил последние изменения
            if (Program.anything_was_changed == true)
            {
                if (MessageBox.Show("Имеются несохраненные изменения. Продолжить без сохранения?","Предупреждение",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            //сохраняем в реестр последний редактируемый файл

            if (Program.opened_file != "<sample>" && Program.opened_file != "<new>")
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                }

                Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
            }

            //пытаемся открыть образец, проверяя, не испорчен ли он

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

                //если все прошло успешно, обновляем заголовок окна, прячем старую информацию, отключаем примененный фильтр
                //сбрасываем флаг наличия изменений (несохранен.)

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
            //если создаем новый файл (пустой список)

            //создать новый файл может только админ

            if (Program.is_admin == false)
            {
                MessageBox.Show("Создание нового файла в режиме пользователя невозможно.", "Отказано в доступе");
                return;
            }

            //уведомляем пользователя, если он не сохранил старый файл

            if (Program.anything_was_changed == true)
            {
                if (MessageBox.Show("Имеются несохраненные изменения. Продолжить без сохранения?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            //запоминаем старый файл в реестре

            if (Program.opened_file != "<sample>" && Program.opened_file != "<new>")
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System") == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\Airline_Inf_System", true);
                }

                Registry.CurrentUser.OpenSubKey(@"Software\Airline_Inf_System", true).SetValue("last_opened", Program.opened_file);
            }

            //сбрасываем наличие изменений, чистим список. Обновляем биндинг, обновляем путь. Обновлям заголовок окна, отменяем фильтр и прячем старую информацию

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
            //сфокусировавшись на форме, нужно обновить информацию о количестве самолетов, так как пользователь мог там что-то поменять

            //при условии, что предварительно пользователь выбрал какую-то компанию (информация в правой части окна)
            if (details_planes_count.Visible == true)
            {
                //считаются не только модели, но и экземпляры

                int details_planes_model_count = companies_list[gridforcomp.SelectedRows[0].Index].planes.Count;

                int details_planes_all_count = 0;

                for (int step = 0; step < companies_list[gridforcomp.SelectedRows[0].Index].planes.Count; step++)
                {
                    details_planes_all_count += companies_list[gridforcomp.SelectedRows[0].Index].planes[step].count;
                }

                details_planes_count.Text = "М - " + Convert.ToString(details_planes_model_count) + "; Э - " + Convert.ToString(details_planes_all_count) + ";";
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //если мы окончательно закрыли форму, то нужно закрыть приложение именно таким способом
            //так как есть спрятанные формы

            Application.Exit();
        }

        private void sort_but_Click(object sender, EventArgs e)
        {
            //открываем сортировку. важно передать актульный список компаний

            sort_window.parent_form = this;
            sort_window.companies_list = companies_list;
            sort_window.ShowDialog();
            
        }

        private void filter_but_Click(object sender, EventArgs e)
        {
            //открываем фильтр. важно передать актуальный список компаний

            filter_window.parent_window = this;
            filter_window.companyBindingSource = companyBindingSource;
            filter_window.companies_list = companies_list;
            filter_was_used = true;
            filter_window.ShowDialog();
        }


        private void cancel_filter_interface()
        {
            //сброс фильтра. чисто внешний. в случае, если пользователь,  например, открыл новый файл
            //грид сам отобразит все строки без фильтра

            filter_but.FlatStyle = FlatStyle.System;
            filter_but.BackColor = SystemColors.Control;

            filter_window.use_filter_checkbox.Checked = false;
        }

        private void visual_but_Click(object sender, EventArgs e)
        {
            //открываем окно отчетов

            visualisation new_visual_windows = new visualisation(companies_list);

            new_visual_windows.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //запускаем блокнот со справкой
            //проверяем, а есть ли блокнот у пользователя

            try
            {
                Process.Start(@"C:\Windows\System32\notepad.exe", "Help.txt");
            } catch (Exception)
            {
                MessageBox.Show("Ошибка при открытии файла со справкой.", "Ошибка");
            }
        }

        private void gridforcomp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //даем возможность пользователю выбирать компании клавиатурой
            //подтверждая выбор пробелом

            if (e.KeyChar == ' ')
            {
                gridforcomp_CellClick(this, null);
            }
        }
    }

    //классы, используемые в программе

    public class Plane
    {
        public string name { get; set; } //название модели
        public int count { get; set; } //количество экземпляров
        public long cost; //стоимость одного экз.
        public int speed; //скорость полета
        public string type { get; set; } //тип (пасс. или груз.)
        public int volume; //вместимость (в человеках или куб. метрах - зависит от типа выше)
        public int distance; //расстояние перелета без подзаправки
        public int payload_capacity; //грузоподъемность (только для грузовых)

        public Plane()
        {

        }

        //конструктор, по которому и работает добавление новых моделей

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
        public string name { get; set; } //название компании
        public string full_name { get; set; } //полное название
        public string year_of_foundation { get; set; } //дата основания (день.месяц.год)
        public string tax_number { get; set; } //налоговый номер
        public string certificate { get; set; } //лицензия на право деятельности
        public string ceo { get; set; } //директор ФИО или ФИ
        public string type { get; set; } //тип (пассажирская, грузовая или смешанная)
        public long cost { get; set; } //стоимость в Руб
        public string location { get; set; } //расположение Город, Страна
        public string description { get; set; } //краткое описание
        public int number_of_employees { get; set; } //количество сотрудников
        public string phone_number { get; set; } //номер телефона
        public string site { get; set; } //веб-сайт
        public List<String> destination_points { get; set; } //список пунктов назначения перелетов
        public List<Plane> planes = new List<Plane>(); //список самолетов компании

        public Company()
        {

        }

        public Company(string name, string full_name, string year_of_foundation, string tax_number, string certificate, string ceo, string type, long cost, string location, string description, int number_of_employees, string phone_number, string site)
        {
            //конструктор, который активно используется при создании новой компании

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
