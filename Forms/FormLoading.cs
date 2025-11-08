using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarWash.Forms
{
    public partial class FormLoading : Form
    {
        public FormLoading(string message = "Please wait, preparing data...")
        {
            InitializeComponent();

            
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Maximized;

            lblMessage.Text = message;
            lblMessage.Font = new Font("Segoe UI", 18, FontStyle.Italic);
            lblMessage.BackColor = Color.Transparent;
            lblMessage.AutoSize = true;

            
            this.Load += FormLoading_Load;
            this.Resize += FormLoading_Resize;
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void FormLoading_Resize(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void CenterLabel()
        {
            
            int x = (this.ClientSize.Width - lblMessage.Width) / 2;
            int y = (this.ClientSize.Height - lblMessage.Height) / 2;
            lblMessage.Location = new Point(x, y);
        }
    }
}
