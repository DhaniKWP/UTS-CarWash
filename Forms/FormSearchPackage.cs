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
    public partial class FormSearchPackage : Form
    {
        public FormSearchPackage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private void FormSearchPackage_Load(object sender, EventArgs e)
        {
            LoadPackages();
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
                        dgvSearchPackage.DataSource = packages;
                        dgvSearchPackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvSearchPackage.RowHeadersVisible = false;

                        // 🔹 Buat agar seluruh baris terpilih saat diklik
                        dgvSearchPackage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvSearchPackage.MultiSelect = false;

                        // 🔹 Atur lebar tiap kolom (dalam pixel)
                        if (dgvSearchPackage.Columns.Count > 0)
                        {
                            dgvSearchPackage.Columns["No"].Width = 20;
                            dgvSearchPackage.Columns["ID"].Width = 20;
                            dgvSearchPackage.Columns["Name"].Width = 200;
                            dgvSearchPackage.Columns["Type"].Width = 150;
                            dgvSearchPackage.Columns["Description"].Width = 300;
                            dgvSearchPackage.Columns["Price"].Width = 120;
                        }

                        // 🔹 Atur agar kolom otomatis menyesuaikan lebar tabel
                        dgvSearchPackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvSearchPackage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // 🔹 Rapiin header tabel
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240); // 🔹 Warna tetap sama
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black; // 🔹 Teks tidak berubah

                        // 🔹 Hilangkan baris kosong di akhir
                        dgvSearchPackage.AllowUserToAddRows = false;

                        // 🔹 Buat grid lebih halus
                        dgvSearchPackage.BorderStyle = BorderStyle.None;
                        dgvSearchPackage.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        dgvSearchPackage.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                        dgvSearchPackage.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvSearchPackage.EnableHeadersVisualStyles = false;
                        dgvSearchPackage.GridColor = Color.LightGray;
                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data paket: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string SelectedPackageId { get; private set; }
        public string SelectedDescription { get; private set; }
        private void dgvSearchPackage_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // pastikan baris valid
            {
                var selectedRow = dgvSearchPackage.Rows[e.RowIndex];

                // Ambil ID dan Description
                SelectedPackageId = selectedRow.Cells["ID"].Value.ToString();
                SelectedDescription = selectedRow.Cells["Description"].Value.ToString();

                this.DialogResult = DialogResult.OK; // Tutup popup dengan hasil OK
                this.Close();
            }
        }
    }
}
