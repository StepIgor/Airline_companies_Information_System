namespace inf_system_airline_companies
{
    partial class planes_in_comp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planes_in_comp));
            this.header = new System.Windows.Forms.Label();
            this.gridforplanes = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsblock = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.details_payload_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.details_distance = new System.Windows.Forms.Label();
            this.details_payload = new System.Windows.Forms.Label();
            this.details_vol = new System.Windows.Forms.Label();
            this.details_speed = new System.Windows.Forms.Label();
            this.details_cost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_plane = new System.Windows.Forms.Button();
            this.edit_plane = new System.Windows.Forms.Button();
            this.add_plane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridforplanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            this.detailsblock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.header.Location = new System.Drawing.Point(13, 13);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(644, 30);
            this.header.TabIndex = 0;
            this.header.Text = "Компания > Самолёты";
            // 
            // gridforplanes
            // 
            this.gridforplanes.AllowUserToAddRows = false;
            this.gridforplanes.AllowUserToDeleteRows = false;
            this.gridforplanes.AllowUserToResizeRows = false;
            this.gridforplanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridforplanes.AutoGenerateColumns = false;
            this.gridforplanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridforplanes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridforplanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridforplanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.gridforplanes.DataSource = this.planeBindingSource;
            this.gridforplanes.Location = new System.Drawing.Point(18, 46);
            this.gridforplanes.MultiSelect = false;
            this.gridforplanes.Name = "gridforplanes";
            this.gridforplanes.ReadOnly = true;
            this.gridforplanes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridforplanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridforplanes.Size = new System.Drawing.Size(904, 251);
            this.gridforplanes.TabIndex = 1;
            this.gridforplanes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridforplanes_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataSource = typeof(inf_system_airline_companies.Plane);
            // 
            // detailsblock
            // 
            this.detailsblock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsblock.Controls.Add(this.label2);
            this.detailsblock.Controls.Add(this.label4);
            this.detailsblock.Controls.Add(this.details_payload_label);
            this.detailsblock.Controls.Add(this.label3);
            this.detailsblock.Controls.Add(this.details_distance);
            this.detailsblock.Controls.Add(this.details_payload);
            this.detailsblock.Controls.Add(this.details_vol);
            this.detailsblock.Controls.Add(this.details_speed);
            this.detailsblock.Controls.Add(this.details_cost);
            this.detailsblock.Controls.Add(this.label1);
            this.detailsblock.Location = new System.Drawing.Point(18, 304);
            this.detailsblock.Name = "detailsblock";
            this.detailsblock.Size = new System.Drawing.Size(904, 100);
            this.detailsblock.TabIndex = 2;
            this.detailsblock.TabStop = false;
            this.detailsblock.Text = "Подробности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Скорость полета:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(321, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Расстояние полета:";
            // 
            // details_payload_label
            // 
            this.details_payload_label.AutoSize = true;
            this.details_payload_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_payload_label.Location = new System.Drawing.Point(618, 26);
            this.details_payload_label.Name = "details_payload_label";
            this.details_payload_label.Size = new System.Drawing.Size(154, 16);
            this.details_payload_label.TabIndex = 0;
            this.details_payload_label.Text = "Грузоподъемность:";
            this.details_payload_label.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(321, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вместимость:";
            // 
            // details_distance
            // 
            this.details_distance.AutoSize = true;
            this.details_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_distance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.details_distance.Location = new System.Drawing.Point(500, 62);
            this.details_distance.Name = "details_distance";
            this.details_distance.Size = new System.Drawing.Size(39, 16);
            this.details_distance.TabIndex = 0;
            this.details_distance.Text = "0 Км";
            // 
            // details_payload
            // 
            this.details_payload.AutoSize = true;
            this.details_payload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_payload.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.details_payload.Location = new System.Drawing.Point(799, 26);
            this.details_payload.Name = "details_payload";
            this.details_payload.Size = new System.Drawing.Size(36, 16);
            this.details_payload.TabIndex = 0;
            this.details_payload.Text = "0 Кг";
            this.details_payload.Visible = false;
            // 
            // details_vol
            // 
            this.details_vol.AutoSize = true;
            this.details_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_vol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.details_vol.Location = new System.Drawing.Point(500, 26);
            this.details_vol.Name = "details_vol";
            this.details_vol.Size = new System.Drawing.Size(48, 16);
            this.details_vol.TabIndex = 0;
            this.details_vol.Text = "0 Чел";
            // 
            // details_speed
            // 
            this.details_speed.AutoSize = true;
            this.details_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_speed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.details_speed.Location = new System.Drawing.Point(177, 62);
            this.details_speed.Name = "details_speed";
            this.details_speed.Size = new System.Drawing.Size(62, 16);
            this.details_speed.TabIndex = 0;
            this.details_speed.Text = "0 Км / Ч";
            // 
            // details_cost
            // 
            this.details_cost.AutoSize = true;
            this.details_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_cost.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.details_cost.Location = new System.Drawing.Point(177, 26);
            this.details_cost.Name = "details_cost";
            this.details_cost.Size = new System.Drawing.Size(48, 16);
            this.details_cost.TabIndex = 0;
            this.details_cost.Text = "0 Руб";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.delete_plane);
            this.groupBox1.Controls.Add(this.edit_plane);
            this.groupBox1.Controls.Add(this.add_plane);
            this.groupBox1.Location = new System.Drawing.Point(18, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с самолетами";
            // 
            // delete_plane
            // 
            this.delete_plane.Enabled = false;
            this.delete_plane.Location = new System.Drawing.Point(169, 19);
            this.delete_plane.Name = "delete_plane";
            this.delete_plane.Size = new System.Drawing.Size(75, 29);
            this.delete_plane.TabIndex = 0;
            this.delete_plane.Text = "Удалить";
            this.delete_plane.UseVisualStyleBackColor = true;
            this.delete_plane.Click += new System.EventHandler(this.delete_plane_Click);
            // 
            // edit_plane
            // 
            this.edit_plane.Enabled = false;
            this.edit_plane.Location = new System.Drawing.Point(88, 19);
            this.edit_plane.Name = "edit_plane";
            this.edit_plane.Size = new System.Drawing.Size(75, 29);
            this.edit_plane.TabIndex = 0;
            this.edit_plane.Text = "Изменить";
            this.edit_plane.UseVisualStyleBackColor = true;
            this.edit_plane.Click += new System.EventHandler(this.edit_plane_Click);
            // 
            // add_plane
            // 
            this.add_plane.Location = new System.Drawing.Point(7, 20);
            this.add_plane.Name = "add_plane";
            this.add_plane.Size = new System.Drawing.Size(75, 29);
            this.add_plane.TabIndex = 0;
            this.add_plane.Text = "Добавить";
            this.add_plane.UseVisualStyleBackColor = true;
            this.add_plane.Click += new System.EventHandler(this.add_plane_Click);
            // 
            // planes_in_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detailsblock);
            this.Controls.Add(this.gridforplanes);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 590);
            this.Name = "planes_in_comp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "??? | Самолёты компании";
            this.Load += new System.EventHandler(this.planes_in_comp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridforplanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).EndInit();
            this.detailsblock.ResumeLayout(false);
            this.detailsblock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.DataGridView gridforplanes;
        private System.Windows.Forms.BindingSource planeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox detailsblock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label details_distance;
        private System.Windows.Forms.Label details_vol;
        private System.Windows.Forms.Label details_speed;
        private System.Windows.Forms.Label details_cost;
        private System.Windows.Forms.Label details_payload_label;
        private System.Windows.Forms.Label details_payload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_plane;
        private System.Windows.Forms.Button edit_plane;
        private System.Windows.Forms.Button add_plane;
    }
}