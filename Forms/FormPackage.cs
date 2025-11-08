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

                
                await Task.Run(() => LoadPackages());

                
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
                         //Price = p.Price
                         Price = p.Price.ToString("N0", new System.Globalization.CultureInfo("id-ID"))
                         //Price = string.Format(new System.Globalization.CultureInfo("id-ID"), "{0:C}", p.Price)
                     })
                     .ToList();

                    this.Invoke(new Action(() =>
                    {
                        
                        dgvPackages.DataSource = packages;
                        dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvPackages.RowHeadersVisible = false;

                        
                        dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvPackages.MultiSelect = false;

                        
                        if (dgvPackages.Columns.Count > 0)
                        {
                            dgvPackages.Columns["No"].HeaderText = "NO";
                            dgvPackages.Columns["ID"].HeaderText = "ID";
                            dgvPackages.Columns["Name"].HeaderText = "NAME";
                            dgvPackages.Columns["Type"].HeaderText = "TYPE";
                            dgvPackages.Columns["Description"].HeaderText = "DESCRIPTION";
                            dgvPackages.Columns["Price"].HeaderText = "PRICE";
                        }

                       
                        dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvPackages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        
                        dgvPackages.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvPackages.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
                        dgvPackages.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

                        
                        dgvPackages.AllowUserToAddRows = false;

                        
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

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadPackages();
                }
            }
        }

        
        private void dgvPackages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                var selectedRow = dgvPackages.Rows[e.RowIndex];
                int pckgId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    var pkg = db.Packages.FirstOrDefault(p => p.Id == pckgId);

                    if (pkg != null)
                    {
                        using (var form = new FormSubmitPackage())
                        {
                            form.PackageId = pkg.Id.ToString();

                            var result = form.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                LoadPackages(); 
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
                
                int pckgId = Convert.ToInt32(dgvPackages.CurrentRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    
                    var pkg = db.Packages.FirstOrDefault(p => p.Id == pckgId);

                    if (pkg != null)
                    {
                        using (var form = new FormSubmitPackage())
                        {
                            form.PackageId = pkg.Id.ToString();

                            var result = form.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                LoadPackages(); 
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
            
            if (dgvPackages.SelectedRows.Count > 0 && dgvPackages.CurrentRow != null && dgvPackages.CurrentRow.Index >= 0)
            {
                
                int packageId = Convert.ToInt32(dgvPackages.CurrentRow.Cells["ID"].Value);

                
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
                        var trans = db.Transactions.FirstOrDefault(t => t.PackageId == packageId);

                        if (pkg != null)
                        {
                            if (trans != null)
                            {
                                MessageBox.Show("Oops..., this data is already in use, you cannot delete it..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
