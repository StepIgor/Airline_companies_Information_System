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
    public partial class add_or_edit_plane : Form
    {
        public add_or_edit_plane(List<Plane> lst, DataGridView gridforplane, BindingSource bndsrc, Boolean edit = false)
        {
            InitializeComponent();

            this.planes_list = lst;
            this.gridforplane = gridforplane;
            this.edit = edit;
            this.bndsrc = bndsrc;
        }

        List<Plane> planes_list;
        public DataGridView gridforplane;
        Boolean edit;
        BindingSource bndsrc;

        private void add_or_edit_plane_Load(object sender, EventArgs e)
        {
            if (edit == true)
            {
                //если редактируем информацию о существующей модели самолета

                this.Text = "Редактировать информацию о модели самолета";
                describe.Text = "В этом окне происходит редактирование всей информации о конкретной модели самолета.";

                apply_but.Text = "Сохранить изменения";
            }
            else
            {
                this.Text = "Добавить модель самолета";
                describe.Text = "В этом окне происходит добавление всей информации о новой модели самолета.";

                apply_but.Text = "Добавить модель";
            }
        }

        private void cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
