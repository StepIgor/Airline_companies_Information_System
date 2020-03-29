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
    public partial class change_certificate : Form
    {
        public change_certificate(Company cmp)
        {
            InitializeComponent();
            this.cmp = cmp;
        }

        Company cmp;

        private void change_certificate_Load(object sender, EventArgs e)
        {
            if (cmp.certificate != "(не указано)")
            {
                textBox1.Text = cmp.certificate.Split(' ')[0];
                monthCalendar1.SelectionStart = DateTime.Parse(cmp.certificate.Split(' ')[2]);
                monthCalendar1.MaxDate = DateTime.Now;
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Номер лицензии - всегда целое число.","Предупреждение");
                return;
            }

            if (int.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Номер лицензии не может быть отрицательным.", "Предупреждение");
                return;
            }

            cmp.certificate = textBox1.Text + " от " + Convert.ToString(monthCalendar1.SelectionStart.ToShortDateString());

            Program.anything_was_changed = true;
            this.Close();
        }
    }
}
