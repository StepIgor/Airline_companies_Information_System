namespace inf_system_airline_companies
{
    partial class law_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(law_information));
            this.lawinf_tabcontrol = new System.Windows.Forms.TabControl();
            this.destination_tab = new System.Windows.Forms.TabPage();
            this.del_dest_point_but = new System.Windows.Forms.Button();
            this.edit_dest_point_but = new System.Windows.Forms.Button();
            this.add_dest_point_but = new System.Windows.Forms.Button();
            this.destination_listbox = new System.Windows.Forms.ListBox();
            this.lawinf_maintab = new System.Windows.Forms.TabPage();
            this.lawinf_change_compcost_but = new System.Windows.Forms.Button();
            this.lawinf_changecount_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lawinf_comp_cost = new System.Windows.Forms.Label();
            this.lawinf_count_empl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lawinf_change_cert = new System.Windows.Forms.Button();
            this.lawinf_change_tax = new System.Windows.Forms.Button();
            this.lawinf_cert_inf = new System.Windows.Forms.Label();
            this.lawinf_tax_num = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lawinf_tabcontrol.SuspendLayout();
            this.destination_tab.SuspendLayout();
            this.lawinf_maintab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lawinf_tabcontrol
            // 
            this.lawinf_tabcontrol.Controls.Add(this.destination_tab);
            this.lawinf_tabcontrol.Controls.Add(this.lawinf_maintab);
            this.lawinf_tabcontrol.Controls.Add(this.tabPage2);
            this.lawinf_tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lawinf_tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.lawinf_tabcontrol.Name = "lawinf_tabcontrol";
            this.lawinf_tabcontrol.SelectedIndex = 0;
            this.lawinf_tabcontrol.Size = new System.Drawing.Size(484, 211);
            this.lawinf_tabcontrol.TabIndex = 0;
            // 
            // destination_tab
            // 
            this.destination_tab.Controls.Add(this.del_dest_point_but);
            this.destination_tab.Controls.Add(this.edit_dest_point_but);
            this.destination_tab.Controls.Add(this.add_dest_point_but);
            this.destination_tab.Controls.Add(this.destination_listbox);
            this.destination_tab.Location = new System.Drawing.Point(4, 22);
            this.destination_tab.Name = "destination_tab";
            this.destination_tab.Padding = new System.Windows.Forms.Padding(3);
            this.destination_tab.Size = new System.Drawing.Size(476, 185);
            this.destination_tab.TabIndex = 2;
            this.destination_tab.Text = "Пункты назначения";
            this.destination_tab.UseVisualStyleBackColor = true;
            // 
            // del_dest_point_but
            // 
            this.del_dest_point_but.Enabled = false;
            this.del_dest_point_but.Location = new System.Drawing.Point(372, 65);
            this.del_dest_point_but.Name = "del_dest_point_but";
            this.del_dest_point_but.Size = new System.Drawing.Size(95, 23);
            this.del_dest_point_but.TabIndex = 1;
            this.del_dest_point_but.Text = "Удалить";
            this.del_dest_point_but.UseVisualStyleBackColor = true;
            this.del_dest_point_but.Click += new System.EventHandler(this.del_dest_point_but_Click);
            // 
            // edit_dest_point_but
            // 
            this.edit_dest_point_but.Enabled = false;
            this.edit_dest_point_but.Location = new System.Drawing.Point(372, 36);
            this.edit_dest_point_but.Name = "edit_dest_point_but";
            this.edit_dest_point_but.Size = new System.Drawing.Size(95, 23);
            this.edit_dest_point_but.TabIndex = 1;
            this.edit_dest_point_but.Text = "Изменить";
            this.edit_dest_point_but.UseVisualStyleBackColor = true;
            this.edit_dest_point_but.Click += new System.EventHandler(this.edit_dest_point_but_Click);
            // 
            // add_dest_point_but
            // 
            this.add_dest_point_but.Location = new System.Drawing.Point(373, 7);
            this.add_dest_point_but.Name = "add_dest_point_but";
            this.add_dest_point_but.Size = new System.Drawing.Size(95, 23);
            this.add_dest_point_but.TabIndex = 1;
            this.add_dest_point_but.Text = "Добавить";
            this.add_dest_point_but.UseVisualStyleBackColor = true;
            this.add_dest_point_but.Click += new System.EventHandler(this.add_dest_point_but_Click);
            // 
            // destination_listbox
            // 
            this.destination_listbox.FormattingEnabled = true;
            this.destination_listbox.Location = new System.Drawing.Point(9, 7);
            this.destination_listbox.Name = "destination_listbox";
            this.destination_listbox.Size = new System.Drawing.Size(357, 173);
            this.destination_listbox.TabIndex = 0;
            this.destination_listbox.SelectedIndexChanged += new System.EventHandler(this.destination_listbox_SelectedIndexChanged);
            // 
            // lawinf_maintab
            // 
            this.lawinf_maintab.BackColor = System.Drawing.SystemColors.Menu;
            this.lawinf_maintab.Controls.Add(this.lawinf_change_compcost_but);
            this.lawinf_maintab.Controls.Add(this.lawinf_changecount_but);
            this.lawinf_maintab.Controls.Add(this.label2);
            this.lawinf_maintab.Controls.Add(this.lawinf_comp_cost);
            this.lawinf_maintab.Controls.Add(this.lawinf_count_empl);
            this.lawinf_maintab.Controls.Add(this.label1);
            this.lawinf_maintab.Location = new System.Drawing.Point(4, 22);
            this.lawinf_maintab.Name = "lawinf_maintab";
            this.lawinf_maintab.Padding = new System.Windows.Forms.Padding(3);
            this.lawinf_maintab.Size = new System.Drawing.Size(476, 185);
            this.lawinf_maintab.TabIndex = 0;
            this.lawinf_maintab.Text = "Основное";
            // 
            // lawinf_change_compcost_but
            // 
            this.lawinf_change_compcost_but.Location = new System.Drawing.Point(375, 103);
            this.lawinf_change_compcost_but.Name = "lawinf_change_compcost_but";
            this.lawinf_change_compcost_but.Size = new System.Drawing.Size(93, 41);
            this.lawinf_change_compcost_but.TabIndex = 1;
            this.lawinf_change_compcost_but.Text = "Изменить";
            this.lawinf_change_compcost_but.UseVisualStyleBackColor = true;
            // 
            // lawinf_changecount_but
            // 
            this.lawinf_changecount_but.Location = new System.Drawing.Point(375, 16);
            this.lawinf_changecount_but.Name = "lawinf_changecount_but";
            this.lawinf_changecount_but.Size = new System.Drawing.Size(93, 41);
            this.lawinf_changecount_but.TabIndex = 1;
            this.lawinf_changecount_but.Text = "Изменить";
            this.lawinf_changecount_but.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Средняя стоимость компании:";
            // 
            // lawinf_comp_cost
            // 
            this.lawinf_comp_cost.AutoSize = true;
            this.lawinf_comp_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lawinf_comp_cost.Location = new System.Drawing.Point(17, 133);
            this.lawinf_comp_cost.Name = "lawinf_comp_cost";
            this.lawinf_comp_cost.Size = new System.Drawing.Size(16, 16);
            this.lawinf_comp_cost.TabIndex = 0;
            this.lawinf_comp_cost.Text = "0";
            // 
            // lawinf_count_empl
            // 
            this.lawinf_count_empl.AutoSize = true;
            this.lawinf_count_empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lawinf_count_empl.Location = new System.Drawing.Point(17, 41);
            this.lawinf_count_empl.Name = "lawinf_count_empl";
            this.lawinf_count_empl.Size = new System.Drawing.Size(16, 16);
            this.lawinf_count_empl.TabIndex = 0;
            this.lawinf_count_empl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество сотрудников:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.lawinf_change_cert);
            this.tabPage2.Controls.Add(this.lawinf_change_tax);
            this.tabPage2.Controls.Add(this.lawinf_cert_inf);
            this.tabPage2.Controls.Add(this.lawinf_tax_num);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Документы";
            // 
            // lawinf_change_cert
            // 
            this.lawinf_change_cert.Location = new System.Drawing.Point(375, 105);
            this.lawinf_change_cert.Name = "lawinf_change_cert";
            this.lawinf_change_cert.Size = new System.Drawing.Size(93, 41);
            this.lawinf_change_cert.TabIndex = 3;
            this.lawinf_change_cert.Text = "Изменить";
            this.lawinf_change_cert.UseVisualStyleBackColor = true;
            // 
            // lawinf_change_tax
            // 
            this.lawinf_change_tax.Location = new System.Drawing.Point(375, 17);
            this.lawinf_change_tax.Name = "lawinf_change_tax";
            this.lawinf_change_tax.Size = new System.Drawing.Size(93, 41);
            this.lawinf_change_tax.TabIndex = 3;
            this.lawinf_change_tax.Text = "Изменить";
            this.lawinf_change_tax.UseVisualStyleBackColor = true;
            // 
            // lawinf_cert_inf
            // 
            this.lawinf_cert_inf.AutoSize = true;
            this.lawinf_cert_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lawinf_cert_inf.Location = new System.Drawing.Point(18, 133);
            this.lawinf_cert_inf.Name = "lawinf_cert_inf";
            this.lawinf_cert_inf.Size = new System.Drawing.Size(16, 16);
            this.lawinf_cert_inf.TabIndex = 2;
            this.lawinf_cert_inf.Text = "0";
            // 
            // lawinf_tax_num
            // 
            this.lawinf_tax_num.AutoSize = true;
            this.lawinf_tax_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lawinf_tax_num.Location = new System.Drawing.Point(18, 41);
            this.lawinf_tax_num.Name = "lawinf_tax_num";
            this.lawinf_tax_num.Size = new System.Drawing.Size(16, 16);
            this.lawinf_tax_num.TabIndex = 2;
            this.lawinf_tax_num.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Лицензия на право деятельности:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Номер налогообложения";
            // 
            // law_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.lawinf_tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "law_information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Юридическая информация";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.law_information_Activated);
            this.Load += new System.EventHandler(this.law_information_Load);
            this.lawinf_tabcontrol.ResumeLayout(false);
            this.destination_tab.ResumeLayout(false);
            this.lawinf_maintab.ResumeLayout(false);
            this.lawinf_maintab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl lawinf_tabcontrol;
        private System.Windows.Forms.TabPage lawinf_maintab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lawinf_count_empl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lawinf_comp_cost;
        private System.Windows.Forms.Button lawinf_change_compcost_but;
        private System.Windows.Forms.Button lawinf_changecount_but;
        private System.Windows.Forms.Button lawinf_change_cert;
        private System.Windows.Forms.Button lawinf_change_tax;
        private System.Windows.Forms.Label lawinf_cert_inf;
        private System.Windows.Forms.Label lawinf_tax_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage destination_tab;
        private System.Windows.Forms.ListBox destination_listbox;
        private System.Windows.Forms.Button del_dest_point_but;
        private System.Windows.Forms.Button edit_dest_point_but;
        private System.Windows.Forms.Button add_dest_point_but;
    }
}