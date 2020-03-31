namespace inf_system_airline_companies
{
    partial class add_or_edit_company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_or_edit_company));
            this.main_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.company_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.company_full_name = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ceo_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type_of_comp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.city = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.website = new System.Windows.Forms.TextBox();
            this.add_now = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.Location = new System.Drawing.Point(13, 13);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(559, 60);
            this.main_label.TabIndex = 0;
            this.main_label.Text = "В этом окне происходит редактирование только самой основной информации. Остальные" +
    " элементы можно изменить, зайдя в соответствующие разделы.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название компании";
            // 
            // company_name
            // 
            this.company_name.Location = new System.Drawing.Point(16, 90);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(556, 20);
            this.company_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Полное название компании";
            // 
            // company_full_name
            // 
            this.company_full_name.Location = new System.Drawing.Point(15, 140);
            this.company_full_name.Name = "company_full_name";
            this.company_full_name.Size = new System.Drawing.Size(556, 20);
            this.company_full_name.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 205);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата основания компании";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Директор компании (ФИО)";
            // 
            // ceo_name
            // 
            this.ceo_name.Location = new System.Drawing.Point(206, 205);
            this.ceo_name.Name = "ceo_name";
            this.ceo_name.Size = new System.Drawing.Size(365, 20);
            this.ceo_name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тип компании:";
            // 
            // type_of_comp
            // 
            this.type_of_comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_of_comp.FormattingEnabled = true;
            this.type_of_comp.Items.AddRange(new object[] {
            "Пассажирская",
            "Грузовая",
            "Смешанная"});
            this.type_of_comp.Location = new System.Drawing.Point(206, 262);
            this.type_of_comp.Name = "type_of_comp";
            this.type_of_comp.Size = new System.Drawing.Size(365, 21);
            this.type_of_comp.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(206, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расположение";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(199, 36);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(160, 20);
            this.city.TabIndex = 2;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(10, 36);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(160, 20);
            this.country.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Город";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Страна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Краткое описание";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(18, 397);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(553, 20);
            this.description.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Номер телефона";
            // 
            // phone_num
            // 
            this.phone_num.Location = new System.Drawing.Point(18, 450);
            this.phone_num.Mask = "+0 (999) 000-0000";
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(267, 20);
            this.phone_num.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Веб-сайт";
            // 
            // website
            // 
            this.website.Location = new System.Drawing.Point(303, 450);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(262, 20);
            this.website.TabIndex = 9;
            // 
            // add_now
            // 
            this.add_now.Location = new System.Drawing.Point(439, 508);
            this.add_now.Name = "add_now";
            this.add_now.Size = new System.Drawing.Size(126, 41);
            this.add_now.TabIndex = 10;
            this.add_now.Text = "Что-то сделать";
            this.add_now.UseVisualStyleBackColor = true;
            this.add_now.Click += new System.EventHandler(this.add_now_Click);
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel.Location = new System.Drawing.Point(307, 508);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 41);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // add_or_edit_company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add_now);
            this.Controls.Add(this.website);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.type_of_comp);
            this.Controls.Add(this.ceo_name);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.company_full_name);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_or_edit_company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_or_edit_company";
            this.Load += new System.EventHandler(this.add_or_edit_company_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox company_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox company_full_name;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ceo_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type_of_comp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox phone_num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox website;
        private System.Windows.Forms.Button add_now;
        private System.Windows.Forms.Button cancel;
    }
}