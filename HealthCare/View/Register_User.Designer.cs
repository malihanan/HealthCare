namespace HealthCare
{
    partial class Register_User
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.patient = new System.Windows.Forms.RadioButton();
            this.doctor = new System.Windows.Forms.RadioButton();
            this.pharmacist = new System.Windows.Forms.RadioButton();
            this.labtechnician = new System.Windows.Forms.RadioButton();
            this.register = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.login_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(111, 42);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(147, 20);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(111, 70);
            this.password.Name = "password";
            this.password.PasswordChar = '#';
            this.password.Size = new System.Drawing.Size(147, 20);
            this.password.TabIndex = 4;
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Location = new System.Drawing.Point(15, 108);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(58, 17);
            this.patient.TabIndex = 5;
            this.patient.TabStop = true;
            this.patient.Text = "Patient";
            this.patient.UseVisualStyleBackColor = true;
            // 
            // doctor
            // 
            this.doctor.AutoSize = true;
            this.doctor.Location = new System.Drawing.Point(181, 108);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(57, 17);
            this.doctor.TabIndex = 6;
            this.doctor.TabStop = true;
            this.doctor.Text = "Doctor";
            this.doctor.UseVisualStyleBackColor = true;
            // 
            // pharmacist
            // 
            this.pharmacist.AutoSize = true;
            this.pharmacist.Location = new System.Drawing.Point(181, 146);
            this.pharmacist.Name = "pharmacist";
            this.pharmacist.Size = new System.Drawing.Size(77, 17);
            this.pharmacist.TabIndex = 7;
            this.pharmacist.TabStop = true;
            this.pharmacist.Text = "Pharmacist";
            this.pharmacist.UseVisualStyleBackColor = true;
            // 
            // labtechnician
            // 
            this.labtechnician.AutoSize = true;
            this.labtechnician.Location = new System.Drawing.Point(15, 146);
            this.labtechnician.Name = "labtechnician";
            this.labtechnician.Size = new System.Drawing.Size(99, 17);
            this.labtechnician.TabIndex = 8;
            this.labtechnician.TabStop = true;
            this.labtechnician.Text = "Lab Technician";
            this.labtechnician.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(111, 188);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 9;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(12, 228);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 11;
            // 
            // login_link
            // 
            this.login_link.AutoSize = true;
            this.login_link.Location = new System.Drawing.Point(217, 9);
            this.login_link.Name = "login_link";
            this.login_link.Size = new System.Drawing.Size(33, 13);
            this.login_link.TabIndex = 12;
            this.login_link.TabStop = true;
            this.login_link.Text = "Login";
            this.login_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_link_LinkClicked);
            // 
            // Register_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Controls.Add(this.login_link);
            this.Controls.Add(this.error);
            this.Controls.Add(this.register);
            this.Controls.Add(this.labtechnician);
            this.Controls.Add(this.pharmacist);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register_User";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.RadioButton patient;
        private System.Windows.Forms.RadioButton doctor;
        private System.Windows.Forms.RadioButton pharmacist;
        private System.Windows.Forms.RadioButton labtechnician;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.LinkLabel login_link;
    }
}

