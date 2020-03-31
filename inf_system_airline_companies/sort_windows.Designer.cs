namespace inf_system_airline_companies
{
    partial class sort_windows
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
            this.one_level_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.by_decr = new System.Windows.Forms.RadioButton();
            this.by_incr = new System.Windows.Forms.RadioButton();
            this.by_loc = new System.Windows.Forms.RadioButton();
            this.by_cost = new System.Windows.Forms.RadioButton();
            this.by_dest_p = new System.Windows.Forms.RadioButton();
            this.by_planes = new System.Windows.Forms.RadioButton();
            this.by_empl = new System.Windows.Forms.RadioButton();
            this.by_ceo = new System.Windows.Forms.RadioButton();
            this.by_type = new System.Windows.Forms.RadioButton();
            this.by_date = new System.Windows.Forms.RadioButton();
            this.by_name = new System.Windows.Forms.RadioButton();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.multilevel_sort_radio = new System.Windows.Forms.RadioButton();
            this.apply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.available = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.in_use = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_in_use = new System.Windows.Forms.Button();
            this.delete_from_use = new System.Windows.Forms.Button();
            this.switch_up = new System.Windows.Forms.Button();
            this.switch_down = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // one_level_radio
            // 
            this.one_level_radio.AutoSize = true;
            this.one_level_radio.Checked = true;
            this.one_level_radio.Location = new System.Drawing.Point(12, 12);
            this.one_level_radio.Name = "one_level_radio";
            this.one_level_radio.Size = new System.Drawing.Size(166, 17);
            this.one_level_radio.TabIndex = 0;
            this.one_level_radio.TabStop = true;
            this.one_level_radio.Text = "Одноуровневая сортировка";
            this.one_level_radio.UseVisualStyleBackColor = true;
            this.one_level_radio.CheckedChanged += new System.EventHandler(this.one_level_radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.by_loc);
            this.groupBox1.Controls.Add(this.by_cost);
            this.groupBox1.Controls.Add(this.by_dest_p);
            this.groupBox1.Controls.Add(this.by_planes);
            this.groupBox1.Controls.Add(this.by_empl);
            this.groupBox1.Controls.Add(this.by_ceo);
            this.groupBox1.Controls.Add(this.by_type);
            this.groupBox1.Controls.Add(this.by_date);
            this.groupBox1.Controls.Add(this.by_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.by_decr);
            this.groupBox2.Controls.Add(this.by_incr);
            this.groupBox2.Location = new System.Drawing.Point(7, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим";
            // 
            // by_decr
            // 
            this.by_decr.AutoSize = true;
            this.by_decr.Location = new System.Drawing.Point(139, 19);
            this.by_decr.Name = "by_decr";
            this.by_decr.Size = new System.Drawing.Size(93, 17);
            this.by_decr.TabIndex = 0;
            this.by_decr.Text = "По убыванию";
            this.by_decr.UseVisualStyleBackColor = true;
            // 
            // by_incr
            // 
            this.by_incr.AutoSize = true;
            this.by_incr.Checked = true;
            this.by_incr.Location = new System.Drawing.Point(6, 19);
            this.by_incr.Name = "by_incr";
            this.by_incr.Size = new System.Drawing.Size(109, 17);
            this.by_incr.TabIndex = 0;
            this.by_incr.TabStop = true;
            this.by_incr.Text = "По возрастанию";
            this.by_incr.UseVisualStyleBackColor = true;
            // 
            // by_loc
            // 
            this.by_loc.AutoSize = true;
            this.by_loc.Location = new System.Drawing.Point(140, 66);
            this.by_loc.Name = "by_loc";
            this.by_loc.Size = new System.Drawing.Size(118, 17);
            this.by_loc.TabIndex = 0;
            this.by_loc.TabStop = true;
            this.by_loc.Text = "По расположению";
            this.by_loc.UseVisualStyleBackColor = true;
            // 
            // by_cost
            // 
            this.by_cost.AutoSize = true;
            this.by_cost.Location = new System.Drawing.Point(140, 43);
            this.by_cost.Name = "by_cost";
            this.by_cost.Size = new System.Drawing.Size(96, 17);
            this.by_cost.TabIndex = 0;
            this.by_cost.TabStop = true;
            this.by_cost.Text = "По стоимости";
            this.by_cost.UseVisualStyleBackColor = true;
            // 
            // by_dest_p
            // 
            this.by_dest_p.AutoSize = true;
            this.by_dest_p.Location = new System.Drawing.Point(277, 66);
            this.by_dest_p.Name = "by_dest_p";
            this.by_dest_p.Size = new System.Drawing.Size(158, 17);
            this.by_dest_p.TabIndex = 0;
            this.by_dest_p.TabStop = true;
            this.by_dest_p.Text = "По кол-ву пунктов назнач.";
            this.by_dest_p.UseVisualStyleBackColor = true;
            // 
            // by_planes
            // 
            this.by_planes.AutoSize = true;
            this.by_planes.Location = new System.Drawing.Point(277, 43);
            this.by_planes.Name = "by_planes";
            this.by_planes.Size = new System.Drawing.Size(159, 17);
            this.by_planes.TabIndex = 0;
            this.by_planes.Text = "По кол-ву моделей самол.";
            this.by_planes.UseVisualStyleBackColor = true;
            // 
            // by_empl
            // 
            this.by_empl.AutoSize = true;
            this.by_empl.Location = new System.Drawing.Point(277, 20);
            this.by_empl.Name = "by_empl";
            this.by_empl.Size = new System.Drawing.Size(139, 17);
            this.by_empl.TabIndex = 0;
            this.by_empl.TabStop = true;
            this.by_empl.Text = "По количеству сотруд.";
            this.by_empl.UseVisualStyleBackColor = true;
            // 
            // by_ceo
            // 
            this.by_ceo.AutoSize = true;
            this.by_ceo.Location = new System.Drawing.Point(140, 20);
            this.by_ceo.Name = "by_ceo";
            this.by_ceo.Size = new System.Drawing.Size(95, 17);
            this.by_ceo.TabIndex = 0;
            this.by_ceo.TabStop = true;
            this.by_ceo.Text = "По владельцу";
            this.by_ceo.UseVisualStyleBackColor = true;
            // 
            // by_type
            // 
            this.by_type.AutoSize = true;
            this.by_type.Location = new System.Drawing.Point(7, 66);
            this.by_type.Name = "by_type";
            this.by_type.Size = new System.Drawing.Size(117, 17);
            this.by_type.TabIndex = 0;
            this.by_type.TabStop = true;
            this.by_type.Text = "По типу компании";
            this.by_type.UseVisualStyleBackColor = true;
            // 
            // by_date
            // 
            this.by_date.AutoSize = true;
            this.by_date.Location = new System.Drawing.Point(7, 43);
            this.by_date.Name = "by_date";
            this.by_date.Size = new System.Drawing.Size(122, 17);
            this.by_date.TabIndex = 0;
            this.by_date.TabStop = true;
            this.by_date.Text = "По дате основания";
            this.by_date.UseVisualStyleBackColor = true;
            // 
            // by_name
            // 
            this.by_name.AutoSize = true;
            this.by_name.Checked = true;
            this.by_name.Location = new System.Drawing.Point(7, 20);
            this.by_name.Name = "by_name";
            this.by_name.Size = new System.Drawing.Size(127, 17);
            this.by_name.TabIndex = 0;
            this.by_name.TabStop = true;
            this.by_name.Text = "По имени компании";
            this.by_name.UseVisualStyleBackColor = true;
            // 
            // group2
            // 
            this.group2.Controls.Add(this.delete_from_use);
            this.group2.Controls.Add(this.switch_down);
            this.group2.Controls.Add(this.switch_up);
            this.group2.Controls.Add(this.add_in_use);
            this.group2.Controls.Add(this.label2);
            this.group2.Controls.Add(this.label1);
            this.group2.Controls.Add(this.in_use);
            this.group2.Controls.Add(this.available);
            this.group2.Enabled = false;
            this.group2.Location = new System.Drawing.Point(12, 204);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(446, 198);
            this.group2.TabIndex = 3;
            this.group2.TabStop = false;
            // 
            // multilevel_sort_radio
            // 
            this.multilevel_sort_radio.AutoSize = true;
            this.multilevel_sort_radio.Location = new System.Drawing.Point(12, 181);
            this.multilevel_sort_radio.Name = "multilevel_sort_radio";
            this.multilevel_sort_radio.Size = new System.Drawing.Size(172, 17);
            this.multilevel_sort_radio.TabIndex = 1;
            this.multilevel_sort_radio.Text = "Многоуровневая сортировка";
            this.multilevel_sort_radio.UseVisualStyleBackColor = true;
            this.multilevel_sort_radio.CheckedChanged += new System.EventHandler(this.multilevel_sort_radio_CheckedChanged);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(359, 408);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(99, 49);
            this.apply.TabIndex = 4;
            this.apply.Text = "Применить";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(254, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // available
            // 
            this.available.FormattingEnabled = true;
            this.available.Location = new System.Drawing.Point(13, 45);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(153, 147);
            this.available.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Доступные поля";
            // 
            // in_use
            // 
            this.in_use.FormattingEnabled = true;
            this.in_use.Location = new System.Drawing.Point(228, 45);
            this.in_use.Name = "in_use";
            this.in_use.Size = new System.Drawing.Size(153, 147);
            this.in_use.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Используется";
            // 
            // add_in_use
            // 
            this.add_in_use.Location = new System.Drawing.Point(172, 71);
            this.add_in_use.Name = "add_in_use";
            this.add_in_use.Size = new System.Drawing.Size(50, 41);
            this.add_in_use.TabIndex = 2;
            this.add_in_use.Text = "-->";
            this.add_in_use.UseVisualStyleBackColor = true;
            this.add_in_use.Click += new System.EventHandler(this.add_in_use_Click);
            // 
            // delete_from_use
            // 
            this.delete_from_use.Enabled = false;
            this.delete_from_use.Location = new System.Drawing.Point(172, 118);
            this.delete_from_use.Name = "delete_from_use";
            this.delete_from_use.Size = new System.Drawing.Size(50, 41);
            this.delete_from_use.TabIndex = 2;
            this.delete_from_use.Text = "<--";
            this.delete_from_use.UseVisualStyleBackColor = true;
            this.delete_from_use.Click += new System.EventHandler(this.delete_from_use_Click);
            // 
            // switch_up
            // 
            this.switch_up.Enabled = false;
            this.switch_up.Location = new System.Drawing.Point(385, 71);
            this.switch_up.Name = "switch_up";
            this.switch_up.Size = new System.Drawing.Size(50, 41);
            this.switch_up.TabIndex = 2;
            this.switch_up.Text = "˄";
            this.switch_up.UseVisualStyleBackColor = true;
            this.switch_up.Click += new System.EventHandler(this.switch_up_Click);
            // 
            // switch_down
            // 
            this.switch_down.Enabled = false;
            this.switch_down.Location = new System.Drawing.Point(385, 118);
            this.switch_down.Name = "switch_down";
            this.switch_down.Size = new System.Drawing.Size(50, 41);
            this.switch_down.TabIndex = 2;
            this.switch_down.Text = "˅";
            this.switch_down.UseVisualStyleBackColor = true;
            this.switch_down.Click += new System.EventHandler(this.switch_down_Click);
            // 
            // sort_windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 469);
            this.Controls.Add(this.multilevel_sort_radio);
            this.Controls.Add(this.one_level_radio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sort_windows";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.sort_windows_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton one_level_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.RadioButton multilevel_sort_radio;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton by_loc;
        private System.Windows.Forms.RadioButton by_cost;
        private System.Windows.Forms.RadioButton by_dest_p;
        private System.Windows.Forms.RadioButton by_planes;
        private System.Windows.Forms.RadioButton by_empl;
        private System.Windows.Forms.RadioButton by_ceo;
        private System.Windows.Forms.RadioButton by_type;
        private System.Windows.Forms.RadioButton by_date;
        private System.Windows.Forms.RadioButton by_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton by_decr;
        private System.Windows.Forms.RadioButton by_incr;
        private System.Windows.Forms.Button delete_from_use;
        private System.Windows.Forms.Button switch_down;
        private System.Windows.Forms.Button switch_up;
        private System.Windows.Forms.Button add_in_use;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox in_use;
        private System.Windows.Forms.ListBox available;
    }
}