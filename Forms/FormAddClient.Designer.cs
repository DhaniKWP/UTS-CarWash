namespace CarWash.Forms
{
    partial class FormAddClient
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
            txtFullName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            txtNoPlat = new TextBox();
            label4 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            paramId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(204, 20);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(541, 39);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 5;
            label2.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(204, 96);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(541, 39);
            txtPhone.TabIndex = 7;
            // 
            // txtNoPlat
            // 
            txtNoPlat.Location = new Point(204, 178);
            txtNoPlat.Name = "txtNoPlat";
            txtNoPlat.Size = new Size(541, 39);
            txtNoPlat.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 10;
            label4.Text = "No. Plat";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Blue;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(204, 324);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(247, 65);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(498, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(247, 65);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // paramId
            // 
            paramId.AutoSize = true;
            paramId.Location = new Point(12, 340);
            paramId.Name = "paramId";
            paramId.Size = new Size(45, 32);
            paramId.TabIndex = 13;
            paramId.Text = "id?";
            // 
            // FormAddClient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 427);
            Controls.Add(paramId);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(txtNoPlat);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "FormAddClient";
            Text = "FormAddClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtNoPlat;
        private Label label4;
        private Button btnSubmit;
        private Button btnCancel;
        private Label paramId;
    }
}