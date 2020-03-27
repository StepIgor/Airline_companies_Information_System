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
    public partial class change_law_number_details : Form
    {
        public change_law_number_details(Company cmp, string name_of_elem)
        {
            InitializeComponent();
            this.cmp = cmp;
            this.name_of_elem = name_of_elem;
        }

        Company cmp;
        string name_of_elem;

        private void change_law_number_details_Load(object sender, EventArgs e)
        {
            if (name_of_elem == "employees")
            {
                this.Text = "Изменить кол-во сотрудников";
                what_to_change.Text = "Введите новое количество сотрудников.";

                textBox1.Text = Convert.ToString(cmp.number_of_employees);
            } else if (name_of_elem == "cost")
            {
                this.Text = "Изменить стоимость компании";
                what_to_change.Text = "Введите новую стоимость компании.";

                textBox1.Text = Convert.ToString(cmp.cost);
            } else if (name_of_elem == "tax")
            {
                this.Text = "Изменить номер налогообложения";
                what_to_change.Text = "Введите новый номер налогообложения.";

                textBox1.Text = Convert.ToString(cmp.tax_number);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (name_of_elem == "employees")
            {
                if (!int.TryParse(textBox1.Text, out _))
                {
                    MessageBox.Show("Требуется целое число.", "Предупреждение");
                    return;
                }

                if (int.Parse(textBox1.Text) < 0)
                {
                    MessageBox.Show("Количество сотрудников не может быть отрицательным.", "Предупреждение");
                    return;
                }


                cmp.number_of_employees = int.Parse(textBox1.Text);
                this.Close();
            } else if (name_of_elem == "cost")
            {
                if (!long.TryParse(textBox1.Text, out _))
                {
                    MessageBox.Show("Требуется целое число.", "Предупреждение");
                    return;
                }

                if (long.Parse(textBox1.Text) < 0)
                {
                    MessageBox.Show("Стоимость компании не может быть отрицательной.", "Предупреждение");
                    return;
                }


                cmp.cost = long.Parse(textBox1.Text);
                this.Close();
            } else if (name_of_elem == "tax")
            {
                if (!(textBox1.Text.Length > 0 && textBox1.Text.Length < 25))
                {
                    MessageBox.Show("Длина номера налогообложения должна быть до 24 символов. Пустым поле быть не может.", "Предупреждение");
                    return;
                }

                cmp.tax_number = textBox1.Text;
                this.Close();
            }
        }
    }
}
