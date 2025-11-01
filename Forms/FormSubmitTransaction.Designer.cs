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
            txtClient = new ComboBox();
            txtPackage = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            paramId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Client";
            // 
            // txtClient
            // 
            txtClient.FormattingEnabled = true;
            txtClient.Location = new Point(135, 23);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(492, 33);
            txtClient.TabIndex = 1;
            // 
            // txtPackage
            // 
            txtPackage.FormattingEnabled = true;
            txtPackage.Location = new Point(135, 83);
            txtPackage.Name = "txtPackage";
            txtPackage.Size = new Size(492, 33);
            txtPackage.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 89);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 2;
            label2.Text = "Package";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 151);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 145);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(492, 31);
            textBox1.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(135, 241);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(317, 34);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(471, 241);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // paramId
            // 
            paramId.AutoSize = true;
            paramId.Location = new Point(135, 199);
            paramId.Name = "paramId";
            paramId.Size = new Size(35, 25);
            paramId.TabIndex = 8;
            paramId.Text = "id?";
            // 
            // FormSubmitTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 309);
            Controls.Add(paramId);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtPackage);
            Controls.Add(label2);
            Controls.Add(txtClient);
            Controls.Add(label1);
            Name = "FormSubmitTransaction";
            Text = "FormSubmitTransaction";
            Load += FormSubmitTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox txtClient;
        private ComboBox txtPackage;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button btnSubmit;
        private Button btnCancel;
        private Label paramId;
    }
}