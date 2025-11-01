namespace CarWash.Forms
{
    partial class FormClient
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
            btnDelete = new Button();
            dgvClients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Silver;
            lblTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Crimson;
            lblTitle.Location = new Point(689, 21);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(363, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CLIENT MANAGEMENT";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(9, 13);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Tambah client";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(237, 13);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(179, 44);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Hapus client";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvClients
            // 
            dgvClients.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(9, 100);
            dgvClients.Margin = new Padding(4);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(1208, 477);
            dgvClients.TabIndex = 8;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1230, 590);
            Controls.Add(dgvClients);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblTitle);
            Margin = new Padding(4);
            Name = "FormClient";
            Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvClients;
    }
}