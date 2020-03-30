namespace inf_system_airline_companies
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelforcomplist = new System.Windows.Forms.Label();
            this.gridforcomp = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailslabel = new System.Windows.Forms.Label();
            this.detailsgroup = new System.Windows.Forms.GroupBox();
            this.details_open_law_info = new System.Windows.Forms.Button();
            this.details_web_img = new System.Windows.Forms.PictureBox();
            this.details_phone_img = new System.Windows.Forms.PictureBox();
            this.details_open_planes_form = new System.Windows.Forms.Button();
            this.details_ceo_name = new System.Windows.Forms.Label();
            this.details_planes_count = new System.Windows.Forms.Label();
            this.details_year_of_found = new System.Windows.Forms.Label();
            this.details_description = new System.Windows.Forms.Label();
            this.details_full_name = new System.Windows.Forms.Label();
            this.details_site = new System.Windows.Forms.Label();
            this.details_phone = new System.Windows.Forms.Label();
            this.details_cat_description = new System.Windows.Forms.Label();
            this.details_cat_ceo = new System.Windows.Forms.Label();
            this.details_cat_year = new System.Windows.Forms.Label();
            this.details_cat_planes_count = new System.Windows.Forms.Label();
            this.details_cat_full_name = new System.Windows.Forms.Label();
            this.details_company_name = new System.Windows.Forms.Label();
            this.tipforfirstselection = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.открытьФайлобразецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.del_comp_but = new System.Windows.Forms.Button();
            this.edit_comp_but = new System.Windows.Forms.Button();
            this.add_comp_but = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.save_as_dialog = new System.Windows.Forms.SaveFileDialog();
            this.load_file_dialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridforcomp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.detailsgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.details_web_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details_phone_img)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelforcomplist
            // 
            this.labelforcomplist.AutoSize = true;
            this.labelforcomplist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelforcomplist.Location = new System.Drawing.Point(13, 33);
            this.labelforcomplist.Name = "labelforcomplist";
            this.labelforcomplist.Size = new System.Drawing.Size(262, 25);
            this.labelforcomplist.TabIndex = 1;
            this.labelforcomplist.Text = "Список авиакомпаний:";
            // 
            // gridforcomp
            // 
            this.gridforcomp.AllowUserToAddRows = false;
            this.gridforcomp.AllowUserToDeleteRows = false;
            this.gridforcomp.AllowUserToResizeRows = false;
            this.gridforcomp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridforcomp.AutoGenerateColumns = false;
            this.gridforcomp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridforcomp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridforcomp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.location});
            this.gridforcomp.DataSource = this.companyBindingSource;
            this.gridforcomp.Location = new System.Drawing.Point(18, 67);
            this.gridforcomp.MultiSelect = false;
            this.gridforcomp.Name = "gridforcomp";
            this.gridforcomp.ReadOnly = true;
            this.gridforcomp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridforcomp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridforcomp.Size = new System.Drawing.Size(556, 538);
            this.gridforcomp.StandardTab = true;
            this.gridforcomp.TabIndex = 3;
            this.gridforcomp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridforcomp_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Расположение";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(inf_system_airline_companies.Company);
            // 
            // detailslabel
            // 
            this.detailslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailslabel.AutoSize = true;
            this.detailslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailslabel.Location = new System.Drawing.Point(575, 33);
            this.detailslabel.Name = "detailslabel";
            this.detailslabel.Size = new System.Drawing.Size(162, 25);
            this.detailslabel.TabIndex = 2;
            this.detailslabel.Text = "Подробности:";
            // 
            // detailsgroup
            // 
            this.detailsgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsgroup.Controls.Add(this.details_open_law_info);
            this.detailsgroup.Controls.Add(this.details_web_img);
            this.detailsgroup.Controls.Add(this.details_phone_img);
            this.detailsgroup.Controls.Add(this.details_open_planes_form);
            this.detailsgroup.Controls.Add(this.details_ceo_name);
            this.detailsgroup.Controls.Add(this.details_planes_count);
            this.detailsgroup.Controls.Add(this.details_year_of_found);
            this.detailsgroup.Controls.Add(this.details_description);
            this.detailsgroup.Controls.Add(this.details_full_name);
            this.detailsgroup.Controls.Add(this.details_site);
            this.detailsgroup.Controls.Add(this.details_phone);
            this.detailsgroup.Controls.Add(this.details_cat_description);
            this.detailsgroup.Controls.Add(this.details_cat_ceo);
            this.detailsgroup.Controls.Add(this.details_cat_year);
            this.detailsgroup.Controls.Add(this.details_cat_planes_count);
            this.detailsgroup.Controls.Add(this.details_cat_full_name);
            this.detailsgroup.Controls.Add(this.details_company_name);
            this.detailsgroup.Controls.Add(this.tipforfirstselection);
            this.detailsgroup.Location = new System.Drawing.Point(580, 61);
            this.detailsgroup.Name = "detailsgroup";
            this.detailsgroup.Size = new System.Drawing.Size(292, 614);
            this.detailsgroup.TabIndex = 1;
            this.detailsgroup.TabStop = false;
            // 
            // details_open_law_info
            // 
            this.details_open_law_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.details_open_law_info.Location = new System.Drawing.Point(14, 467);
            this.details_open_law_info.Name = "details_open_law_info";
            this.details_open_law_info.Size = new System.Drawing.Size(259, 28);
            this.details_open_law_info.TabIndex = 6;
            this.details_open_law_info.Text = "Пункты назначения и ЮИ";
            this.details_open_law_info.UseVisualStyleBackColor = true;
            this.details_open_law_info.Visible = false;
            this.details_open_law_info.Click += new System.EventHandler(this.details_open_law_info_Click);
            // 
            // details_web_img
            // 
            this.details_web_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.details_web_img.Image = ((System.Drawing.Image)(resources.GetObject("details_web_img.Image")));
            this.details_web_img.Location = new System.Drawing.Point(14, 428);
            this.details_web_img.Name = "details_web_img";
            this.details_web_img.Size = new System.Drawing.Size(26, 24);
            this.details_web_img.TabIndex = 5;
            this.details_web_img.TabStop = false;
            this.details_web_img.Visible = false;
            // 
            // details_phone_img
            // 
            this.details_phone_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.details_phone_img.Image = ((System.Drawing.Image)(resources.GetObject("details_phone_img.Image")));
            this.details_phone_img.Location = new System.Drawing.Point(14, 404);
            this.details_phone_img.Name = "details_phone_img";
            this.details_phone_img.Size = new System.Drawing.Size(26, 24);
            this.details_phone_img.TabIndex = 5;
            this.details_phone_img.TabStop = false;
            this.details_phone_img.Visible = false;
            // 
            // details_open_planes_form
            // 
            this.details_open_planes_form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.details_open_planes_form.Location = new System.Drawing.Point(14, 547);
            this.details_open_planes_form.Name = "details_open_planes_form";
            this.details_open_planes_form.Size = new System.Drawing.Size(259, 47);
            this.details_open_planes_form.TabIndex = 4;
            this.details_open_planes_form.Text = "Флот самолётов";
            this.details_open_planes_form.UseVisualStyleBackColor = true;
            this.details_open_planes_form.Visible = false;
            this.details_open_planes_form.Click += new System.EventHandler(this.details_open_planes_form_Click);
            // 
            // details_ceo_name
            // 
            this.details_ceo_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.details_ceo_name.Location = new System.Drawing.Point(138, 215);
            this.details_ceo_name.Name = "details_ceo_name";
            this.details_ceo_name.Size = new System.Drawing.Size(135, 28);
            this.details_ceo_name.TabIndex = 3;
            this.details_ceo_name.Visible = false;
            // 
            // details_planes_count
            // 
            this.details_planes_count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.details_planes_count.Location = new System.Drawing.Point(138, 531);
            this.details_planes_count.Name = "details_planes_count";
            this.details_planes_count.Size = new System.Drawing.Size(135, 13);
            this.details_planes_count.TabIndex = 3;
            this.details_planes_count.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.details_planes_count.Visible = false;
            // 
            // details_year_of_found
            // 
            this.details_year_of_found.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.details_year_of_found.Location = new System.Drawing.Point(138, 189);
            this.details_year_of_found.Name = "details_year_of_found";
            this.details_year_of_found.Size = new System.Drawing.Size(135, 13);
            this.details_year_of_found.TabIndex = 3;
            this.details_year_of_found.Visible = false;
            // 
            // details_description
            // 
            this.details_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.details_description.Location = new System.Drawing.Point(11, 262);
            this.details_description.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.details_description.Name = "details_description";
            this.details_description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.details_description.Size = new System.Drawing.Size(275, 142);
            this.details_description.TabIndex = 3;
            this.details_description.Visible = false;
            // 
            // details_full_name
            // 
            this.details_full_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.details_full_name.Location = new System.Drawing.Point(138, 143);
            this.details_full_name.Name = "details_full_name";
            this.details_full_name.Size = new System.Drawing.Size(148, 37);
            this.details_full_name.TabIndex = 3;
            this.details_full_name.Visible = false;
            // 
            // details_site
            // 
            this.details_site.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.details_site.Cursor = System.Windows.Forms.Cursors.Hand;
            this.details_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_site.ForeColor = System.Drawing.Color.Blue;
            this.details_site.Location = new System.Drawing.Point(46, 428);
            this.details_site.Name = "details_site";
            this.details_site.Size = new System.Drawing.Size(235, 24);
            this.details_site.TabIndex = 2;
            this.details_site.Text = "difres.ru";
            this.details_site.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.details_site.Visible = false;
            this.details_site.Click += new System.EventHandler(this.details_site_Click);
            // 
            // details_phone
            // 
            this.details_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.details_phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.details_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_phone.ForeColor = System.Drawing.Color.Blue;
            this.details_phone.Location = new System.Drawing.Point(46, 404);
            this.details_phone.Name = "details_phone";
            this.details_phone.Size = new System.Drawing.Size(238, 24);
            this.details_phone.TabIndex = 2;
            this.details_phone.Text = "+7 777 777 77 77";
            this.details_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.details_phone.Visible = false;
            this.details_phone.Click += new System.EventHandler(this.details_phone_Click);
            // 
            // details_cat_description
            // 
            this.details_cat_description.AutoSize = true;
            this.details_cat_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_cat_description.Location = new System.Drawing.Point(11, 247);
            this.details_cat_description.Name = "details_cat_description";
            this.details_cat_description.Size = new System.Drawing.Size(69, 13);
            this.details_cat_description.TabIndex = 2;
            this.details_cat_description.Text = "Описание:";
            this.details_cat_description.Visible = false;
            // 
            // details_cat_ceo
            // 
            this.details_cat_ceo.AutoSize = true;
            this.details_cat_ceo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_cat_ceo.Location = new System.Drawing.Point(11, 215);
            this.details_cat_ceo.Name = "details_cat_ceo";
            this.details_cat_ceo.Size = new System.Drawing.Size(69, 13);
            this.details_cat_ceo.TabIndex = 2;
            this.details_cat_ceo.Text = "Директор:";
            this.details_cat_ceo.Visible = false;
            // 
            // details_cat_year
            // 
            this.details_cat_year.AutoSize = true;
            this.details_cat_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_cat_year.Location = new System.Drawing.Point(11, 189);
            this.details_cat_year.Name = "details_cat_year";
            this.details_cat_year.Size = new System.Drawing.Size(108, 13);
            this.details_cat_year.TabIndex = 2;
            this.details_cat_year.Text = "Дата основания:";
            this.details_cat_year.Visible = false;
            // 
            // details_cat_planes_count
            // 
            this.details_cat_planes_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.details_cat_planes_count.AutoSize = true;
            this.details_cat_planes_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_cat_planes_count.Location = new System.Drawing.Point(11, 531);
            this.details_cat_planes_count.Name = "details_cat_planes_count";
            this.details_cat_planes_count.Size = new System.Drawing.Size(111, 13);
            this.details_cat_planes_count.TabIndex = 2;
            this.details_cat_planes_count.Text = "Флот самолетов:";
            this.details_cat_planes_count.Visible = false;
            // 
            // details_cat_full_name
            // 
            this.details_cat_full_name.AutoSize = true;
            this.details_cat_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_cat_full_name.Location = new System.Drawing.Point(11, 143);
            this.details_cat_full_name.Name = "details_cat_full_name";
            this.details_cat_full_name.Size = new System.Drawing.Size(115, 13);
            this.details_cat_full_name.TabIndex = 2;
            this.details_cat_full_name.Text = "Полное название:";
            this.details_cat_full_name.Visible = false;
            // 
            // details_company_name
            // 
            this.details_company_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.details_company_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_company_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.details_company_name.Location = new System.Drawing.Point(5, 16);
            this.details_company_name.Name = "details_company_name";
            this.details_company_name.Size = new System.Drawing.Size(279, 67);
            this.details_company_name.TabIndex = 1;
            this.details_company_name.Text = "label1";
            this.details_company_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.details_company_name.Visible = false;
            // 
            // tipforfirstselection
            // 
            this.tipforfirstselection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipforfirstselection.Location = new System.Drawing.Point(6, 16);
            this.tipforfirstselection.Name = "tipforfirstselection";
            this.tipforfirstselection.Size = new System.Drawing.Size(280, 595);
            this.tipforfirstselection.TabIndex = 0;
            this.tipforfirstselection.Text = "Для просмотра подробностей выберите компанию из списка слева";
            this.tipforfirstselection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйФайлToolStripMenuItem,
            this.toolStripSeparator3,
            this.открытьФайлобразецToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьНовыйФайлToolStripMenuItem
            // 
            this.создатьНовыйФайлToolStripMenuItem.Name = "создатьНовыйФайлToolStripMenuItem";
            this.создатьНовыйФайлToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.создатьНовыйФайлToolStripMenuItem.Text = "Создать новый файл";
            this.создатьНовыйФайлToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйФайлToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // открытьФайлобразецToolStripMenuItem
            // 
            this.открытьФайлобразецToolStripMenuItem.Name = "открытьФайлобразецToolStripMenuItem";
            this.открытьФайлобразецToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.открытьФайлобразецToolStripMenuItem.Text = "Открыть файл-образец";
            this.открытьФайлобразецToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлобразецToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.del_comp_but);
            this.groupBox1.Controls.Add(this.edit_comp_but);
            this.groupBox1.Controls.Add(this.add_comp_but);
            this.groupBox1.Location = new System.Drawing.Point(18, 616);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с компаниями";
            // 
            // del_comp_but
            // 
            this.del_comp_but.Enabled = false;
            this.del_comp_but.Location = new System.Drawing.Point(186, 19);
            this.del_comp_but.Name = "del_comp_but";
            this.del_comp_but.Size = new System.Drawing.Size(84, 31);
            this.del_comp_but.TabIndex = 0;
            this.del_comp_but.Text = "Удалить";
            this.del_comp_but.UseVisualStyleBackColor = true;
            this.del_comp_but.Click += new System.EventHandler(this.del_comp_but_Click);
            // 
            // edit_comp_but
            // 
            this.edit_comp_but.Enabled = false;
            this.edit_comp_but.Location = new System.Drawing.Point(96, 19);
            this.edit_comp_but.Name = "edit_comp_but";
            this.edit_comp_but.Size = new System.Drawing.Size(84, 31);
            this.edit_comp_but.TabIndex = 0;
            this.edit_comp_but.Text = "Изменить";
            this.edit_comp_but.UseVisualStyleBackColor = true;
            this.edit_comp_but.Click += new System.EventHandler(this.edit_comp_but_Click);
            // 
            // add_comp_but
            // 
            this.add_comp_but.Location = new System.Drawing.Point(6, 19);
            this.add_comp_but.Name = "add_comp_but";
            this.add_comp_but.Size = new System.Drawing.Size(84, 31);
            this.add_comp_but.TabIndex = 0;
            this.add_comp_but.Text = "Добавить";
            this.add_comp_but.UseVisualStyleBackColor = true;
            this.add_comp_but.Click += new System.EventHandler(this.add_comp_but_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(305, 616);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 59);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация";
            // 
            // save_as_dialog
            // 
            this.save_as_dialog.DefaultExt = "xml";
            this.save_as_dialog.Filter = "XML-файлы (*.xml)|*.xml";
            this.save_as_dialog.Title = "Сохранить файл как...";
            // 
            // load_file_dialog
            // 
            this.load_file_dialog.DefaultExt = "xml";
            this.load_file_dialog.Filter = "XML-Файлы|*.xml";
            this.load_file_dialog.Title = "Открыть файл с данными";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detailsgroup);
            this.Controls.Add(this.detailslabel);
            this.Controls.Add(this.gridforcomp);
            this.Controls.Add(this.labelforcomplist);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИСС \"Авиатранспортные компании\"";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridforcomp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.detailsgroup.ResumeLayout(false);
            this.detailsgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.details_web_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details_phone_img)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelforcomplist;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label detailslabel;
        private System.Windows.Forms.GroupBox detailsgroup;
        private System.Windows.Forms.Label tipforfirstselection;
        private System.Windows.Forms.Label details_company_name;
        private System.Windows.Forms.Label details_full_name;
        private System.Windows.Forms.Label details_cat_full_name;
        private System.Windows.Forms.Label details_year_of_found;
        private System.Windows.Forms.Label details_cat_year;
        private System.Windows.Forms.Label details_ceo_name;
        private System.Windows.Forms.Label details_cat_ceo;
        private System.Windows.Forms.Label details_description;
        private System.Windows.Forms.Label details_cat_description;
        private System.Windows.Forms.Label details_phone;
        private System.Windows.Forms.Label details_site;
        private System.Windows.Forms.Label details_cat_planes_count;
        private System.Windows.Forms.Label details_planes_count;
        private System.Windows.Forms.Button details_open_planes_form;
        private System.Windows.Forms.PictureBox details_web_img;
        private System.Windows.Forms.PictureBox details_phone_img;
        private System.Windows.Forms.Button details_open_law_info;
        public System.Windows.Forms.DataGridView gridforcomp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button del_comp_but;
        private System.Windows.Forms.Button edit_comp_but;
        private System.Windows.Forms.Button add_comp_but;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog save_as_dialog;
        private System.Windows.Forms.OpenFileDialog load_file_dialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлобразецToolStripMenuItem;
    }
}

