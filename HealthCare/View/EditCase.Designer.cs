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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_case_label = new System.Windows.Forms.Button();
            this.view_case_label = new System.Windows.Forms.Button();
            this.dashboard_label = new System.Windows.Forms.Button();
            this.add_case_label = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(143, 534);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 23);
            this.status.TabIndex = 22;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.edit_case_label);
            this.panel1.Controls.Add(this.view_case_label);
            this.panel1.Controls.Add(this.dashboard_label);
            this.panel1.Controls.Add(this.add_case_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 629);
            this.panel1.TabIndex = 24;
            // 
            // edit_case_label
            // 
            this.edit_case_label.FlatAppearance.BorderSize = 0;
            this.edit_case_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_case_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.edit_case_label.Location = new System.Drawing.Point(0, 472);
            this.edit_case_label.Name = "edit_case_label";
            this.edit_case_label.Size = new System.Drawing.Size(212, 103);
            this.edit_case_label.TabIndex = 5;
            this.edit_case_label.Text = "EDIT CASE";
            this.edit_case_label.UseVisualStyleBackColor = true;
            // 
            // view_case_label
            // 
            this.view_case_label.FlatAppearance.BorderSize = 0;
            this.view_case_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_case_label.Location = new System.Drawing.Point(0, 372);
            this.view_case_label.Name = "view_case_label";
            this.view_case_label.Size = new System.Drawing.Size(212, 103);
            this.view_case_label.TabIndex = 4;
            this.view_case_label.Text = "VIEW CASES";
            this.view_case_label.UseVisualStyleBackColor = true;
            this.view_case_label.Click += new System.EventHandler(this.view_case_label_Click);
            // 
            // dashboard_label
            // 
            this.dashboard_label.FlatAppearance.BorderSize = 0;
            this.dashboard_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_label.Location = new System.Drawing.Point(3, 163);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(212, 103);
            this.dashboard_label.TabIndex = 3;
            this.dashboard_label.Text = "DASHBOARD";
            this.dashboard_label.UseVisualStyleBackColor = true;
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // add_case_label
            // 
            this.add_case_label.FlatAppearance.BorderSize = 0;
            this.add_case_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_case_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add_case_label.Location = new System.Drawing.Point(3, 269);
            this.add_case_label.Name = "add_case_label";
            this.add_case_label.Size = new System.Drawing.Size(212, 103);
            this.add_case_label.TabIndex = 2;
            this.add_case_label.Text = "ADD CASE";
            this.add_case_label.UseVisualStyleBackColor = true;
            this.add_case_label.Click += new System.EventHandler(this.add_case_label_Click);
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
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
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
            this.main_panel.Location = new System.Drawing.Point(237, 29);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(694, 573);
            this.main_panel.TabIndex = 25;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.close_button.CausesValidation = false;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close_button.Location = new System.Drawing.Point(385, 473);
            this.close_button.Margin = new System.Windows.Forms.Padding(4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(156, 48);
            this.close_button.TabIndex = 27;
            this.close_button.Text = "CLOSE CASE";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // disease
            // 
            this.disease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.disease.Location = new System.Drawing.Point(140, 246);
            this.disease.Margin = new System.Windows.Forms.Padding(4);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(401, 32);
            this.disease.TabIndex = 26;
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.title.Location = new System.Drawing.Point(140, 166);
            this.title.Margin = new System.Windows.Forms.Padding(4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(401, 32);
            this.title.TabIndex = 25;
            // 
            // patient_id
            // 
            this.patient_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patient_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.patient_id.Location = new System.Drawing.Point(140, 78);
            this.patient_id.Margin = new System.Windows.Forms.Padding(4);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(401, 32);
            this.patient_id.TabIndex = 24;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.edit_button.CausesValidation = false;
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.edit_button.Location = new System.Drawing.Point(140, 473);
            this.edit_button.Margin = new System.Windows.Forms.Padding(4);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(104, 43);
            this.edit_button.TabIndex = 23;
            this.edit_button.Text = "EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 51);
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
            this.label5.Location = new System.Drawing.Point(136, 219);
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
            this.description_label.Location = new System.Drawing.Point(136, 303);
            this.description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(119, 23);
            this.description_label.TabIndex = 17;
            this.description_label.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(140, 330);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(401, 123);
            this.description.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Title";
            // 
            // EditCase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(957, 629);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCase";
            this.Text = "EditCase";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button view_case_label;
        private System.Windows.Forms.Button dashboard_label;
        private System.Windows.Forms.Button add_case_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button edit_case_label;
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
    }
}