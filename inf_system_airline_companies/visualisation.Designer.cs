namespace inf_system_airline_companies
{
    partial class visualisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visualisation));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.out_put = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.type_1 = new System.Windows.Forms.RadioButton();
            this.type_2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generate_text = new System.Windows.Forms.Button();
            this.by_type_1 = new System.Windows.Forms.RadioButton();
            this.by_price_1 = new System.Windows.Forms.RadioButton();
            this.by_loc_1 = new System.Windows.Forms.RadioButton();
            this.by_loc_and_city_1 = new System.Windows.Forms.RadioButton();
            this.by_emp_1 = new System.Windows.Forms.RadioButton();
            this.by_dest_p_1 = new System.Windows.Forms.RadioButton();
            this.by_pop_model_1 = new System.Windows.Forms.RadioButton();
            this.by_model_type_1 = new System.Windows.Forms.RadioButton();
            this.by_model_price = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.by_price_2 = new System.Windows.Forms.RadioButton();
            this.by_emp_2 = new System.Windows.Forms.RadioButton();
            this.by_plane_type_2 = new System.Windows.Forms.RadioButton();
            this.by_plane_cost_2 = new System.Windows.Forms.RadioButton();
            this.by_total_count_plane_2 = new System.Windows.Forms.RadioButton();
            this.by_avg_distance_2 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.generate_text);
            this.tabPage1.Controls.Add(this.type_2);
            this.tabPage1.Controls.Add(this.type_1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.out_put);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(977, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Текстовые отчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Визуализация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // out_put
            // 
            this.out_put.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out_put.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out_put.Location = new System.Drawing.Point(0, 0);
            this.out_put.Name = "out_put";
            this.out_put.ReadOnly = true;
            this.out_put.Size = new System.Drawing.Size(496, 473);
            this.out_put.TabIndex = 0;
            this.out_put.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(503, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Настройки отчета:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.by_loc_and_city_1);
            this.groupBox1.Controls.Add(this.by_loc_1);
            this.groupBox1.Controls.Add(this.by_model_price);
            this.groupBox1.Controls.Add(this.by_model_type_1);
            this.groupBox1.Controls.Add(this.by_pop_model_1);
            this.groupBox1.Controls.Add(this.by_dest_p_1);
            this.groupBox1.Controls.Add(this.by_emp_1);
            this.groupBox1.Controls.Add(this.by_price_1);
            this.groupBox1.Controls.Add(this.by_type_1);
            this.groupBox1.Location = new System.Drawing.Point(507, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "По всем компаниям в совокупности";
            // 
            // type_1
            // 
            this.type_1.AutoSize = true;
            this.type_1.Checked = true;
            this.type_1.Location = new System.Drawing.Point(507, 43);
            this.type_1.Name = "type_1";
            this.type_1.Size = new System.Drawing.Size(252, 17);
            this.type_1.TabIndex = 3;
            this.type_1.TabStop = true;
            this.type_1.Text = "Сформировать по всей базе в совокупности";
            this.type_1.UseVisualStyleBackColor = true;
            this.type_1.CheckedChanged += new System.EventHandler(this.type_1_CheckedChanged);
            // 
            // type_2
            // 
            this.type_2.AutoSize = true;
            this.type_2.Location = new System.Drawing.Point(507, 274);
            this.type_2.Name = "type_2";
            this.type_2.Size = new System.Drawing.Size(260, 17);
            this.type_2.TabIndex = 3;
            this.type_2.Text = "Сформировать по каждой компании отдельно";
            this.type_2.UseVisualStyleBackColor = true;
            this.type_2.CheckedChanged += new System.EventHandler(this.type_2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.by_plane_type_2);
            this.groupBox2.Controls.Add(this.by_emp_2);
            this.groupBox2.Controls.Add(this.by_avg_distance_2);
            this.groupBox2.Controls.Add(this.by_total_count_plane_2);
            this.groupBox2.Controls.Add(this.by_plane_cost_2);
            this.groupBox2.Controls.Add(this.by_price_2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(507, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация по каждой компании";
            // 
            // generate_text
            // 
            this.generate_text.Location = new System.Drawing.Point(799, 421);
            this.generate_text.Name = "generate_text";
            this.generate_text.Size = new System.Drawing.Size(168, 41);
            this.generate_text.TabIndex = 4;
            this.generate_text.Text = "Сформировать";
            this.generate_text.UseVisualStyleBackColor = true;
            this.generate_text.Click += new System.EventHandler(this.generate_text_Click);
            // 
            // by_type_1
            // 
            this.by_type_1.AutoSize = true;
            this.by_type_1.Checked = true;
            this.by_type_1.Location = new System.Drawing.Point(7, 20);
            this.by_type_1.Name = "by_type_1";
            this.by_type_1.Size = new System.Drawing.Size(206, 17);
            this.by_type_1.TabIndex = 0;
            this.by_type_1.TabStop = true;
            this.by_type_1.Text = "Распределение по типам компаний";
            this.by_type_1.UseVisualStyleBackColor = true;
            // 
            // by_price_1
            // 
            this.by_price_1.AutoSize = true;
            this.by_price_1.Location = new System.Drawing.Point(7, 43);
            this.by_price_1.Name = "by_price_1";
            this.by_price_1.Size = new System.Drawing.Size(183, 17);
            this.by_price_1.TabIndex = 0;
            this.by_price_1.Text = "Сведения о ценах на компании";
            this.by_price_1.UseVisualStyleBackColor = true;
            // 
            // by_loc_1
            // 
            this.by_loc_1.AutoSize = true;
            this.by_loc_1.Location = new System.Drawing.Point(7, 66);
            this.by_loc_1.Name = "by_loc_1";
            this.by_loc_1.Size = new System.Drawing.Size(198, 30);
            this.by_loc_1.TabIndex = 0;
            this.by_loc_1.Text = "Распределение по расположению\r\n(только страны)";
            this.by_loc_1.UseVisualStyleBackColor = true;
            // 
            // by_loc_and_city_1
            // 
            this.by_loc_and_city_1.AutoSize = true;
            this.by_loc_and_city_1.Location = new System.Drawing.Point(7, 102);
            this.by_loc_and_city_1.Name = "by_loc_and_city_1";
            this.by_loc_and_city_1.Size = new System.Drawing.Size(198, 30);
            this.by_loc_and_city_1.TabIndex = 0;
            this.by_loc_and_city_1.Text = "Распределение по расположению\r\n(с учетом города)";
            this.by_loc_and_city_1.UseVisualStyleBackColor = true;
            // 
            // by_emp_1
            // 
            this.by_emp_1.AutoSize = true;
            this.by_emp_1.Location = new System.Drawing.Point(6, 138);
            this.by_emp_1.Name = "by_emp_1";
            this.by_emp_1.Size = new System.Drawing.Size(211, 17);
            this.by_emp_1.TabIndex = 0;
            this.by_emp_1.Text = "Сведения о количестве сотрудников";
            this.by_emp_1.UseVisualStyleBackColor = true;
            // 
            // by_dest_p_1
            // 
            this.by_dest_p_1.AutoSize = true;
            this.by_dest_p_1.Location = new System.Drawing.Point(6, 161);
            this.by_dest_p_1.Name = "by_dest_p_1";
            this.by_dest_p_1.Size = new System.Drawing.Size(225, 17);
            this.by_dest_p_1.TabIndex = 0;
            this.by_dest_p_1.Text = "Самые популярные пункты назначения";
            this.by_dest_p_1.UseVisualStyleBackColor = true;
            // 
            // by_pop_model_1
            // 
            this.by_pop_model_1.AutoSize = true;
            this.by_pop_model_1.Location = new System.Drawing.Point(231, 19);
            this.by_pop_model_1.Name = "by_pop_model_1";
            this.by_pop_model_1.Size = new System.Drawing.Size(223, 17);
            this.by_pop_model_1.TabIndex = 0;
            this.by_pop_model_1.Text = "Самые популярные модели самолетов";
            this.by_pop_model_1.UseVisualStyleBackColor = true;
            // 
            // by_model_type_1
            // 
            this.by_model_type_1.AutoSize = true;
            this.by_model_type_1.Location = new System.Drawing.Point(231, 43);
            this.by_model_type_1.Name = "by_model_type_1";
            this.by_model_type_1.Size = new System.Drawing.Size(210, 17);
            this.by_model_type_1.TabIndex = 0;
            this.by_model_type_1.Text = "Самые популярные типы самолетов";
            this.by_model_type_1.UseVisualStyleBackColor = true;
            // 
            // by_model_price
            // 
            this.by_model_price.AutoSize = true;
            this.by_model_price.Location = new System.Drawing.Point(231, 73);
            this.by_model_price.Name = "by_model_price";
            this.by_model_price.Size = new System.Drawing.Size(184, 17);
            this.by_model_price.TabIndex = 0;
            this.by_model_price.Text = "Сведения о ценах на самолеты";
            this.by_model_price.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Не требуют вычислений:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "С вычислением результата:";
            // 
            // by_price_2
            // 
            this.by_price_2.AutoSize = true;
            this.by_price_2.Checked = true;
            this.by_price_2.Location = new System.Drawing.Point(10, 37);
            this.by_price_2.Name = "by_price_2";
            this.by_price_2.Size = new System.Drawing.Size(133, 17);
            this.by_price_2.TabIndex = 1;
            this.by_price_2.TabStop = true;
            this.by_price_2.Text = "Стоимость компании";
            this.by_price_2.UseVisualStyleBackColor = true;
            // 
            // by_emp_2
            // 
            this.by_emp_2.AutoSize = true;
            this.by_emp_2.Location = new System.Drawing.Point(10, 60);
            this.by_emp_2.Name = "by_emp_2";
            this.by_emp_2.Size = new System.Drawing.Size(151, 17);
            this.by_emp_2.TabIndex = 1;
            this.by_emp_2.Text = "Количество сотрудников";
            this.by_emp_2.UseVisualStyleBackColor = true;
            // 
            // by_plane_type_2
            // 
            this.by_plane_type_2.AutoSize = true;
            this.by_plane_type_2.Location = new System.Drawing.Point(10, 83);
            this.by_plane_type_2.Name = "by_plane_type_2";
            this.by_plane_type_2.Size = new System.Drawing.Size(198, 30);
            this.by_plane_type_2.TabIndex = 1;
            this.by_plane_type_2.Text = "Количество самолетов (экземпл.)\r\nпо типам";
            this.by_plane_type_2.UseVisualStyleBackColor = true;
            // 
            // by_plane_cost_2
            // 
            this.by_plane_cost_2.AutoSize = true;
            this.by_plane_cost_2.Location = new System.Drawing.Point(231, 37);
            this.by_plane_cost_2.Name = "by_plane_cost_2";
            this.by_plane_cost_2.Size = new System.Drawing.Size(177, 17);
            this.by_plane_cost_2.TabIndex = 1;
            this.by_plane_cost_2.Text = "Средняя стоимость самолета";
            this.by_plane_cost_2.UseVisualStyleBackColor = true;
            // 
            // by_total_count_plane_2
            // 
            this.by_total_count_plane_2.AutoSize = true;
            this.by_total_count_plane_2.Location = new System.Drawing.Point(231, 60);
            this.by_total_count_plane_2.Name = "by_total_count_plane_2";
            this.by_total_count_plane_2.Size = new System.Drawing.Size(184, 17);
            this.by_total_count_plane_2.TabIndex = 1;
            this.by_total_count_plane_2.Text = "Всего экземпляров самолетов";
            this.by_total_count_plane_2.UseVisualStyleBackColor = true;
            // 
            // by_avg_distance_2
            // 
            this.by_avg_distance_2.AutoSize = true;
            this.by_avg_distance_2.Location = new System.Drawing.Point(231, 90);
            this.by_avg_distance_2.Name = "by_avg_distance_2";
            this.by_avg_distance_2.Size = new System.Drawing.Size(174, 17);
            this.by_avg_distance_2.TabIndex = 1;
            this.by_avg_distance_2.Text = "Средняя дистанция перелета";
            this.by_avg_distance_2.UseVisualStyleBackColor = true;
            // 
            // visualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 495);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "visualisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.visualisation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox out_put;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton type_2;
        private System.Windows.Forms.RadioButton type_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button generate_text;
        private System.Windows.Forms.RadioButton by_type_1;
        private System.Windows.Forms.RadioButton by_price_1;
        private System.Windows.Forms.RadioButton by_loc_and_city_1;
        private System.Windows.Forms.RadioButton by_loc_1;
        private System.Windows.Forms.RadioButton by_emp_1;
        private System.Windows.Forms.RadioButton by_dest_p_1;
        private System.Windows.Forms.RadioButton by_pop_model_1;
        private System.Windows.Forms.RadioButton by_model_type_1;
        private System.Windows.Forms.RadioButton by_model_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton by_emp_2;
        private System.Windows.Forms.RadioButton by_price_2;
        private System.Windows.Forms.RadioButton by_plane_type_2;
        private System.Windows.Forms.RadioButton by_plane_cost_2;
        private System.Windows.Forms.RadioButton by_total_count_plane_2;
        private System.Windows.Forms.RadioButton by_avg_distance_2;
    }
}