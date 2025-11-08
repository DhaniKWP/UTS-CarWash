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
                            (t, p) => new { t, p })
                        .Join(db.Clients,
                            tp => tp.t.ClientId,
                            c => c.Id,
                            (tp, c) => new
                            {
                                tp.t.Id,
                                tp.t.Code,
                                Package = tp.p.Description,
                                tp.t.Price,
                                tp.t.CreatedAt,
                                ClientName = c.FullName,
                                ClientPhone = c.Phone,
                                ClientPlate = c.PlateNumber
                            })
                        .OrderByDescending(x => x.Id)
                        .AsEnumerable()
                        .Select((x, index) => new
                        {
                            No = index + 1,
                            x.Id,
                            x.Code,
                            x.Package,
                            x.ClientName,
                            x.ClientPhone,
                            x.ClientPlate,
                            Price = x.Price.ToString("N0", new System.Globalization.CultureInfo("id-ID")),
                            CreatedAt = x.CreatedAt.ToLocalTime().ToString("dd MMMM yyyy 'Pukul' HH:mm", new System.Globalization.CultureInfo("id-ID"))
                        })
                        .ToList();



                    this.Invoke(new Action(() =>
                    {
                        dgvTransactions.DataSource = transactions;

                        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvTransactions.RowHeadersVisible = false;


                        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvTransactions.MultiSelect = false;


                        if (dgvTransactions.Columns.Count > 0)
                        {

                            dgvTransactions.Columns["No"].HeaderText = "NO";
                            dgvTransactions.Columns["Id"].HeaderText = "ID";
                            dgvTransactions.Columns["Code"].HeaderText = "CODE";
                            dgvTransactions.Columns["Package"].HeaderText = "PACKAGE";
                            dgvTransactions.Columns["ClientName"].HeaderText = "CLIENT NAME";
                            dgvTransactions.Columns["ClientPhone"].HeaderText = "PHONE NUMBER";
                            dgvTransactions.Columns["ClientPlate"].HeaderText = "NO. PLATE";
                            dgvTransactions.Columns["Price"].HeaderText = "PRICE";
                            dgvTransactions.Columns["CreatedAt"].HeaderText = "CREATED AT";
                        }


                        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                        dgvTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
                        dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;


                        dgvTransactions.AllowUserToAddRows = false;


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

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadTransactions();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0 && dgvTransactions.CurrentRow != null && dgvTransactions.CurrentRow.Index >= 0)
            {
                int transid = Convert.ToInt32(dgvTransactions.CurrentRow.Cells["Id"].Value);


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
                        var trans = db.Transactions.FirstOrDefault(p => p.Id == transid);

                        if (trans != null)
                        {
                            db.Transactions.Remove(trans);
                            db.SaveChanges();

                            MessageBox.Show(
                               "Data deleted successfully.",
                               "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LoadTransactions();
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

        private void dgvTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvTransactions.Rows[e.RowIndex];
                int transId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    var trans = db.Transactions.FirstOrDefault(t => t.Id == transId);

                    if (trans != null)
                    {
                        using (var form = new FormTransactionDetail())
                        {
                            form.TransactionId = trans.Id.ToString();

                            var result = form.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                
                            }
                        }
                    }
                }
            }
        }
        
    }
}
