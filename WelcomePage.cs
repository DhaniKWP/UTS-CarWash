using CarWash.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarWash
{
    public partial class WelcomePage : Form
    {
        // 🔹 Variabel untuk menyimpan menu aktif
        private ToolStripMenuItem activeMenu = null;

        public WelcomePage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // 🔹 (Opsional) styling awal menu
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.Black;
                item.Font = new Font(item.Font, FontStyle.Regular);
            }
        }

        // 🔹 Fungsi untuk set menu aktif
        private void SetActiveMenu(ToolStripMenuItem menu)
        {
            // Reset menu lama
            if (activeMenu != null)
            {
                activeMenu.BackColor = SystemColors.ActiveCaption;
                activeMenu.ForeColor = Color.Black;
                activeMenu.Font = new Font(activeMenu.Font, FontStyle.Regular);
            }

            // Set menu baru
            activeMenu = menu;
            activeMenu.BackColor = Color.DodgerBlue;
            activeMenu.ForeColor = Color.White;
            activeMenu.Font = new Font(activeMenu.Font, FontStyle.Bold);
        }

        // 🔹 Event Klik Menu TRANSAKSI
        private void tRANSAKSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveMenu(tRANSAKSIToolStripMenuItem);
            OpenChildForm(new FormTransaction());
        }

        // 🔹 Event Klik Menu PACKAGE
        private void pACKAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveMenu(pACKAGEToolStripMenuItem);
            OpenChildForm(new FormPackage());
        }

        // 🔹 Event Klik Menu CLIENT
        //private void cLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SetActiveMenu(cLIENTToolStripMenuItem);
        //    OpenChildForm(new FormClient());
        //}

        // 🔹 Fungsi untuk membuka form di dalam MDI container
        private void OpenChildForm(Form childForm)
        {
            // Tutup form anak yang sedang terbuka agar tidak menumpuk
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Set form baru agar tampil di dalam Form1
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }
    }
}
