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
    public partial class planes_in_comp : Form
    {
        public planes_in_comp(List<Company> cmp_lst, DataGridView gridforcomp)
        {
            InitializeComponent();

            this.gridforcomp = gridforcomp;
            this.companies_list = cmp_lst;
        }

        public DataGridView gridforcomp;
        public List<Company> companies_list;
        public int row_selected;

        private void planes_in_comp_Load(object sender, EventArgs e)
        {
            this.Text = companies_list[gridforcomp.SelectedRows[0].Index].name + " | Самолеты компании";

            header.Text = companies_list[gridforcomp.SelectedRows[0].Index].name + " > Самолёты";

            planeBindingSource.DataSource = companies_list[gridforcomp.SelectedRows[0].Index].planes;

            row_selected = gridforcomp.SelectedRows[0].Index;

            if (companies_list[gridforcomp.SelectedRows[0].Index].planes.Count > 0)
            gridforplanes_CellClick(gridforplanes,null);
        }

        private void gridforplanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (companies_list[gridforcomp.SelectedRows[0].Index].planes.Count == 0) return;

            edit_plane.Enabled = true;
            delete_plane.Enabled = true;

            details_cost.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].cost.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")) + " Руб";
            details_speed.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].speed.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")) + " Км / Ч";
            details_distance.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].distance.ToString("N0", CultureInfo.GetCultureInfo("ru-RU")) + " Км";

            if (companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].type == "Пассажирский")
            {
                details_vol.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].volume.ToString() + " Чел.";
                details_payload_label.Visible = false;
                details_payload.Visible = false;
            }
            else
            {
                details_vol.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].volume.ToString() + " М²";
                details_payload.Text = companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index].payload_capacity.ToString("N0",CultureInfo.GetCultureInfo("ru-RU")) + " Кг";
                details_payload_label.Visible = true;
                details_payload.Visible = true;
            }
        }

        private void hide_details_info()
        {
            details_payload_label.Visible = false;
            details_payload.Visible = false;

            details_cost.Text = "";
            details_speed.Text = "";
            details_distance.Text = "";
            details_vol.Text = "";

            edit_plane.Enabled = false;
            delete_plane.Enabled = false;
        }

        private void delete_plane_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить самолёт?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                companies_list[row_selected].planes.Remove(companies_list[row_selected].planes[gridforplanes.SelectedRows[0].Index]);
                planeBindingSource.ResetBindings(false);
                hide_details_info();
                Program.anything_was_changed = true;
            }
        }

        private void edit_plane_Click(object sender, EventArgs e)
        {
            add_or_edit_plane new_form = new add_or_edit_plane(companies_list[row_selected].planes, gridforplanes, planeBindingSource, true);
            new_form.ShowDialog();
        }

        private void add_plane_Click(object sender, EventArgs e)
        {
            add_or_edit_plane new_form = new add_or_edit_plane(companies_list[row_selected].planes, gridforplanes, planeBindingSource, false);
            new_form.ShowDialog();
        }

        private void planes_in_comp_Activated(object sender, EventArgs e)
        {
            gridforplanes_CellClick(gridforplanes, null);
        }
    }
}
