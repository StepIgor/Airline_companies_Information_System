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

                if (planes_list[gridforplane.SelectedRows[0].Index].type == "Пассажирский")
                {
                    volume_label.Text = "Вместимость (мест)";
                } else
                {
                    volume_label.Text = "Вместимость (м³)";
                }

                model_name.Text = planes_list[gridforplane.SelectedRows[0].Index].name;
                planes_count.Text = Convert.ToString(planes_list[gridforplane.SelectedRows[0].Index].count);
                cost_of_plane.Text = Convert.ToString(planes_list[gridforplane.SelectedRows[0].Index].cost);
                type_of_plane.Text = planes_list[gridforplane.SelectedRows[0].Index].type;
                plane_speed.Text = Convert.ToString(planes_list[gridforplane.SelectedRows[0].Index].speed);
                volume.Text = Convert.ToString(planes_list[gridforplane.SelectedRows[0].Index].volume);
                distance.Text = Convert.ToString(planes_list[gridforplane.SelectedRows[0].Index].distance);
                payload.Text = Convert.ToString(planes_list[gridforplane.SelectedRows[0].Index].payload_capacity);
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

        private void type_of_plane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_of_plane.Text == "Пассажирский")
            {
                payload.Enabled = false;
                payload.Text = "";
                volume_label.Text = "Вместимость (мест)";
            } else
            {
                payload.Enabled = true;
                volume_label.Text = "Вместимость (м³)";
            }
        }

        private void apply_but_Click(object sender, EventArgs e)
        {

            //блок валидации данных

            if (!(model_name.Text.Length < 49 && model_name.Text.Length > 0))
            {
                MessageBox.Show("Название модели не может быть пустым и содержать больше 48 символов.", "Обратите внимание");
                return;
            }

            if (!(int.TryParse(planes_count.Text, out _)))
            {
                MessageBox.Show("Количество самолетов должно представлять собой число.", "Обратите внимание");
                return;
            }

            if (!(int.Parse(planes_count.Text) > 0))
            {
                MessageBox.Show("У Вас должен быть как минимум один самолет такой модели.", "Обратите внимание");
                return;
            }


            if (!(long.TryParse(cost_of_plane.Text, out _)))
            {
                MessageBox.Show("Стоимость самолета должна представлять собой целое число.", "Обратите внимание");
                return;
            }

            if (!(long.Parse(cost_of_plane.Text) > -1))
            {
                MessageBox.Show("Стоимость самолета не может быть отрицательной.", "Обратите внимание");
                return;
            }


            if (!(type_of_plane.Text == "Пассажирский" || type_of_plane.Text == "Грузовой"))
            {
                MessageBox.Show("Не выбран тип самолета.", "Обратите внимание");
                return;
            }


            if (!(int.TryParse(plane_speed.Text, out _)))
            {
                MessageBox.Show("Скорость самолета должна представлять собой целое число.", "Обратите внимание");
                return;
            }

            if (!(int.Parse(plane_speed.Text) > 0))
            {
                MessageBox.Show("Скорость самолета не может быть нулевой или отрицательной.", "Обратите внимание");
                return;
            }


            if (!(int.TryParse(volume.Text, out _)))
            {
                MessageBox.Show("Вместимость самолета должна представлять собой целое число.", "Обратите внимание");
                return;
            }

            if (!(int.Parse(volume.Text) > -1))
            {
                MessageBox.Show("Вместимость самолета не может быть отрицательной.", "Обратите внимание");
                return;
            }


            if (!(int.TryParse(distance.Text, out _)))
            {
                MessageBox.Show("Дальность полета самолета должна представлять собой целое число.", "Обратите внимание");
                return;
            }

            if (!(int.Parse(distance.Text) > 0))
            {
                MessageBox.Show("Дальность полета самолета не может быть нулевой или отрицательной.", "Обратите внимание");
                return;
            }

            if (type_of_plane.Text == "Грузовой")
            {
                if (!(int.TryParse(payload.Text, out _)))
                {
                    MessageBox.Show("Грузоподъемность самолета должна представлять собой целое число.", "Обратите внимание");
                    return;
                }

                if (!(int.Parse(payload.Text) > -1))
                {
                    MessageBox.Show("Грузоподъемность самолета не может быть отрицательной.", "Обратите внимание");
                    return;
                }
            } else
            {
                payload.Text = "0";
            }


            if (edit == true)
            {
                planes_list[gridforplane.SelectedRows[0].Index].name = model_name.Text;
                planes_list[gridforplane.SelectedRows[0].Index].count = int.Parse(planes_count.Text);
                planes_list[gridforplane.SelectedRows[0].Index].cost = long.Parse(cost_of_plane.Text);
                planes_list[gridforplane.SelectedRows[0].Index].speed = int.Parse(plane_speed.Text);
                planes_list[gridforplane.SelectedRows[0].Index].type = type_of_plane.Text;
                planes_list[gridforplane.SelectedRows[0].Index].volume = int.Parse(volume.Text);
                planes_list[gridforplane.SelectedRows[0].Index].distance = int.Parse(distance.Text);
                planes_list[gridforplane.SelectedRows[0].Index].payload_capacity = int.Parse(payload.Text);
            } else
            {
                Plane new_plane = new Plane(model_name.Text, int.Parse(planes_count.Text), int.Parse(plane_speed.Text), long.Parse(cost_of_plane.Text), type_of_plane.Text, int.Parse(volume.Text), int.Parse(distance.Text), int.Parse(payload.Text));
                planes_list.Add(new_plane);
                new_plane = null;
            }

            bndsrc.ResetBindings(false);
            this.Close();
        }

    }
}
