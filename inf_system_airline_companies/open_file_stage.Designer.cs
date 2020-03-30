namespace inf_system_airline_companies
{
    partial class open_file_stage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(open_file_stage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.last_opened_radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.select_my_file = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.create_new_file = new System.Windows.Forms.RadioButton();
            this.start_but = new System.Windows.Forms.Button();
            this.file_name = new System.Windows.Forms.TextBox();
            this.select_file_but = new System.Windows.Forms.Button();
            this.open_demo = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::inf_system_airline_companies.Properties.Resources.about_logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 117);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(143, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "ИСС \"Авиатранспортные компании\"";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(145, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите файл для открытия или создайте новый";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Откройте файл, с которым Вы работали в прошлый раз:";
            // 
            // last_opened_radio
            // 
            this.last_opened_radio.AutoSize = true;
            this.last_opened_radio.Enabled = false;
            this.last_opened_radio.Location = new System.Drawing.Point(16, 175);
            this.last_opened_radio.Name = "last_opened_radio";
            this.last_opened_radio.Size = new System.Drawing.Size(85, 17);
            this.last_opened_radio.TabIndex = 1;
            this.last_opened_radio.Text = "radioButton1";
            this.last_opened_radio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выберите другой файл для открытия:";
            // 
            // select_my_file
            // 
            this.select_my_file.AutoSize = true;
            this.select_my_file.Location = new System.Drawing.Point(16, 256);
            this.select_my_file.Name = "select_my_file";
            this.select_my_file.Size = new System.Drawing.Size(197, 17);
            this.select_my_file.TabIndex = 2;
            this.select_my_file.Text = "Выбрать свой файл для открытия";
            this.select_my_file.UseVisualStyleBackColor = true;
            this.select_my_file.CheckedChanged += new System.EventHandler(this.select_my_file_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(459, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Или начните всё сначала:";
            // 
            // create_new_file
            // 
            this.create_new_file.AutoSize = true;
            this.create_new_file.Location = new System.Drawing.Point(16, 347);
            this.create_new_file.Name = "create_new_file";
            this.create_new_file.Size = new System.Drawing.Size(131, 17);
            this.create_new_file.TabIndex = 4;
            this.create_new_file.Text = "Создать новый файл";
            this.create_new_file.UseVisualStyleBackColor = true;
            // 
            // start_but
            // 
            this.start_but.Location = new System.Drawing.Point(309, 401);
            this.start_but.Name = "start_but";
            this.start_but.Size = new System.Drawing.Size(159, 48);
            this.start_but.TabIndex = 6;
            this.start_but.Text = "Начать работу";
            this.start_but.UseVisualStyleBackColor = true;
            this.start_but.Click += new System.EventHandler(this.start_but_Click);
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(16, 280);
            this.file_name.Name = "file_name";
            this.file_name.ReadOnly = true;
            this.file_name.Size = new System.Drawing.Size(371, 20);
            this.file_name.TabIndex = 7;
            // 
            // select_file_but
            // 
            this.select_file_but.Enabled = false;
            this.select_file_but.Location = new System.Drawing.Point(393, 280);
            this.select_file_but.Name = "select_file_but";
            this.select_file_but.Size = new System.Drawing.Size(75, 23);
            this.select_file_but.TabIndex = 3;
            this.select_file_but.Text = "Выбрать...";
            this.select_file_but.UseVisualStyleBackColor = true;
            this.select_file_but.Click += new System.EventHandler(this.select_file_but_Click);
            // 
            // open_demo
            // 
            this.open_demo.AutoSize = true;
            this.open_demo.Checked = true;
            this.open_demo.Location = new System.Drawing.Point(309, 347);
            this.open_demo.Name = "open_demo";
            this.open_demo.Size = new System.Drawing.Size(143, 17);
            this.open_demo.TabIndex = 5;
            this.open_demo.TabStop = true;
            this.open_demo.Text = "Открыть файл-образец";
            this.open_demo.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML-Файлы|*.xml";
            this.openFileDialog1.Title = "Выбрать свой файл";
            // 
            // open_file_stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.select_file_but);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.start_but);
            this.Controls.Add(this.open_demo);
            this.Controls.Add(this.create_new_file);
            this.Controls.Add(this.select_my_file);
            this.Controls.Add(this.last_opened_radio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "open_file_stage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите файл для открытия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.open_file_stage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton last_opened_radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton select_my_file;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton create_new_file;
        private System.Windows.Forms.Button start_but;
        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.Button select_file_but;
        private System.Windows.Forms.RadioButton open_demo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}