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

            //передаем в конструкторе список самолетов, сетку самолетов, биндинг самолетов и флаг, изменяем ли существ. данные
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

                //поле варьируется в зависимости от типа самолета
                if (planes_list[gridforplane.SelectedRows[0].Index].type == "Пассажирский")
                {
                    volume_label.Text = "Вместимость (мест)";
                } else
                {
                    volume_label.Text = "Вместимость (м³)";
                }

                //предварительное заполнение
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
                //если добавляем новую модель самолета

                this.Text = "Добавить модель самолета";
                describe.Text = "В этом окне происходит добавление всей информации о новой модели самолета.";

                apply_but.Text = "Добавить модель";
            }
        }

        private void cancel_but_Click(object sender, EventArgs e)
        {
            //закрытие формы без изменений
            this.Close();
        }

        private void type_of_plane_SelectedIndexChanged(object sender, EventArgs e)
        {
            //как уже было отмечено выше, два поле на форме варьируются в зависимости от типа самолета
            if (type_of_plane.Text == "Пассажирский")
            {
                //у пассажирского самолета не указывают грузоподъемность
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

            if (!(model_name.Text.Length < 25 && model_name.Text.Length > 0))
            {
                MessageBox.Show("Название модели не может быть пустым и содержать больше 24 символов.", "Обратите внимание");
                return;
            }

            if (model_name.Text.IndexOf(';') != -1)
            {
                MessageBox.Show("Название модели не может содержать в себе ;", "Обратите внимание");
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
                //если редактируем, то меняем просто элемент списка самолетов
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
                //иначе создаем новый объект и добавляем его в конец списка
                Plane new_plane = new Plane(model_name.Text, int.Parse(planes_count.Text), int.Parse(plane_speed.Text), long.Parse(cost_of_plane.Text), type_of_plane.Text, int.Parse(volume.Text), int.Parse(distance.Text), int.Parse(payload.Text));
                planes_list.Add(new_plane);
                //очистка памяти
                new_plane = null;
            }

            //обновляем биндинг, ставим флаг изменений, закрываем форму
            bndsrc.ResetBindings(false);
            Program.anything_was_changed = true;
            this.Close();
        }

    }
}
