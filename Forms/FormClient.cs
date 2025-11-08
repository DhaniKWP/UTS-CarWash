using CarWash.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWash.Forms
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private async void FormClient_Load(object sender, EventArgs e)
        {
            using (var loading = new FormLoading())
            {
                loading.Show();
                loading.Refresh();

                await Task.Run(() => LoadClients());

                loading.Close();
            }
        }

        private void LoadClients()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var clients = db.Clients
                        .OrderByDescending(c => c.Id)
                        .AsEnumerable()
                        .Select((c, index) => new
                        {
                            No = index + 1,
                            ID = c.Id,
                            Name = c.FullName,
                            Phone = c.Phone,
                            PlateNumber = c.PlateNumber
                        })
                        .ToList();

                    this.Invoke(new Action(() =>
                    {
                        dgvClients.DataSource = clients;
                        dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvClients.RowHeadersVisible = false;

                        dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvClients.MultiSelect = false;

                        if (dgvClients.Columns.Count > 0)
                        {
                            dgvClients.Columns["No"].HeaderText ="NO";
                            dgvClients.Columns["ID"].HeaderText = "NO";
                            dgvClients.Columns["Name"].HeaderText = "NAME";
                            dgvClients.Columns["Phone"].HeaderText="PHONE";
                            dgvClients.Columns["PlateNumber"].HeaderText = "NO.PLATE";
                        }

                        dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        dgvClients.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvClients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvClients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvClients.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
                        dgvClients.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

                        dgvClients.AllowUserToAddRows = false;
                        dgvClients.BorderStyle = BorderStyle.None;
                        dgvClients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        dgvClients.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                        dgvClients.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvClients.EnableHeadersVisualStyles = false;
                        dgvClients.GridColor = Color.LightGray;
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data client: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormSubmitClient())
            {
                form.ClientId = "create";

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadClients();
                }
            }
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvClients.Rows[e.RowIndex];
                int clientId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    var client = db.Clients.FirstOrDefault(c => c.Id == clientId);

                    if (client != null)
                    {
                        using (var form = new FormSubmitClient())
                        {
                            form.ClientId = client.Id.ToString();

                            var result = form.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                LoadClients();
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0 && dgvClients.CurrentRow != null && dgvClients.CurrentRow.Index >= 0)
            {
                int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    var client = db.Clients.FirstOrDefault(c => c.Id == clientId);

                    if (client != null)
                    {
                        using (var form = new FormSubmitClient())
                        {
                            form.ClientId = client.Id.ToString();

                            var result = form.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                LoadClients();
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

            if (dgvClients.SelectedRows.Count > 0 && dgvClients.CurrentRow != null && dgvClients.CurrentRow.Index >= 0)
            {
                int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["ID"].Value);

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
                        var client = db.Clients.FirstOrDefault(c => c.Id == clientId);
                        var trans = db.Transactions.FirstOrDefault(t => t.ClientId == clientId);

                        if (client != null)
                        {
                            if (trans != null)
                            {
                                MessageBox.Show(
                                    "Oops..., this data is already in use, you cannot delete it.",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                return;
                            }

                            db.Clients.Remove(client);
                            db.SaveChanges();

                            MessageBox.Show(
                                "Data deleted successfully.",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LoadClients();
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
