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
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSearchPackage).BeginInit();
            SuspendLayout();
            // 
            // dgvSearchPackage
            // 
            dgvSearchPackage.BackgroundColor = SystemColors.ControlLight;
            dgvSearchPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchPackage.Location = new Point(24, 38);
            dgvSearchPackage.Name = "dgvSearchPackage";
            dgvSearchPackage.RowHeadersWidth = 62;
            dgvSearchPackage.Size = new Size(1353, 339);
            dgvSearchPackage.TabIndex = 0;
            dgvSearchPackage.CellContentDoubleClick += dgvSearchPackage_CellContentDoubleClick;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1206, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 62);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1007, 400);
            button2.Name = "button2";
            button2.Size = new Size(171, 62);
            button2.TabIndex = 2;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormSearchPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 496);
            Controls.Add(button2);
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
        private Button button2;
    }
}