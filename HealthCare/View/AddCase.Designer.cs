namespace HealthCare.View
{
    partial class AddCase
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
            this.label1 = new System.Windows.Forms.Label();
            this.patient_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.disease = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Case";
            // 
            // patient_id
            // 
            this.patient_id.Location = new System.Drawing.Point(103, 35);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(155, 20);
            this.patient_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(103, 67);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(155, 20);
            this.title.TabIndex = 6;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(27, 111);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(231, 98);
            this.description.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(103, 258);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(25, 285);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disease";
            // 
            // disease
            // 
            this.disease.Location = new System.Drawing.Point(103, 224);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(155, 20);
            this.disease.TabIndex = 11;
            // 
            // AddCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.disease);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.error);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patient_id);
            this.Controls.Add(this.label1);
            this.Name = "AddCase";
            this.Text = "AddCase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patient_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox disease;
    }
}