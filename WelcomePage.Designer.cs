namespace CarWash
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            menuStrip1 = new MenuStrip();
            pACKAGEToolStripMenuItem = new ToolStripMenuItem();
            tRANSAKSIToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pACKAGEToolStripMenuItem, tRANSAKSIToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1076, 46);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // pACKAGEToolStripMenuItem
            // 
            pACKAGEToolStripMenuItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pACKAGEToolStripMenuItem.Name = "pACKAGEToolStripMenuItem";
            pACKAGEToolStripMenuItem.Size = new Size(134, 42);
            pACKAGEToolStripMenuItem.Text = "Package";
            pACKAGEToolStripMenuItem.Click += pACKAGEToolStripMenuItem_Click;
            // 
            // tRANSAKSIToolStripMenuItem
            // 
            tRANSAKSIToolStripMenuItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tRANSAKSIToolStripMenuItem.Name = "tRANSAKSIToolStripMenuItem";
            tRANSAKSIToolStripMenuItem.Size = new Size(173, 42);
            tRANSAKSIToolStripMenuItem.Text = "Transaction";
            tRANSAKSIToolStripMenuItem.Click += tRANSAKSIToolStripMenuItem_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1076, 586);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "WelcomePage";
            Text = "CarWash Detailing Clean";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tRANSAKSIToolStripMenuItem;
        private ToolStripMenuItem pACKAGEToolStripMenuItem;
    }
}
