namespace inf_system_airline_companies
{
    partial class change_law_number_details
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
            this.what_to_change = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // what_to_change
            // 
            this.what_to_change.AutoSize = true;
            this.what_to_change.Location = new System.Drawing.Point(13, 13);
            this.what_to_change.Name = "what_to_change";
            this.what_to_change.Size = new System.Drawing.Size(87, 13);
            this.what_to_change.TabIndex = 0;
            this.what_to_change.Text = "what_to_change";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 1;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(174, 56);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(104, 39);
            this.accept.TabIndex = 2;
            this.accept.Text = "Применить";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel.Location = new System.Drawing.Point(12, 56);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 39);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // change_law_number_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 107);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.what_to_change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_law_number_details";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Что это?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.change_law_number_details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label what_to_change;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
    }
}