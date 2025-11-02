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
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(615, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(707, 63);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PACKAGE MANAGEMENT";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(12, 34);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 62);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Create";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(406, 34);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 62);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(208, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 62);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvPackages
            // 
            dgvPackages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPackages.BackgroundColor = SystemColors.ControlLight;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(12, 132);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 62;
            dgvPackages.Size = new Size(1013, 327);
            dgvPackages.TabIndex = 7;
            dgvPackages.CellContentDoubleClick += dgvPackages_CellDoubleClick;
            // 
            // FormPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1037, 471);
            Controls.Add(dgvPackages);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblTitle);
            Name = "FormPackage";
            Text = "Packages";
            Load += FormPackage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvPackages;
    }
}