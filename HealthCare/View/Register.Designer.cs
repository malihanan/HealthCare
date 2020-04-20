namespace HealthCare.View
{
    partial class Register
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
            this.register_label = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.labtechnician = new System.Windows.Forms.RadioButton();
            this.pharmacist = new System.Windows.Forms.RadioButton();
            this.doctor = new System.Windows.Forms.RadioButton();
            this.patient = new System.Windows.Forms.RadioButton();
            this.login_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_label
            // 
            this.register_label.FlatAppearance.BorderSize = 0;
            this.register_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.register_label.Location = new System.Drawing.Point(0, 263);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(212, 103);
            this.register_label.TabIndex = 3;
            this.register_label.Text = "REGISTER";
            this.register_label.UseVisualStyleBackColor = true;
            // 
            // login_label
            // 
            this.login_label.FlatAppearance.BorderSize = 0;
            this.login_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_label.Location = new System.Drawing.Point(0, 165);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(212, 103);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "LOGIN";
            this.login_label.UseVisualStyleBackColor = true;
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Care+";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 100);
            this.panel2.TabIndex = 0;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.error);
            this.main_panel.Controls.Add(this.labtechnician);
            this.main_panel.Controls.Add(this.pharmacist);
            this.main_panel.Controls.Add(this.doctor);
            this.main_panel.Controls.Add(this.patient);
            this.main_panel.Controls.Add(this.login_button);
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.password);
            this.main_panel.Controls.Add(this.username);
            this.main_panel.Location = new System.Drawing.Point(237, 25);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(694, 483);
            this.main_panel.TabIndex = 4;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(139, 426);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 23);
            this.error.TabIndex = 17;
            // 
            // labtechnician
            // 
            this.labtechnician.AutoSize = true;
            this.labtechnician.Location = new System.Drawing.Point(139, 296);
            this.labtechnician.Margin = new System.Windows.Forms.Padding(4);
            this.labtechnician.Name = "labtechnician";
            this.labtechnician.Size = new System.Drawing.Size(177, 27);
            this.labtechnician.TabIndex = 16;
            this.labtechnician.TabStop = true;
            this.labtechnician.Text = "Lab Technician";
            this.labtechnician.UseVisualStyleBackColor = true;
            // 
            // pharmacist
            // 
            this.pharmacist.AutoSize = true;
            this.pharmacist.Location = new System.Drawing.Point(360, 296);
            this.pharmacist.Margin = new System.Windows.Forms.Padding(4);
            this.pharmacist.Name = "pharmacist";
            this.pharmacist.Size = new System.Drawing.Size(139, 27);
            this.pharmacist.TabIndex = 15;
            this.pharmacist.TabStop = true;
            this.pharmacist.Text = "Pharmacist";
            this.pharmacist.UseVisualStyleBackColor = true;
            // 
            // doctor
            // 
            this.doctor.AutoSize = true;
            this.doctor.Location = new System.Drawing.Point(360, 249);
            this.doctor.Margin = new System.Windows.Forms.Padding(4);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(98, 27);
            this.doctor.TabIndex = 14;
            this.doctor.TabStop = true;
            this.doctor.Text = "Doctor";
            this.doctor.UseVisualStyleBackColor = true;
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Location = new System.Drawing.Point(139, 249);
            this.patient.Margin = new System.Windows.Forms.Padding(4);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(99, 27);
            this.patient.TabIndex = 13;
            this.patient.TabStop = true;
            this.patient.Text = "Patient";
            this.patient.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.login_button.CausesValidation = false;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_button.Location = new System.Drawing.Point(139, 354);
            this.login_button.Margin = new System.Windows.Forms.Padding(4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(104, 43);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "REGISTER";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.password.Location = new System.Drawing.Point(139, 181);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '#';
            this.password.Size = new System.Drawing.Size(401, 32);
            this.password.TabIndex = 8;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.username.Location = new System.Drawing.Point(139, 92);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(401, 32);
            this.username.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.register_label);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 631);
            this.panel1.TabIndex = 3;
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(0, 566);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(212, 63);
            this.exit_button.TabIndex = 28;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(958, 631);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button register_label;
        private System.Windows.Forms.Button login_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.RadioButton labtechnician;
        private System.Windows.Forms.RadioButton pharmacist;
        private System.Windows.Forms.RadioButton doctor;
        private System.Windows.Forms.RadioButton patient;
        private System.Windows.Forms.Button exit_button;
    }
}