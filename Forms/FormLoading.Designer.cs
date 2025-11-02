namespace CarWash.Forms
{
    partial class FormLoading
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
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(204, 49);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(59, 25);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label1";
            // 
            // FormLoading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 116);
            Controls.Add(lblMessage);
            Name = "FormLoading";
            Text = "FormLoading";
            Load += FormLoading_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
    }
}