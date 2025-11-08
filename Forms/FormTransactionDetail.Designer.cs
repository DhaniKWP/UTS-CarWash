namespace CarWash.Forms
{
    partial class FormTransactionDetail
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
            paramId = new TextBox();
            SuspendLayout();
            // 
            // paramId
            // 
            paramId.Location = new Point(12, 407);
            paramId.Name = "paramId";
            paramId.Size = new Size(150, 31);
            paramId.TabIndex = 0;
            // 
            // FormTransactionDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(paramId);
            Name = "FormTransactionDetail";
            Text = "Transaction Detail";
            Load += FormTransactionDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox paramId;
    }
}