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
    public partial class FormSearchClient : Form
    {
        public FormSearchClient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormSearchClient_Load(object sender, EventArgs e)
        {
            LoadClient();
        }

        private void LoadClient()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var client = db.Clients
                     .OrderByDescending(p => p.Id)
                     .AsEnumerable()
                     .Select((p, index) => new
                     {
                         No = index + 1,
                         ID = p.Id,
                         Name = p.FullName,
                         Plate = p.PlateNumber
                     })
                     .ToList();

                    this.Invoke(new Action(() =>
                    {
                        // 🔹 Tampilkan ke DataGridView
                        dgvSearchClient.DataSource = client;
                        dgvSearchClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvSearchClient.RowHeadersVisible = false;

                        // 🔹 Buat agar seluruh baris terpilih saat diklik
                        dgvSearchClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvSearchClient.MultiSelect = false;

                        // 🔹 Atur lebar tiap kolom (dalam pixel)
                        if (dgvSearchClient.Columns.Count > 0)
                        {
                            dgvSearchClient.Columns["No"].Width = 20;
                            dgvSearchClient.Columns["ID"].Width = 20;
                            dgvSearchClient.Columns["Name"].Width = 200;
                            dgvSearchClient.Columns["Plate"].Width = 150;
                        }

                        // 🔹 Atur agar kolom otomatis menyesuaikan lebar tabel
                        dgvSearchClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvSearchClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // 🔹 Rapiin header tabel
                        dgvSearchClient.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvSearchClient.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvSearchClient.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvSearchClient.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240); // 🔹 Warna tetap sama
                        dgvSearchClient.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black; // 🔹 Teks tidak berubah

                        // 🔹 Hilangkan baris kosong di akhir
                        dgvSearchClient.AllowUserToAddRows = false;

                        // 🔹 Buat grid lebih halus
                        dgvSearchClient.BorderStyle = BorderStyle.None;
                        dgvSearchClient.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        dgvSearchClient.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                        dgvSearchClient.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvSearchClient.EnableHeadersVisualStyles = false;
                        dgvSearchClient.GridColor = Color.LightGray;
                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        public string SelectedClientId { get; private set; }
        public string SelectedFullName { get; private set; }
        private void dgvSearchClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvSearchClient.Rows[e.RowIndex];

                SelectedClientId = selectedRow.Cells["ID"].Value.ToString();
                SelectedFullName = selectedRow.Cells["Name"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSearchClient.SelectedRows.Count > 0 && dgvSearchClient.CurrentRow != null && dgvSearchClient.CurrentRow.Index >= 0)
            {
                int clientid = Convert.ToInt32(dgvSearchClient.CurrentRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    var data = db.Clients.FirstOrDefault(p => p.Id == clientid);
                    if (data != null)
                    {
                        SelectedClientId = data.Id.ToString();
                        SelectedFullName = data.FullName;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
