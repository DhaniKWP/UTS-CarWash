using CarWash.Data;
using System;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using CarWash.Models;

namespace CarWash.Forms
{
    public partial class FormSubmitTransaction : Form
    {

        public string TransactionId
        {
            get => paramId.Text;
            set => paramId.Text = value;
        }


        public FormSubmitTransaction()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }



        private void FormSubmitTransaction_Load(object sender, EventArgs e)
        {
            btnSubmit.TabIndex = 0;
            btnCancel.TabIndex = 1;

            if (TransactionId == "create")
            {
                GenerateTransactionCode();
            }
        }

        private void GenerateTransactionCode()
        {
            using (var db = new AppDbContext())
            {
                // Ambil record terakhir berdasarkan ID terbesar
                var lastTransaction = db.Transactions
                    .OrderByDescending(t => t.Id)
                    .FirstOrDefault();

                string newCode = "";
                string prefix = "C-" + DateTime.Now.ToString("yyMMdd"); // contoh: C-250211
                int nextNumber = 1;

                if (lastTransaction != null && lastTransaction.Code.StartsWith(prefix))
                {
                    // Ambil 4 digit terakhir dan increment
                    string lastNumberPart = lastTransaction.Code.Substring(lastTransaction.Code.Length - 4);
                    if (int.TryParse(lastNumberPart, out int lastNumber))
                    {
                        nextNumber = lastNumber + 1;
                    }
                }

                // Format baru: C-2502110002
                newCode = $"{prefix}{nextNumber.ToString("D4")}";

                // Tampilkan ke textbox (misal txtCode)
                txtCode.Text = newCode;
            }
        }


        private void btnSearchPackage_Click(object sender, EventArgs e)
        {
            using (var form = new FormSearchPackage())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtPackageId.Text = form.SelectedPackageId;
                    txtPackage.Text = form.SelectedDescription;
                    txtPrice.Text = form.SelectedPrice;
                }
            }
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            using (var form = new FormSearchClient())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtClientId.Text = form.SelectedClientId;
                    txtClient.Text = form.SelectedFullName;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string clientid = txtClientId.Text.Trim();
            string packageid = txtPackageId.Text.Trim();
            string price = txtPrice.Text.Trim();
            string msg = string.Empty;

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Something's wrong", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(clientid))
            {
                MessageBox.Show("Please select client", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(packageid))
            {
                MessageBox.Show("Please select package", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    // Jika mode create
                    if (TransactionId == "create")
                    {
                        var trans = new CarWash.Models.Transaction
                        {
                            Code = code,
                            ClientId = Convert.ToInt32(clientid),
                            PackageId = Convert.ToInt32(packageid),
                            Price = Convert.ToInt32(price),
                            CreatedAt = DateTime.UtcNow,
                        };


                        db.Transactions.Add(trans);
                        db.SaveChanges();
                        msg = "Package data was saved successfully.";
                    }
                    else
                    {
                        //if (int.TryParse(TransactionId, out int id))
                        //{
                        //    var existing = db.Packages.Find(id);

                        //    if (existing != null)
                        //    {
                        //        existing.Name = name;
                        //        existing.VehicleType = type;
                        //        existing.Description = $"{name} - {type}";
                        //        existing.Price = price;

                        //        db.SaveChanges();
                        //        msg = "Package data was updated successfully.";
                        //    }
                        //    else
                        //    {
                        //        msg = "Package not found. Update failed.";
                        //    }
                        //}
                        //else
                        //{
                        //    msg = "Invalid package ID.";
                        //}
                       msg = "Package data was updated successfully.";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
