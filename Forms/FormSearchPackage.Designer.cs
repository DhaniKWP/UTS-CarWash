namespace CarWash.Forms
{
    partial class FormSearchPackage
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
            dgvSearchPackage = new DataGridView();
            btnCancel = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSearchPackage).BeginInit();
            SuspendLayout();
            // 
            // dgvSearchPackage
            // 
            dgvSearchPackage.BackgroundColor = Color.White;
            dgvSearchPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchPackage.Location = new Point(24, 38);
            dgvSearchPackage.Name = "dgvSearchPackage";
            dgvSearchPackage.RowHeadersWidth = 62;
            dgvSearchPackage.Size = new Size(1353, 411);
            dgvSearchPackage.TabIndex = 0;
            dgvSearchPackage.CellDoubleClick += dgvSearchPackage_CellContentDoubleClick;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1206, 483);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 62);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.DodgerBlue;
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(1007, 483);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(171, 62);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += button2_Click;
            // 
            // FormSearchPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 582);
            Controls.Add(btnSelect);
            Controls.Add(btnCancel);
            Controls.Add(dgvSearchPackage);
            Name = "FormSearchPackage";
            Text = "Select Package";
            Load += FormSearchPackage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchPackage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSearchPackage;
        private Button btnCancel;
        private Button btnSelect;
    }
}