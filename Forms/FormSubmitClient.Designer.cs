namespace CarWash.Forms
{
    partial class FormSubmitClient
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            txtNoPlat = new TextBox();
            label4 = new Label();
            paramId = new Button();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(521, 31);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 98);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 4;
            label2.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 98);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(521, 31);
            txtPhone.TabIndex = 5;
            // 
            // txtNoPlat
            // 
            txtNoPlat.Location = new Point(150, 164);
            txtNoPlat.Name = "txtNoPlat";
            txtNoPlat.Size = new Size(521, 31);
            txtNoPlat.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 170);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 7;
            label4.Text = "No. Plate";
            // 
            // paramId
            // 
            paramId.Location = new Point(55, 224);
            paramId.Name = "paramId";
            paramId.Size = new Size(85, 32);
            paramId.TabIndex = 9;
            paramId.Text = "id?";
            paramId.UseVisualStyleBackColor = true;
            paramId.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(304, 246);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 62);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(499, 246);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 62);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormSubmitClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 359);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(paramId);
            Controls.Add(txtNoPlat);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormSubmitClient";
            Text = "Create New Client";
            Load += FormSubmitClient_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtNoPlat;
        private Label label4;
        private Button paramId;
        private Button btnSubmit;
        private Button btnCancel;
    }
}