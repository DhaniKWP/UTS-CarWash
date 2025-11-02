using CarWash.Data;
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
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;

        }


        private async void FormTransaction_Load(object sender, EventArgs e)
        {
            using (var loading = new FormLoading())
            {
                loading.Show();
                loading.Refresh();

                await Task.Run(() => LoadTransactions());

                loading.Close();
            }
        }

        private void LoadTransactions()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var transactions = db.Transactions
                        .Join(db.Packages,
                            t => t.PackageId,
                            p => p.Id,
                            (t, p) => new
                            {
                                t.Id,
                                t.Code,
                                Package = p.Description,
                                t.Price
                            })
                        .OrderByDescending(t => t.Id)
                        .ToList() // ⬅️ Query SQL dieksekusi di sini (sekali saja)
                        .Select((t, index) => new
                        {
                            No = index + 1,
                            t.Id,
                            Code = t.Code,
                            t.Package,
                            t.Price
                        })
                        .ToList(); // ⬅️ Nomor urut ditambahkan di memori


                    this.Invoke(new Action(() =>
                    {
                        dgvTransactions.DataSource = transactions;

                        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvTransactions.RowHeadersVisible = false;

                        // 🔹 Buat agar seluruh baris terpilih saat diklik
                        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvTransactions.MultiSelect = false;

                        // 🔹 Atur lebar tiap kolom (dalam pixel)
                        if (dgvTransactions.Columns.Count > 0)
                        {
                            dgvTransactions.Columns["No"].Width = 10;
                            dgvTransactions.Columns["Id"].Width = 10;
                            dgvTransactions.Columns["Code"].Width = 15;
                            dgvTransactions.Columns["Plate"].Width = 15;
                            dgvTransactions.Columns["Package"].Width = 30;
                            dgvTransactions.Columns["Price"].Width = 20;
                        }

                        // 🔹 Atur agar kolom otomatis menyesuaikan lebar tabel
                        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // 🔹 Rapiin header tabel
                        dgvTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240); // 🔹 Warna tetap sama
                        dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black; // 🔹 Teks tidak berubah

                        // 🔹 Hilangkan baris kosong di akhir
                        dgvTransactions.AllowUserToAddRows = false;

                        // 🔹 Buat grid lebih halus
                        dgvTransactions.BorderStyle = BorderStyle.None;
                        dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        dgvTransactions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                        dgvTransactions.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvTransactions.EnableHeadersVisualStyles = false;
                        dgvTransactions.GridColor = Color.LightGray;
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data transaksi: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormSubmitTransaction())
            {
                form.TransactionId = "create";

                var result = form.ShowDialog(); // tampilkan sebagai popup modal

                if (result == DialogResult.OK)
                {
                    
                }
            }
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
