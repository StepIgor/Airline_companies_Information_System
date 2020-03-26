namespace inf_system_airline_companies
{
    partial class add_or_edit_dest_point
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
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(16, 30);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 20);
            this.country.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Город";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(134, 29);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 2;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(134, 69);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(100, 35);
            this.accept.TabIndex = 3;
            this.accept.Text = "Применить";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel.Location = new System.Drawing.Point(16, 69);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 35);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // add_or_edit_dest_point
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 116);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_or_edit_dest_point";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.add_or_edit_dest_point_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
    }
}