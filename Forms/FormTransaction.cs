using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWash.Forms
{
    public partial class FormTransaction : Form
    {
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormSubmitTransaction())
            {
                form.TransactionId = "added";

                var result = form.ShowDialog(); // tampilkan sebagai popup modal

                if (result == DialogResult.OK)
                {
                    //string message = $"Customer: {form.CustomerName}\nService: {form.ServiceType}\nPrice: Rp {form.Price:N0}";
                    //MessageBox.Show(message, "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TODO: kamu bisa lanjut masukkan ke database atau DataGridView di sini
                }
            }
        }
    }
}
