namespace HealthCare.View
{
    partial class PatientHome
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.view_case_label = new System.Windows.Forms.Button();
            this.dashboard_label = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.usertype = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.view_case_label);
            this.panel1.Controls.Add(this.dashboard_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 630);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // view_case_label
            // 
            this.view_case_label.FlatAppearance.BorderSize = 0;
            this.view_case_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_case_label.Location = new System.Drawing.Point(3, 272);
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
            this.dashboard_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.dashboard_label.Location = new System.Drawing.Point(3, 163);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(212, 103);
            this.dashboard_label.TabIndex = 3;
            this.dashboard_label.Text = "DASHBOARD";
            this.dashboard_label.UseVisualStyleBackColor = true;
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.user_id);
            this.main_panel.Controls.Add(this.label4);
            this.main_panel.Controls.Add(this.logout);
            this.main_panel.Controls.Add(this.usertype);
            this.main_panel.Controls.Add(this.username);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Location = new System.Drawing.Point(237, 28);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(694, 573);
            this.main_panel.TabIndex = 18;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.logout.CausesValidation = false;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logout.Location = new System.Drawing.Point(538, 514);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(132, 36);
            this.logout.TabIndex = 29;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // usertype
            // 
            this.usertype.AutoSize = true;
            this.usertype.Location = new System.Drawing.Point(279, 118);
            this.usertype.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(125, 23);
            this.usertype.TabIndex = 25;
            this.usertype.Text = "<user-type>";
            this.usertype.Click += new System.EventHandler(this.usertype_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(279, 51);
            this.username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(131, 23);
            this.username.TabIndex = 24;
            this.username.Text = "<username>";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "User-type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Location = new System.Drawing.Point(279, 175);
            this.user_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(100, 23);
            this.user_id.TabIndex = 34;
            this.user_id.Text = "<user_id>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "User ID";
            // 
            // PatientHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(959, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientHome";
            this.Text = "PatientHome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button view_case_label;
        private System.Windows.Forms.Button dashboard_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label usertype;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label label4;
    }
}