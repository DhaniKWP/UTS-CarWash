using CarWash.Data;
using CarWash.Models;
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
                         //Price = p.Price
                         Price = p.Price.ToString("N0", new System.Globalization.CultureInfo("id-ID"))
                         //Price = string.Format(new System.Globalization.CultureInfo("id-ID"), "{0:C}", p.Price)
                     })
                     .ToList();

                    this.Invoke(new Action(() =>
                    {
                        
                        dgvSearchPackage.DataSource = packages;
                        dgvSearchPackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvSearchPackage.RowHeadersVisible = false;

                        
                        dgvSearchPackage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvSearchPackage.MultiSelect = false;

                        
                        if (dgvSearchPackage.Columns.Count > 0)
                        {
                            dgvSearchPackage.Columns["No"].HeaderText = "NO";
                            dgvSearchPackage.Columns["ID"].HeaderText = "ID";
                            dgvSearchPackage.Columns["Name"].HeaderText = "NAME";
                            dgvSearchPackage.Columns["Type"].HeaderText = "TYPE";
                            dgvSearchPackage.Columns["Description"].HeaderText = "DESCRIPTION";
                            dgvSearchPackage.Columns["Price"].HeaderText = "PRICE";
                        }

                        
                        dgvSearchPackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvSearchPackage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
                        dgvSearchPackage.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black; 
                        dgvSearchPackage.AllowUserToAddRows = false;

                        
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
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }



        public string SelectedPackageId { get; private set; }
        public string SelectedDescription { get; private set; }
        public string SelectedPrice { get; private set; }
        private void dgvSearchPackage_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var selectedRow = dgvSearchPackage.Rows[e.RowIndex];

                
                SelectedPackageId = selectedRow.Cells["ID"].Value.ToString();
                SelectedDescription = selectedRow.Cells["Description"].Value.ToString();
                SelectedPrice = selectedRow.Cells["Price"].Value.ToString();

                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSearchPackage.SelectedRows.Count > 0 && dgvSearchPackage.CurrentRow != null && dgvSearchPackage.CurrentRow.Index >= 0)
            {
                int pckgid = Convert.ToInt32(dgvSearchPackage.CurrentRow.Cells["ID"].Value);

                using (var db = new AppDbContext())
                {
                    var data = db.Packages.FirstOrDefault(p => p.Id == pckgid);
                    if (data != null)
                    {
                        SelectedPackageId = data.Id.ToString();
                        SelectedDescription = data.Description;
                        SelectedPrice = data.Price.ToString();

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
