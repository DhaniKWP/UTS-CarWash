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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // cmbClient
            // 
            cmbClient.BackColor = Color.White;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(212, 110);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(211, 33);
            cmbClient.TabIndex = 0;
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(212, 174);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(211, 33);
            cmbPackage.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(544, 107);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(199, 31);
            txtTotal.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(182, 259);
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
            btnDelete.Location = new Point(525, 259);
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
            dgvTransactions.Location = new Point(123, 299);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(620, 250);
            dgvTransactions.TabIndex = 5;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Wide Latin", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(255, 29);
            label2.Name = "label2";
            label2.Size = new Size(332, 27);
            label2.TabIndex = 7;
            label2.Text = "TRANSACTION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 118);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 8;
            label3.Text = "Pilih Client";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 174);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 9;
            label4.Text = "Pilih Paket";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 110);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 10;
            label5.Text = "Total Harga";
            // 
            // FormTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(899, 561);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTransactions);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtTotal);
            Controls.Add(cmbPackage);
            Controls.Add(cmbClient);
            Name = "FormTransaction";
            Text = "FormTransaction";
            Load += FormTransaction_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}