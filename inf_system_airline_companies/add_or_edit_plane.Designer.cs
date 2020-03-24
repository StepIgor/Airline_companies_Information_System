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
            this.apply_but.TabIndex = 1;
            this.apply_but.Text = "Что-то сделать";
            this.apply_but.UseVisualStyleBackColor = true;
            // 
            // cancel_but
            // 
            this.cancel_but.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel_but.Location = new System.Drawing.Point(290, 405);
            this.cancel_but.Name = "cancel_but";
            this.cancel_but.Size = new System.Drawing.Size(99, 44);
            this.cancel_but.TabIndex = 1;
            this.cancel_but.Text = "Отмена";
            this.cancel_but.UseVisualStyleBackColor = true;
            this.cancel_but.Click += new System.EventHandler(this.cancel_but_Click);
            // 
            // add_or_edit_plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 461);
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
    }
}