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
            btnAdd = new Button();
            btnDelete = new Button();
            dgvTransactions = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(20, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 62);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "New Transaction";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(229, 38);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 62);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Transaction";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransactions.BackgroundColor = SystemColors.ControlLight;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(20, 143);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(866, 333);
            dgvTransactions.TabIndex = 5;
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
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(437, 38);
            label2.Name = "label2";
            label2.Size = new Size(425, 63);
            label2.TabIndex = 7;
            label2.Text = "TRANSACTION";
            // 
            // FormTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(912, 501);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTransactions);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "FormTransaction";
            Text = "Transactions";
            Load += FormTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvTransactions;
        private Label label1;
        private Label label2;
    }
}