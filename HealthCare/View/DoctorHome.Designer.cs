namespace HealthCare.View
{
    partial class DoctorHome
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
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usertype = new System.Windows.Forms.Label();
            this.detailsForm = new System.Windows.Forms.LinkLabel();
            this.addCase = new System.Windows.Forms.LinkLabel();
            this.viewCases = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(12, 18);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(65, 13);
            this.username.TabIndex = 0;
            this.username.Text = "<username>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Type:";
            // 
            // usertype
            // 
            this.usertype.AutoSize = true;
            this.usertype.Location = new System.Drawing.Point(99, 52);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(62, 13);
            this.usertype.TabIndex = 2;
            this.usertype.Text = "<user-type>";
            // 
            // detailsForm
            // 
            this.detailsForm.AutoSize = true;
            this.detailsForm.Location = new System.Drawing.Point(12, 85);
            this.detailsForm.Name = "detailsForm";
            this.detailsForm.Size = new System.Drawing.Size(88, 13);
            this.detailsForm.TabIndex = 3;
            this.detailsForm.TabStop = true;
            this.detailsForm.Text = "Add More Details";
            this.detailsForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.detailsForm_LinkClicked);
            // 
            // addCase
            // 
            this.addCase.AutoSize = true;
            this.addCase.Location = new System.Drawing.Point(12, 112);
            this.addCase.Name = "addCase";
            this.addCase.Size = new System.Drawing.Size(53, 13);
            this.addCase.TabIndex = 4;
            this.addCase.TabStop = true;
            this.addCase.Text = "Add Case";
            this.addCase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addCase_LinkClicked);
            // 
            // viewCases
            // 
            this.viewCases.AutoSize = true;
            this.viewCases.Location = new System.Drawing.Point(12, 137);
            this.viewCases.Name = "viewCases";
            this.viewCases.Size = new System.Drawing.Size(62, 13);
            this.viewCases.TabIndex = 5;
            this.viewCases.TabStop = true;
            this.viewCases.Text = "View Cases";
            this.viewCases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewCases_LinkClicked);
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.viewCases);
            this.Controls.Add(this.addCase);
            this.Controls.Add(this.detailsForm);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Name = "DoctorHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usertype;
        private System.Windows.Forms.LinkLabel detailsForm;
        private System.Windows.Forms.LinkLabel addCase;
        private System.Windows.Forms.LinkLabel viewCases;
    }
}