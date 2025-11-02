namespace CarWash.Forms
{
    partial class FormSubmitTransaction
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
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            paramId = new TextBox();
            txtCode = new TextBox();
            label4 = new Label();
            txtPackage = new TextBox();
            btnSearchPackage = new Button();
            txtPackageId = new TextBox();
            txtPlate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 116);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Plate Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 193);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 2;
            label2.Text = "Package";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 277);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(37, 305);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(626, 31);
            txtPrice.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(305, 415);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 62);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(492, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 62);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // paramId
            // 
            paramId.Location = new Point(37, 355);
            paramId.Name = "paramId";
            paramId.Size = new Size(64, 31);
            paramId.TabIndex = 8;
            paramId.Text = "id?";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(37, 63);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(626, 31);
            txtCode.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 35);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Code";
            // 
            // txtPackage
            // 
            txtPackage.Location = new Point(35, 225);
            txtPackage.Name = "txtPackage";
            txtPackage.ReadOnly = true;
            txtPackage.Size = new Size(432, 31);
            txtPackage.TabIndex = 11;
            // 
            // btnSearchPackage
            // 
            btnSearchPackage.BackColor = SystemColors.ActiveCaption;
            btnSearchPackage.Location = new Point(473, 223);
            btnSearchPackage.Name = "btnSearchPackage";
            btnSearchPackage.Size = new Size(92, 34);
            btnSearchPackage.TabIndex = 12;
            btnSearchPackage.Text = "Search";
            btnSearchPackage.UseVisualStyleBackColor = false;
            btnSearchPackage.Click += btnSearchPackage_Click;
            // 
            // txtPackageId
            // 
            txtPackageId.Location = new Point(571, 225);
            txtPackageId.Name = "txtPackageId";
            txtPackageId.ReadOnly = true;
            txtPackageId.Size = new Size(92, 31);
            txtPackageId.TabIndex = 13;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(37, 144);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(626, 31);
            txtPlate.TabIndex = 14;
            // 
            // FormSubmitTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 518);
            Controls.Add(txtPlate);
            Controls.Add(txtPackageId);
            Controls.Add(btnSearchPackage);
            Controls.Add(txtPackage);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(paramId);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSubmitTransaction";
            Text = "Create New Transaction";
            Load += FormSubmitTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Button btnSubmit;
        private Button btnCancel;
        private TextBox paramId;
        private TextBox txtCode;
        private Label label4;
        private TextBox txtPackage;
        private Button btnSearchPackage;
        private TextBox txtPackageId;
        private TextBox txtPlate;
    }
}