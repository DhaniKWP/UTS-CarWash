using CarWash.Forms;
using System;
using System.Windows.Forms;

namespace CarWash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Jadikan Form1 sebagai MDI Parent
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // (Opsional) Ubah warna menu agar mirip hyperlink
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = System.Drawing.Color.Blue;
                item.Font = new System.Drawing.Font(item.Font, System.Drawing.FontStyle.Underline);
            }
        }

        // 🔹 Event Klik Menu TRANSAKSI
        private void tRANSAKSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTransaction());
        }

        // 🔹 Event Klik Menu PACKAGE
        private void pACKAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPackage());
        }

        // 🔹 Event Klik Menu CLIENT
        private void cLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClient());
        }

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
