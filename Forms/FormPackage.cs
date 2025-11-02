using CarWash.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormPackage : Form
    {
        public FormPackage()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;

        }


        private async void FormPackage_Load(object sender, EventArgs e)
        {
            using (var loading = new FormLoading())
            {
                loading.Show();
                loading.Refresh();

                // Jalankan proses load di thread terpisah agar UI tidak freeze
                await Task.Run(() => LoadPackages());

                // Tutup popup setelah selesai load
                loading.Close();
            }
        }

        private void LoadPackages()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var packages = db.Packages
                     .OrderByDescending(p => p.Id)
                     .AsEnumerable()
                     .Select((p, index) => new
                     {
                         No = index + 1,
                         ID = p.Id,
                         Name = p.Name,
                         Type = p.VehicleType,
                         Description = p.Description,
                         Price = p.Price
                     })
                     .ToList();

                    this.Invoke(new Action(() =>
                    {
                        // 🔹 Tampilkan ke DataGridView
                        dgvPackages.DataSource = packages;
                        dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvPackages.RowHeadersVisible = false;

                        // 🔹 Buat agar seluruh baris terpilih saat diklik
                        dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvPackages.MultiSelect = false;

                        // 🔹 Atur lebar tiap kolom (dalam pixel)
                        if (dgvPackages.Columns.Count > 0)
                        {
                            dgvPackages.Columns["No"].Width = 20;
                            dgvPackages.Columns["ID"].Width = 20;
                            dgvPackages.Columns["Name"].Width = 200;
                            dgvPackages.Columns["Type"].Width = 150;
                            dgvPackages.Columns["Description"].Width = 300;
                            dgvPackages.Columns["Price"].Width = 120;
                        }

                        // 🔹 Atur agar kolom otomatis menyesuaikan lebar tabel
                        dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvPackages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // 🔹 Rapiin header tabel
                        dgvPackages.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvPackages.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240); // 🔹 Warna tetap sama
                        dgvPackages.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black; // 🔹 Teks tidak berubah

                        // 🔹 Hilangkan baris kosong di akhir
                        dgvPackages.AllowUserToAddRows = false;

                        // 🔹 Buat grid lebih halus
                        dgvPackages.BorderStyle = BorderStyle.None;
                        dgvPackages.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        dgvPackages.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                        dgvPackages.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvPackages.EnableHeadersVisualStyles = false;
                        dgvPackages.GridColor = Color.LightGray;
                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data paket: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormSubmitPackage())
            {
                form.PackageId = "create";

                var result = form.ShowDialog(); // tampilkan sebagai popup modal

                if (result == DialogResult.OK)
                {
                    LoadPackages();
                }
            }
        }

        private void dgvPackages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // pastikan baris valid
            {
                // Ambil nilai kolom dari baris yang diklik
                var selectedRow = dgvPackages.Rows[e.RowIndex];
                int pckgId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    // Cari data lengkap berdasarkan nama paket (lebih baik kalau nanti kamu pakai Id)
                    var pkg = db.Packages.FirstOrDefault(p => p.Id == pckgId);

                    if (pkg != null)
                    {
                        using (var form = new FormSubmitPackage())
                        {
                            form.PackageId = pkg.Id.ToString();

                            var result = form.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                LoadPackages(); // refresh datagrid setelah edit
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count > 0 && dgvPackages.CurrentRow != null && dgvPackages.CurrentRow.Index >= 0)
            {
                // Ambil nilai kolom dari baris yang 
                int pckgId = Convert.ToInt32(dgvPackages.CurrentRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    // Cari data lengkap berdasarkan nama paket (lebih baik kalau nanti kamu pakai Id)
                    var pkg = db.Packages.FirstOrDefault(p => p.Id == pckgId);

                    if (pkg != null)
                    {
                        using (var form = new FormSubmitPackage())
                        {
                            form.PackageId = pkg.Id.ToString();

                            var result = form.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                LoadPackages(); // refresh datagrid setelah edit
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select the data you wish to update first.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (dgvPackages.SelectedRows.Count > 0 && dgvPackages.CurrentRow != null && dgvPackages.CurrentRow.Index >= 0)
            {
                // Ambil ID dari baris aktif
                int packageId = Convert.ToInt32(dgvPackages.CurrentRow.Cells["ID"].Value);

                // Konfirmasi sebelum hapus
                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this data?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    using (var db = new AppDbContext())
                    {
                        var pkg = db.Packages.FirstOrDefault(p => p.Id == packageId);
                        var trans = db.Transactions.FirstOrDefault(t=>t.PackageId == packageId);

                        if (pkg != null)
                        {
                            if (trans !=null)
                            {
                               MessageBox.Show("Oops..., this data is already in use, you cannot delete it..","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                return;
                            }

                            db.Packages.Remove(pkg);
                            db.SaveChanges();

                            MessageBox.Show(
                               "Data deleted successfully.",
                               "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LoadPackages();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Data not found or has been previously deleted.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select the data you wish to delete first.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

       
    }
}
