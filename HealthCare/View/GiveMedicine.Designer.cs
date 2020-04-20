namespace HealthCare.View
{
    partial class GiveMedicine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.give_medicine_label = new System.Windows.Forms.Button();
            this.dashboard_label = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Give = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.give_medicine_label);
            this.panel1.Controls.Add(this.dashboard_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 629);
            this.panel1.TabIndex = 21;
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(0, 562);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(212, 63);
            this.exit_button.TabIndex = 19;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // give_medicine_label
            // 
            this.give_medicine_label.FlatAppearance.BorderSize = 0;
            this.give_medicine_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.give_medicine_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.give_medicine_label.Location = new System.Drawing.Point(3, 272);
            this.give_medicine_label.Name = "give_medicine_label";
            this.give_medicine_label.Size = new System.Drawing.Size(212, 103);
            this.give_medicine_label.TabIndex = 4;
            this.give_medicine_label.Text = "GIVE MEDICINE";
            this.give_medicine_label.UseVisualStyleBackColor = true;
            // 
            // dashboard_label
            // 
            this.dashboard_label.FlatAppearance.BorderSize = 0;
            this.dashboard_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_label.Location = new System.Drawing.Point(3, 163);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(212, 103);
            this.dashboard_label.TabIndex = 3;
            this.dashboard_label.Text = "DASHBOARD";
            this.dashboard_label.UseVisualStyleBackColor = true;
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 100);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(21, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 70);
            this.label6.TabIndex = 0;
            this.label6.Text = "Care+";
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.error);
            this.main_panel.Controls.Add(this.checkout);
            this.main_panel.Controls.Add(this.search);
            this.main_panel.Controls.Add(this.dataGridView1);
            this.main_panel.Controls.Add(this.patient_id);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Location = new System.Drawing.Point(237, 27);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(694, 573);
            this.main_panel.TabIndex = 22;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(30, 509);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 23);
            this.error.TabIndex = 34;
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.checkout.CausesValidation = false;
            this.checkout.FlatAppearance.BorderSize = 0;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkout.Location = new System.Drawing.Point(502, 509);
            this.checkout.Margin = new System.Windows.Forms.Padding(4);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(132, 36);
            this.checkout.TabIndex = 33;
            this.checkout.Text = "CHECKOUT";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.search.CausesValidation = false;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search.Location = new System.Drawing.Point(502, 76);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 36);
            this.search.TabIndex = 32;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Give,
            this.Id,
            this.Medicine,
            this.Time,
            this.Amount,
            this.Days});
            this.dataGridView1.Location = new System.Drawing.Point(34, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 313);
            this.dataGridView1.TabIndex = 31;
            // 
            // Give
            // 
            this.Give.HeaderText = "Give";
            this.Give.MinimumWidth = 6;
            this.Give.Name = "Give";
            this.Give.ReadOnly = true;
            this.Give.Width = 62;
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
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 82;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 117;
            // 
            // Days
            // 
            this.Days.DataPropertyName = "Days";
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 6;
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.Width = 87;
            // 
            // patient_id
            // 
            this.patient_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patient_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.patient_id.Location = new System.Drawing.Point(153, 20);
            this.patient_id.Margin = new System.Windows.Forms.Padding(4);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(481, 32);
            this.patient_id.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Patient Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prescription";
            // 
            // GiveMedicine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(957, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiveMedicine";
            this.Text = "GiveMedicine";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button give_medicine_label;
        private System.Windows.Forms.Button dashboard_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox patient_id;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Give;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
    }
}