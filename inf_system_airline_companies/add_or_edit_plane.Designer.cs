namespace inf_system_airline_companies
{
    partial class add_or_edit_plane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_or_edit_plane));
            this.describe = new System.Windows.Forms.Label();
            this.apply_but = new System.Windows.Forms.Button();
            this.cancel_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.model_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.planes_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cost_of_plane = new System.Windows.Forms.TextBox();
            this.type_of_plane = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plane_speed = new System.Windows.Forms.TextBox();
            this.volume_label = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payload = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // describe
            // 
            this.describe.AutoSize = true;
            this.describe.Location = new System.Drawing.Point(12, 9);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(477, 13);
            this.describe.TabIndex = 0;
            this.describe.Text = "В этом окне происходит редактирование всей информации о конкретной модели самолет" +
    "а.";
            // 
            // apply_but
            // 
            this.apply_but.Location = new System.Drawing.Point(395, 405);
            this.apply_but.Name = "apply_but";
            this.apply_but.Size = new System.Drawing.Size(99, 44);
            this.apply_but.TabIndex = 9;
            this.apply_but.Text = "Что-то сделать";
            this.apply_but.UseVisualStyleBackColor = true;
            this.apply_but.Click += new System.EventHandler(this.apply_but_Click);
            // 
            // cancel_but
            // 
            this.cancel_but.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel_but.Location = new System.Drawing.Point(290, 405);
            this.cancel_but.Name = "cancel_but";
            this.cancel_but.Size = new System.Drawing.Size(99, 44);
            this.cancel_but.TabIndex = 10;
            this.cancel_but.Text = "Отмена";
            this.cancel_but.UseVisualStyleBackColor = true;
            this.cancel_but.Click += new System.EventHandler(this.cancel_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название модели";
            // 
            // model_name
            // 
            this.model_name.Location = new System.Drawing.Point(18, 57);
            this.model_name.Name = "model_name";
            this.model_name.Size = new System.Drawing.Size(471, 20);
            this.model_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество во флоте";
            // 
            // planes_count
            // 
            this.planes_count.Location = new System.Drawing.Point(18, 107);
            this.planes_count.Name = "planes_count";
            this.planes_count.Size = new System.Drawing.Size(471, 20);
            this.planes_count.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стоимость одного экземпляра (в руб.)";
            // 
            // cost_of_plane
            // 
            this.cost_of_plane.Location = new System.Drawing.Point(18, 162);
            this.cost_of_plane.Name = "cost_of_plane";
            this.cost_of_plane.Size = new System.Drawing.Size(471, 20);
            this.cost_of_plane.TabIndex = 3;
            // 
            // type_of_plane
            // 
            this.type_of_plane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_of_plane.FormattingEnabled = true;
            this.type_of_plane.Items.AddRange(new object[] {
            "Пассажирский",
            "Грузовой"});
            this.type_of_plane.Location = new System.Drawing.Point(18, 219);
            this.type_of_plane.Name = "type_of_plane";
            this.type_of_plane.Size = new System.Drawing.Size(471, 21);
            this.type_of_plane.TabIndex = 4;
            this.type_of_plane.SelectedIndexChanged += new System.EventHandler(this.type_of_plane_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тип самолета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Скорость в КМ/Ч";
            // 
            // plane_speed
            // 
            this.plane_speed.Location = new System.Drawing.Point(19, 287);
            this.plane_speed.Name = "plane_speed";
            this.plane_speed.Size = new System.Drawing.Size(227, 20);
            this.plane_speed.TabIndex = 5;
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(259, 271);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(110, 13);
            this.volume_label.TabIndex = 5;
            this.volume_label.Text = "Вместимость (мест)";
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(261, 287);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(228, 20);
            this.volume.TabIndex = 6;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(18, 338);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(228, 20);
            this.distance.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Дальность полета (км)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Грузоподъемность (кг)";
            // 
            // payload
            // 
            this.payload.Location = new System.Drawing.Point(262, 338);
            this.payload.Name = "payload";
            this.payload.Size = new System.Drawing.Size(228, 20);
            this.payload.TabIndex = 8;
            // 
            // add_or_edit_plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.volume_label);
            this.Controls.Add(this.payload);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.type_of_plane);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.plane_speed);
            this.Controls.Add(this.cost_of_plane);
            this.Controls.Add(this.planes_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.model_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_but);
            this.Controls.Add(this.apply_but);
            this.Controls.Add(this.describe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_or_edit_plane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_or_edit_plane";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.add_or_edit_plane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label describe;
        private System.Windows.Forms.Button apply_but;
        private System.Windows.Forms.Button cancel_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox model_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox planes_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost_of_plane;
        private System.Windows.Forms.ComboBox type_of_plane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox plane_speed;
        private System.Windows.Forms.Label volume_label;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox payload;
    }
}