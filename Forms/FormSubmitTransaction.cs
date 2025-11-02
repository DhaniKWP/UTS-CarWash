using CarWash.Data;
using System;
using System.Windows.Forms;

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
            txtPlate.TabIndex = 0;
            btnSubmit.TabIndex = 1;
            btnCancel.TabIndex = 2;

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSearchPackage_Click(object sender, EventArgs e)
        {
            using (var form = new FormSearchPackage())
            {
                var result = form.ShowDialog(); // tampilkan sebagai popup modal

                if (result == DialogResult.OK)
                {
                    txtPackageId.Text = form.SelectedPackageId;
                    txtPackage.Text = form.SelectedDescription;
                }
            }
        }
    }
}
