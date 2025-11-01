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
            txtDescription = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            paramId = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 31);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(185, 74);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(205, 31);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 80);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(185, 130);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 31);
            txtPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.HotTrack;
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(110, 222);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(278, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // paramId
            // 
            paramId.Location = new Point(22, 260);
            paramId.Name = "paramId";
            paramId.Size = new Size(54, 32);
            paramId.TabIndex = 8;
            paramId.Text = "id?";
            paramId.UseVisualStyleBackColor = true;
            // 
            // FormSubmitPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 318);
            Controls.Add(paramId);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "FormSubmitPackage";
            Text = "FormSubmit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Button btnSubmit;
        private Button btnCancel;
        private Button paramId;
    }
}