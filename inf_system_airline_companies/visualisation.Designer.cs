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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visualisation));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.generate_text = new System.Windows.Forms.Button();
            this.type_2 = new System.Windows.Forms.RadioButton();
            this.type_1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.by_plane_type_2 = new System.Windows.Forms.RadioButton();
            this.by_emp_2 = new System.Windows.Forms.RadioButton();
            this.by_avg_distance_2 = new System.Windows.Forms.RadioButton();
            this.by_total_count_plane_2 = new System.Windows.Forms.RadioButton();
            this.by_plane_cost_2 = new System.Windows.Forms.RadioButton();
            this.by_price_2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.by_loc_and_city_1 = new System.Windows.Forms.RadioButton();
            this.by_loc_1 = new System.Windows.Forms.RadioButton();
            this.by_model_price = new System.Windows.Forms.RadioButton();
            this.by_model_type_1 = new System.Windows.Forms.RadioButton();
            this.by_pop_model_1 = new System.Windows.Forms.RadioButton();
            this.by_dest_p_1 = new System.Windows.Forms.RadioButton();
            this.by_emp_1 = new System.Windows.Forms.RadioButton();
            this.by_price_1 = new System.Windows.Forms.RadioButton();
            this.by_type_1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.out_put = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.build_chart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.use_3d = new System.Windows.Forms.CheckBox();
            this.price_diag = new System.Windows.Forms.RadioButton();
            this.emp_diag = new System.Windows.Forms.RadioButton();
            this.country_diag = new System.Windows.Forms.RadioButton();
            this.by_country_and_city_diag = new System.Windows.Forms.RadioButton();
            this.country_dest_diag = new System.Windows.Forms.RadioButton();
            this.country_and_city_dest_diag = new System.Windows.Forms.RadioButton();
            this.plane_model_diag = new System.Windows.Forms.RadioButton();
            this.label_is_val = new System.Windows.Forms.CheckBox();
            this.show_labels = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "С вычислением результата:";
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(503, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Настройки отчета:";
            // 
            // out_put
            // 
            this.out_put.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out_put.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out_put.Location = new System.Drawing.Point(0, 0);
            this.out_put.Name = "out_put";
            this.out_put.ReadOnly = true;
            this.out_put.Size = new System.Drawing.Size(496, 473);
            this.out_put.TabIndex = 0;
            this.out_put.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.build_chart);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Визуализация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.plane_model_diag);
            this.groupBox3.Controls.Add(this.country_and_city_dest_diag);
            this.groupBox3.Controls.Add(this.country_dest_diag);
            this.groupBox3.Controls.Add(this.by_country_and_city_diag);
            this.groupBox3.Controls.Add(this.country_diag);
            this.groupBox3.Controls.Add(this.emp_diag);
            this.groupBox3.Controls.Add(this.price_diag);
            this.groupBox3.Controls.Add(this.show_labels);
            this.groupBox3.Controls.Add(this.label_is_val);
            this.groupBox3.Controls.Add(this.use_3d);
            this.groupBox3.Location = new System.Drawing.Point(526, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 362);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Построить распределение";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(522, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Настройка визуализации:";
            // 
            // build_chart
            // 
            this.build_chart.Location = new System.Drawing.Point(849, 414);
            this.build_chart.Name = "build_chart";
            this.build_chart.Size = new System.Drawing.Size(118, 46);
            this.build_chart.TabIndex = 1;
            this.build_chart.Text = "Построить";
            this.build_chart.UseVisualStyleBackColor = true;
            this.build_chart.Click += new System.EventHandler(this.build_chart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Готов";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 7);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Готов";
            series1.Name = "Готов";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(508, 456);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // use_3d
            // 
            this.use_3d.AutoSize = true;
            this.use_3d.Location = new System.Drawing.Point(7, 20);
            this.use_3d.Name = "use_3d";
            this.use_3d.Size = new System.Drawing.Size(116, 17);
            this.use_3d.TabIndex = 0;
            this.use_3d.Text = "Использовать 3D";
            this.use_3d.UseVisualStyleBackColor = true;
            // 
            // price_diag
            // 
            this.price_diag.AutoSize = true;
            this.price_diag.Checked = true;
            this.price_diag.Location = new System.Drawing.Point(7, 73);
            this.price_diag.Name = "price_diag";
            this.price_diag.Size = new System.Drawing.Size(193, 17);
            this.price_diag.TabIndex = 1;
            this.price_diag.TabStop = true;
            this.price_diag.Text = "Распределение цен на компании";
            this.price_diag.UseVisualStyleBackColor = true;
            // 
            // emp_diag
            // 
            this.emp_diag.AutoSize = true;
            this.emp_diag.Location = new System.Drawing.Point(7, 96);
            this.emp_diag.Name = "emp_diag";
            this.emp_diag.Size = new System.Drawing.Size(203, 17);
            this.emp_diag.TabIndex = 1;
            this.emp_diag.Text = "Распределение числа сотрудников";
            this.emp_diag.UseVisualStyleBackColor = true;
            // 
            // country_diag
            // 
            this.country_diag.AutoSize = true;
            this.country_diag.Location = new System.Drawing.Point(7, 119);
            this.country_diag.Name = "country_diag";
            this.country_diag.Size = new System.Drawing.Size(218, 17);
            this.country_diag.TabIndex = 1;
            this.country_diag.Text = "Распределение компаний по странам";
            this.country_diag.UseVisualStyleBackColor = true;
            // 
            // by_country_and_city_diag
            // 
            this.by_country_and_city_diag.AutoSize = true;
            this.by_country_and_city_diag.Location = new System.Drawing.Point(7, 142);
            this.by_country_and_city_diag.Name = "by_country_and_city_diag";
            this.by_country_and_city_diag.Size = new System.Drawing.Size(273, 17);
            this.by_country_and_city_diag.TabIndex = 1;
            this.by_country_and_city_diag.Text = "Распределение компаний по странам и городам";
            this.by_country_and_city_diag.UseVisualStyleBackColor = true;
            // 
            // country_dest_diag
            // 
            this.country_dest_diag.AutoSize = true;
            this.country_dest_diag.Location = new System.Drawing.Point(7, 165);
            this.country_dest_diag.Name = "country_dest_diag";
            this.country_dest_diag.Size = new System.Drawing.Size(235, 17);
            this.country_dest_diag.TabIndex = 1;
            this.country_dest_diag.Text = "Популярные пункты назначения (страны)";
            this.country_dest_diag.UseVisualStyleBackColor = true;
            // 
            // country_and_city_dest_diag
            // 
            this.country_and_city_dest_diag.AutoSize = true;
            this.country_and_city_dest_diag.Location = new System.Drawing.Point(7, 188);
            this.country_and_city_dest_diag.Name = "country_and_city_dest_diag";
            this.country_and_city_dest_diag.Size = new System.Drawing.Size(282, 17);
            this.country_and_city_dest_diag.TabIndex = 1;
            this.country_and_city_dest_diag.Text = "Популярные пункты назначения (страны и города)";
            this.country_and_city_dest_diag.UseVisualStyleBackColor = true;
            // 
            // plane_model_diag
            // 
            this.plane_model_diag.AutoSize = true;
            this.plane_model_diag.Location = new System.Drawing.Point(7, 211);
            this.plane_model_diag.Name = "plane_model_diag";
            this.plane_model_diag.Size = new System.Drawing.Size(187, 17);
            this.plane_model_diag.TabIndex = 1;
            this.plane_model_diag.Text = "Популярные модели самолетов";
            this.plane_model_diag.UseVisualStyleBackColor = true;
            // 
            // label_is_val
            // 
            this.label_is_val.AutoSize = true;
            this.label_is_val.Location = new System.Drawing.Point(255, 20);
            this.label_is_val.Name = "label_is_val";
            this.label_is_val.Size = new System.Drawing.Size(167, 17);
            this.label_is_val.TabIndex = 0;
            this.label_is_val.Text = "Отображать само значение";
            this.label_is_val.UseVisualStyleBackColor = true;
            // 
            // show_labels
            // 
            this.show_labels.AutoSize = true;
            this.show_labels.Checked = true;
            this.show_labels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.show_labels.Location = new System.Drawing.Point(129, 20);
            this.show_labels.Name = "show_labels";
            this.show_labels.Size = new System.Drawing.Size(120, 17);
            this.show_labels.TabIndex = 0;
            this.show_labels.Text = "Показать подписи";
            this.show_labels.UseVisualStyleBackColor = true;
            this.show_labels.CheckedChanged += new System.EventHandler(this.show_labels_CheckedChanged);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button build_chart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox use_3d;
        private System.Windows.Forms.RadioButton emp_diag;
        private System.Windows.Forms.RadioButton price_diag;
        private System.Windows.Forms.RadioButton country_diag;
        private System.Windows.Forms.RadioButton by_country_and_city_diag;
        private System.Windows.Forms.RadioButton country_and_city_dest_diag;
        private System.Windows.Forms.RadioButton country_dest_diag;
        private System.Windows.Forms.RadioButton plane_model_diag;
        private System.Windows.Forms.CheckBox label_is_val;
        private System.Windows.Forms.CheckBox show_labels;
    }
}