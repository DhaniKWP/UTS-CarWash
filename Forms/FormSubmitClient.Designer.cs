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
            label1.Location = new Point(72, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(195, 45);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(676, 39);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 4;
            label2.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(195, 125);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(676, 39);
            txtPhone.TabIndex = 5;
            // 
            // txtNoPlat
            // 
            txtNoPlat.Location = new Point(195, 210);
            txtNoPlat.Margin = new Padding(4);
            txtNoPlat.Name = "txtNoPlat";
            txtNoPlat.Size = new Size(676, 39);
            txtNoPlat.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 7;
            label4.Text = "No. Plat";
            // 
            // paramId
            // 
            paramId.Location = new Point(72, 287);
            paramId.Margin = new Padding(4);
            paramId.Name = "paramId";
            paramId.Size = new Size(110, 41);
            paramId.TabIndex = 9;
            paramId.Text = "id?";
            paramId.UseVisualStyleBackColor = true;
            paramId.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(395, 315);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(222, 79);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(649, 315);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(222, 79);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormSubmitClient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 459);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(paramId);
            Controls.Add(txtNoPlat);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "FormSubmitClient";
            Text = "Create New Client";
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