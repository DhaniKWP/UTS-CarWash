using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarWash.Data;
using CarWash.Models;


namespace CarWash.Forms
{
    public partial class FormSubmitPackage : Form
    {
        public string PackageId
        {
            get => paramId.Text;
            set => paramId.Text = value;
        }

        public FormSubmitPackage()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormSubmitPackage_Load(object sender, EventArgs e)
        {
            txtName.TabIndex = 0;
            txtType.TabIndex = 1;
            txtPrice.TabIndex = 2;
            btnSubmit.TabIndex = 3;
            btnCancel.TabIndex = 4;

            
            if (!string.IsNullOrEmpty(PackageId))
            {
                if (PackageId != "create")
                {
                    LoadPackageData();
                }
            }

        }

        private void LoadPackageData()
        {
            try
            {
                int id = Convert.ToInt32(PackageId);

                using (var db = new AppDbContext())
                {
                    var pkg = db.Packages.FirstOrDefault(p => p.Id == id);

                    if (pkg != null)
                    {
                        // Isi field form dengan data dari database
                        txtName.Text = pkg.Name;
                        txtType.Text = pkg.VehicleType;
                        txtPrice.Text = pkg.Price.ToString();
                        this.Text = "Update Package Package";
                    }
                    else
                    {
                        MessageBox.Show(
                            "Package data not found.\nMaybe it has been deleted.",
                            "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading package data:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text?.Trim();
            string type = txtType.Text?.Trim();
            string priceText = txtPrice.Text?.Trim();
            string msg = string.Empty;


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Type is required.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtType.Focus();
                return;
            }

            if (string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Price is required.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("The price is invalid. Please enter the correct number (example: 10000 or 10000.50).", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    // Jika mode create
                    if (PackageId == "create")
                    {
                        var pkg = new Package
                        {
                            Name = name,
                            VehicleType = type,
                            Description = $"{name} - {type}",
                            Price = price
                        };

                        db.Packages.Add(pkg);
                        db.SaveChanges();
                        msg = "Package data was saved successfully.";
                    }
                    else
                    {
                        if (int.TryParse(PackageId, out int id))
                        {
                            var existing = db.Packages.Find(id);

                            if (existing != null)
                            {
                                existing.Name = name;
                                existing.VehicleType = type;
                                existing.Description = $"{name} - {type}";
                                existing.Price = price;

                                db.SaveChanges();
                                msg = "Package data was updated successfully.";
                            }
                            else
                            {
                                msg = "Package not found. Update failed.";
                            }
                        }
                        else
                        {
                            msg = "Invalid package ID.";
                        }
                    }
                }

                // Tampilkan pesan sukses lalu tutup form dengan DialogResult.OK
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                     "Failed to save data:\n" + ex.Message +
                     "\n\nInner: " + (ex.InnerException != null ? ex.InnerException.Message : "None"),
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                 );
            }
        }
    }
}
