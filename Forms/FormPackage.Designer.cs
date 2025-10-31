namespace CarWash.Forms
{
    partial class FormPackage
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
            lblTitle = new Label();
            txtPackageName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvPackages = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Silver;
            lblTitle.Font = new Font("Wide Latin", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(130, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(568, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PACKAGE MANAGEMENT";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(56, 104);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(220, 31);
            txtPackageName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(56, 150);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 31);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(56, 198);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 31);
            txtPrice.TabIndex = 3;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(31, 264);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(102, 329);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(183, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvPackages
            // 
            dgvPackages.BackgroundColor = SystemColors.ButtonFace;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(339, 91);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 62;
            dgvPackages.Size = new Size(405, 316);
            dgvPackages.TabIndex = 7;
            // 
            // FormPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Azia_Riza__;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPackages);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtPackageName);
            Controls.Add(lblTitle);
            Name = "FormPackage";
            Text = "FormPackage";
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtPackageName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvPackages;
    }
}