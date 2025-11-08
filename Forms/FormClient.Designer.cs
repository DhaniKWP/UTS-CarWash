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
            btnAdd = new Button();
            btnDelete = new Button();
            dgvClients = new DataGridView();
            label2 = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(10, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 62);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "New Client";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(221, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 62);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Client";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvClients
            // 
            dgvClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClients.BackgroundColor = SystemColors.ControlLight;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(10, 112);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(925, 374);
            dgvClients.TabIndex = 6;
            dgvClients.CellDoubleClick += dgvClients_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LawnGreen;
            label2.Location = new Point(668, 15);
            label2.Name = "label2";
            label2.Size = new Size(262, 63);
            label2.TabIndex = 8;
            label2.Text = "CLIENTS";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(432, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 62);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(945, 496);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(dgvClients);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Margin = new Padding(2);
            Name = "FormClient";
            Text = "Clients";
            Load += FormClient_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvClients;
        private Label label2;
        private Button btnUpdate;
    }
}