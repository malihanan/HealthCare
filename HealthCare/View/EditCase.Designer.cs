namespace HealthCare.View
{
    partial class EditCase
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
            this.status = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.prescriptionGridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.disease = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.patient_id = new System.Windows.Forms.TextBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PrescribedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescribedMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescribedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescribedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescribedDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.status.Location = new System.Drawing.Point(21, 469);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 21);
            this.status.TabIndex = 22;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Controls.Add(this.back_button);
            this.main_panel.Controls.Add(this.prescriptionGridView);
            this.main_panel.Controls.Add(this.searchBox);
            this.main_panel.Controls.Add(this.searchGridView);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.close_button);
            this.main_panel.Controls.Add(this.disease);
            this.main_panel.Controls.Add(this.status);
            this.main_panel.Controls.Add(this.title);
            this.main_panel.Controls.Add(this.patient_id);
            this.main_panel.Controls.Add(this.edit_button);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.label5);
            this.main_panel.Controls.Add(this.description_label);
            this.main_panel.Controls.Add(this.description);
            this.main_panel.Controls.Add(this.label4);
            this.main_panel.Location = new System.Drawing.Point(27, 29);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(904, 573);
            this.main_panel.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Prescribed Medicines";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.Control;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(801, 511);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(78, 40);
            this.back_button.TabIndex = 33;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // prescriptionGridView
            // 
            this.prescriptionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.prescriptionGridView.BackgroundColor = System.Drawing.Color.White;
            this.prescriptionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prescriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrescribedId,
            this.PrescribedMedicine,
            this.PrescribedTime,
            this.PrescribedAmount,
            this.PrescribedDays,
            this.Save,
            this.Delete});
            this.prescriptionGridView.Location = new System.Drawing.Point(311, 330);
            this.prescriptionGridView.Name = "prescriptionGridView";
            this.prescriptionGridView.RowHeadersWidth = 51;
            this.prescriptionGridView.RowTemplate.Height = 24;
            this.prescriptionGridView.Size = new System.Drawing.Size(590, 160);
            this.prescriptionGridView.TabIndex = 32;
            this.prescriptionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prescriptionGridView_CellContentClick);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(311, 128);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(568, 32);
            this.searchBox.TabIndex = 31;
            this.searchBox.Text = "\r\n";
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // searchGridView
            // 
            this.searchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchGridView.BackgroundColor = System.Drawing.Color.White;
            this.searchGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medicine,
            this.Time,
            this.Amount,
            this.Days,
            this.Add});
            this.searchGridView.Location = new System.Drawing.Point(311, 166);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.RowHeadersWidth = 51;
            this.searchGridView.RowTemplate.Height = 24;
            this.searchGridView.Size = new System.Drawing.Size(568, 120);
            this.searchGridView.TabIndex = 30;
            this.searchGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Add Prescription";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.close_button.CausesValidation = false;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button.Location = new System.Drawing.Point(614, 513);
            this.close_button.Margin = new System.Windows.Forms.Padding(4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(145, 36);
            this.close_button.TabIndex = 27;
            this.close_button.Text = "CLOSE CASE";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // disease
            // 
            this.disease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.disease.Location = new System.Drawing.Point(584, 45);
            this.disease.Margin = new System.Windows.Forms.Padding(4);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(295, 32);
            this.disease.TabIndex = 26;
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.title.Location = new System.Drawing.Point(244, 45);
            this.title.Margin = new System.Windows.Forms.Padding(4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(316, 32);
            this.title.TabIndex = 25;
            // 
            // patient_id
            // 
            this.patient_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patient_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.patient_id.Location = new System.Drawing.Point(25, 45);
            this.patient_id.Margin = new System.Windows.Forms.Padding(4);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(194, 32);
            this.patient_id.TabIndex = 24;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.edit_button.CausesValidation = false;
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.edit_button.Location = new System.Drawing.Point(311, 513);
            this.edit_button.Margin = new System.Windows.Forms.Padding(4);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(85, 36);
            this.edit_button.TabIndex = 23;
            this.edit_button.Text = "SAVE";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Patient ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Disease";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(21, 97);
            this.description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(119, 23);
            this.description_label.TabIndex = 17;
            this.description_label.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(25, 128);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(262, 287);
            this.description.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Title";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
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
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 82;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 117;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 6;
            this.Days.Name = "Days";
            this.Days.Width = 87;
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Text = "Add";
            this.Add.ToolTipText = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            this.Add.Width = 59;
            // 
            // PrescribedId
            // 
            this.PrescribedId.DataPropertyName = "MedicineId";
            this.PrescribedId.HeaderText = "Id";
            this.PrescribedId.MinimumWidth = 6;
            this.PrescribedId.Name = "PrescribedId";
            this.PrescribedId.ReadOnly = true;
            this.PrescribedId.Width = 58;
            // 
            // PrescribedMedicine
            // 
            this.PrescribedMedicine.DataPropertyName = "Name";
            this.PrescribedMedicine.HeaderText = "Medicine";
            this.PrescribedMedicine.MinimumWidth = 6;
            this.PrescribedMedicine.Name = "PrescribedMedicine";
            this.PrescribedMedicine.ReadOnly = true;
            this.PrescribedMedicine.Width = 127;
            // 
            // PrescribedTime
            // 
            this.PrescribedTime.DataPropertyName = "Time";
            this.PrescribedTime.HeaderText = "Time";
            this.PrescribedTime.MinimumWidth = 6;
            this.PrescribedTime.Name = "PrescribedTime";
            this.PrescribedTime.Width = 82;
            // 
            // PrescribedAmount
            // 
            this.PrescribedAmount.DataPropertyName = "Amount";
            this.PrescribedAmount.HeaderText = "Amount";
            this.PrescribedAmount.MinimumWidth = 6;
            this.PrescribedAmount.Name = "PrescribedAmount";
            this.PrescribedAmount.Width = 117;
            // 
            // PrescribedDays
            // 
            this.PrescribedDays.DataPropertyName = "Days";
            this.PrescribedDays.HeaderText = "Days";
            this.PrescribedDays.MinimumWidth = 6;
            this.PrescribedDays.Name = "PrescribedDays";
            this.PrescribedDays.Width = 87;
            // 
            // Save
            // 
            this.Save.HeaderText = "Save";
            this.Save.MinimumWidth = 6;
            this.Save.Name = "Save";
            this.Save.Text = "Save";
            this.Save.ToolTipText = "Save";
            this.Save.UseColumnTextForButtonValue = true;
            this.Save.Width = 66;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 82;
            // 
            // EditCase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(957, 629);
            this.Controls.Add(this.main_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCase";
            this.Text = "EditCase";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.TextBox disease;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox patient_id;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.DataGridView prescriptionGridView;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescribedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescribedMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescribedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescribedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescribedDays;
        private System.Windows.Forms.DataGridViewButtonColumn Save;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
    }
}