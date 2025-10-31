namespace CarWash.Forms
{
    partial class FormTransaction
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
            cmbClient = new ComboBox();
            cmbPackage = new ComboBox();
            txtTotal = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // cmbClient
            // 
            cmbClient.BackColor = Color.White;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(70, 43);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(223, 33);
            cmbClient.TabIndex = 0;
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(70, 93);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(223, 33);
            cmbPackage.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(70, 141);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(223, 31);
            txtTotal.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(70, 206);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Tambah transaksi";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(70, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Hapus transaksi";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = SystemColors.Control;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(319, 43);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(450, 376);
            dgvTransactions.TabIndex = 5;
            // 
            // FormTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTransactions);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtTotal);
            Controls.Add(cmbPackage);
            Controls.Add(cmbClient);
            Name = "FormTransaction";
            Text = "FormTransaction";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClient;
        private ComboBox cmbPackage;
        private TextBox txtTotal;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvTransactions;
    }
}