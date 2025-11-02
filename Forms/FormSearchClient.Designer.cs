namespace CarWash.Forms
{
    partial class FormSearchClient
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
            dgvSearchClient = new DataGridView();
            btnCancel = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSearchClient).BeginInit();
            SuspendLayout();
            // 
            // dgvSearchClient
            // 
            dgvSearchClient.BackgroundColor = Color.White;
            dgvSearchClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchClient.GridColor = SystemColors.WindowText;
            dgvSearchClient.Location = new Point(33, 30);
            dgvSearchClient.Name = "dgvSearchClient";
            dgvSearchClient.RowHeadersWidth = 62;
            dgvSearchClient.Size = new Size(1340, 437);
            dgvSearchClient.TabIndex = 0;
            dgvSearchClient.CellContentDoubleClick += dgvSearchClient_CellContentDoubleClick;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1202, 502);
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
            btnSelect.Location = new Point(1005, 502);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(171, 62);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // FormSearchClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 597);
            Controls.Add(btnSelect);
            Controls.Add(btnCancel);
            Controls.Add(dgvSearchClient);
            Name = "FormSearchClient";
            Text = "FormSearchClient";
            Load += FormSearchClient_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSearchClient;
        private Button btnCancel;
        private Button btnSelect;
    }
}