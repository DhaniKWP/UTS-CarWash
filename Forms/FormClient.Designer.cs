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
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtVehicleType = new TextBox();
            txtPlate = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvClients = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Silver;
            lblTitle.Font = new Font("Wide Latin", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Crimson;
            lblTitle.Location = new Point(192, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(516, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CLIENT MANAGEMENT";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(192, 87);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(231, 31);
            txtFullName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(192, 130);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(231, 31);
            txtPhone.TabIndex = 2;
            // 
            // txtVehicleType
            // 
            txtVehicleType.Location = new Point(563, 87);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.Size = new Size(231, 31);
            txtVehicleType.TabIndex = 3;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(563, 130);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(231, 31);
            txtPlate.TabIndex = 4;
            txtPlate.TextChanged += txtPlate_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(207, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Tambah client";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(554, 217);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update data client";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(385, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Hapus client";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvClients
            // 
            dgvClients.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(124, 257);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(664, 277);
            dgvClients.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 90);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 130);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 10;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 90);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 11;
            label3.Text = "Jenis Kendaraan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 133);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 12;
            label4.Text = "No Plat";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(946, 546);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClients);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPlate);
            Controls.Add(txtVehicleType);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(lblTitle);
            Name = "FormClient";
            Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtVehicleType;
        private TextBox txtPlate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvClients;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}