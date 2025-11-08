using CarWash.Data;
using CarWash.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CarWash.Forms
{
    public partial class FormSubmitClient : Form
    {
        public string ClientId
        {
            get => paramId.Text;
            set => paramId.Text = value;
        }

        public FormSubmitClient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormSubmitClient_Load_1(object sender, EventArgs e)
        {
            txtName.TabIndex = 0;
            txtPhone.TabIndex = 1;
            txtNoPlat.TabIndex = 2;
            btnSubmit.TabIndex = 3;
            btnCancel.TabIndex = 4;

            if (!string.IsNullOrEmpty(ClientId))
            {
                if (ClientId != "create")
                {
                    LoadClientData();
                }
            }
        }

        private void LoadClientData()
        {
            try
            {
                int id = Convert.ToInt32(ClientId);

                using (var db = new AppDbContext())
                {
                    var client = db.Clients.FirstOrDefault(c => c.Id == id);

                    if (client != null)
                    {
                        txtName.Text = client.FullName;
                        txtPhone.Text = client.Phone;
                        txtNoPlat.Text = client.PlateNumber;
                        this.Text = "Update Client Data";
                    }
                    else
                    {
                        MessageBox.Show(
                            "Client data not found.\nMaybe it has been deleted.",
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
                    "Error loading client data:\n" + ex.Message,
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

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text?.Trim();
            string phone = txtPhone.Text?.Trim();
            string plate = txtNoPlat.Text?.Trim();
            string msg = string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Full name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // ✅ Validasi: Phone hanya boleh angka
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain digits only (0-9).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(plate))
            {
                MessageBox.Show("Plate number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoPlat.Focus();
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    // Mode create
                    if (ClientId == "create")
                    {
                        var client = new Client
                        {
                            FullName = name,
                            Phone = phone,
                            PlateNumber = plate
                        };

                        db.Clients.Add(client);
                        db.SaveChanges();
                        msg = "Client data was saved successfully.";
                    }
                    else
                    {
                        if (int.TryParse(ClientId, out int id))
                        {
                            var existing = db.Clients.Find(id);

                            if (existing != null)
                            {
                                existing.FullName = name;
                                existing.Phone = phone;
                                existing.PlateNumber = plate;

                                db.SaveChanges();
                                msg = "Client data was updated successfully.";
                            }
                            else
                            {
                                msg = "Client not found. Update failed.";
                            }
                        }
                        else
                        {
                            msg = "Invalid client ID.";
                        }
                    }
                }

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
