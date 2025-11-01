namespace CarWash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnClient = new Button();
            btnPackage = new Button();
            btnTransaction = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(35, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "JETWASH ID";
            // 
            // btnClient
            // 
            btnClient.BackColor = SystemColors.HotTrack;
            btnClient.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClient.ForeColor = SystemColors.Control;
            btnClient.Location = new Point(722, 358);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(197, 68);
            btnClient.TabIndex = 1;
            btnClient.Text = " CLIENT";
            btnClient.UseVisualStyleBackColor = false;
            // 
            // btnPackage
            // 
            btnPackage.BackColor = SystemColors.HotTrack;
            btnPackage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPackage.ForeColor = SystemColors.Control;
            btnPackage.Location = new Point(721, 238);
            btnPackage.Name = "btnPackage";
            btnPackage.Size = new Size(198, 68);
            btnPackage.TabIndex = 2;
            btnPackage.Text = "PACKAGE";
            btnPackage.UseVisualStyleBackColor = false;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = SystemColors.HotTrack;
            btnTransaction.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = SystemColors.Control;
            btnTransaction.Location = new Point(721, 122);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(198, 68);
            btnTransaction.TabIndex = 3;
            btnTransaction.Text = "TRANSAKSI";
            btnTransaction.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.png_clipart_staff_in_the_car_wash_blue_hat_free_buckle_material;
            ClientSize = new Size(1076, 586);
            Controls.Add(btnTransaction);
            Controls.Add(btnPackage);
            Controls.Add(btnClient);
            Controls.Add(lblTitle);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnClient;
        private Button btnPackage;
        private Button btnTransaction;
    }
}
