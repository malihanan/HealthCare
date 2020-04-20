namespace HealthCare.View
{
    partial class ViewCase
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
            this.back_button = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closing_date = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.creation_date = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.closing_summary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.disease = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doctor = new System.Windows.Forms.Label();
            this.case_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(851, 563);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(78, 40);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.dataGridView1);
            this.main_panel.Controls.Add(this.closing_date);
            this.main_panel.Controls.Add(this.label10);
            this.main_panel.Controls.Add(this.creation_date);
            this.main_panel.Controls.Add(this.label9);
            this.main_panel.Controls.Add(this.closing_summary);
            this.main_panel.Controls.Add(this.label7);
            this.main_panel.Controls.Add(this.description);
            this.main_panel.Controls.Add(this.label6);
            this.main_panel.Controls.Add(this.disease);
            this.main_panel.Controls.Add(this.label5);
            this.main_panel.Controls.Add(this.patient);
            this.main_panel.Controls.Add(this.label4);
            this.main_panel.Controls.Add(this.doctor);
            this.main_panel.Controls.Add(this.case_label);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Location = new System.Drawing.Point(24, 29);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(905, 513);
            this.main_panel.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Prescriptions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medicine});
            this.dataGridView1.Location = new System.Drawing.Point(214, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(298, 96);
            this.dataGridView1.TabIndex = 20;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "MedicineId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 58;
            // 
            // Medicine
            // 
            this.Medicine.DataPropertyName = "Name";
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.MinimumWidth = 6;
            this.Medicine.Name = "Medicine";
            this.Medicine.ReadOnly = true;
            this.Medicine.Width = 127;
            // 
            // closing_date
            // 
            this.closing_date.AutoSize = true;
            this.closing_date.Location = new System.Drawing.Point(675, 148);
            this.closing_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.closing_date.Name = "closing_date";
            this.closing_date.Size = new System.Drawing.Size(159, 23);
            this.closing_date.TabIndex = 37;
            this.closing_date.Text = "<closing_date>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Closing Date";
            // 
            // creation_date
            // 
            this.creation_date.AutoSize = true;
            this.creation_date.Location = new System.Drawing.Point(190, 148);
            this.creation_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.creation_date.Name = "creation_date";
            this.creation_date.Size = new System.Drawing.Size(173, 23);
            this.creation_date.TabIndex = 35;
            this.creation_date.Text = "<creation_date>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Creation Date";
            // 
            // closing_summary
            // 
            this.closing_summary.AutoSize = true;
            this.closing_summary.Location = new System.Drawing.Point(190, 291);
            this.closing_summary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.closing_summary.Name = "closing_summary";
            this.closing_summary.Size = new System.Drawing.Size(200, 23);
            this.closing_summary.TabIndex = 33;
            this.closing_summary.Text = "<closing_summary>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 46);
            this.label7.TabIndex = 32;
            this.label7.Text = "Closing\r\nSummary";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(190, 198);
            this.description.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(140, 23);
            this.description.TabIndex = 31;
            this.description.Text = "<description>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Description";
            // 
            // disease
            // 
            this.disease.AutoSize = true;
            this.disease.Location = new System.Drawing.Point(675, 31);
            this.disease.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(107, 23);
            this.disease.TabIndex = 29;
            this.disease.Text = "<disease>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Disease";
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Location = new System.Drawing.Point(675, 87);
            this.patient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(104, 23);
            this.patient.TabIndex = 27;
            this.patient.Text = "<patient>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Patient";
            // 
            // doctor
            // 
            this.doctor.AutoSize = true;
            this.doctor.Location = new System.Drawing.Point(190, 87);
            this.doctor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(100, 23);
            this.doctor.TabIndex = 25;
            this.doctor.Text = "<doctor>";
            // 
            // case_label
            // 
            this.case_label.AutoSize = true;
            this.case_label.Location = new System.Drawing.Point(190, 31);
            this.case_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.case_label.Name = "case_label";
            this.case_label.Size = new System.Drawing.Size(82, 23);
            this.case_label.TabIndex = 24;
            this.case_label.Text = "<case>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Case";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Doctor";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(HealthCare.View.Index);
            // 
            // ViewCase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(957, 630);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.back_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewCase";
            this.Text = "ViewCase";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label doctor;
        private System.Windows.Forms.Label case_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label disease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label closing_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label creation_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label closing_summary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.Label label2;
    }
}