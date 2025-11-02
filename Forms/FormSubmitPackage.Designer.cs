namespace CarWash.Forms
{
    partial class FormSubmitPackage
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
            txtName = new TextBox();
            label1 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            paramId = new Button();
            label4 = new Label();
            txtType = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(521, 31);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(158, 130);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(521, 31);
            txtPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 136);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(320, 225);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 62);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(508, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 62);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // paramId
            // 
            paramId.Location = new Point(158, 184);
            paramId.Name = "paramId";
            paramId.Size = new Size(85, 32);
            paramId.TabIndex = 8;
            paramId.Text = "id?";
            paramId.UseVisualStyleBackColor = true;
            paramId.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 83);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 10;
            label4.Text = "Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(158, 74);
            txtType.Name = "txtType";
            txtType.Size = new Size(521, 31);
            txtType.TabIndex = 9;
            // 
            // FormSubmitPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 314);
            Controls.Add(label4);
            Controls.Add(txtType);
            Controls.Add(paramId);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "FormSubmitPackage";
            Text = "Create New Package";
            Load += FormSubmitPackage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtPrice;
        private Label label3;
        private Button btnSubmit;
        private Button btnCancel;
        private Button paramId;
        private Label label4;
        private TextBox txtType;
    }
}