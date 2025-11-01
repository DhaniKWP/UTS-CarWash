//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace CarWash.Forms
//{
//    public partial class FormSubmitTransaction : Form
//    {
//        public FormSubmitTransaction()
//        {
//            InitializeComponent();
//        }

//        private void FormSubmitTransaction_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}



using System;
using System.Windows.Forms;

namespace CarWash.Forms
{
    public partial class FormSubmitTransaction : Form
    {
        // Properti untuk menampung hasil input dari form
        //public string CustomerName { get; private set; }
        //public string ServiceType { get; private set; }
        //public decimal Price { get; private set; }

        public string TransactionId
        {
            get => paramId.Text;
            set => paramId.Text = value;
        }

        public FormSubmitTransaction()
        {
            InitializeComponent();
            //InitializeCustomComponents();
        }

        //private void InitializeCustomComponents()
        //{
        //    this.Text = "Submit Transaction";
        //    this.Width = 400;
        //    this.Height = 250;
        //    this.StartPosition = FormStartPosition.CenterParent;
        //    this.FormBorderStyle = FormBorderStyle.FixedDialog;
        //    this.MaximizeBox = false;
        //    this.MinimizeBox = false;

        //    Label lblCustomer = new Label() { Text = "Customer Name:", Left = 20, Top = 25, Width = 120 };
        //    TextBox txtCustomer = new TextBox() { Name = "txtCustomer", Left = 150, Top = 20, Width = 200 };

        //    Label lblService = new Label() { Text = "Service Type:", Left = 20, Top = 65, Width = 120 };
        //    ComboBox cmbService = new ComboBox() { Name = "cmbService", Left = 150, Top = 60, Width = 200 };
        //    cmbService.Items.AddRange(new string[] { "Car Wash", "Interior Cleaning", "Waxing", "Polishing" });

        //    Label lblPrice = new Label() { Text = "Price:", Left = 20, Top = 105, Width = 120 };
        //    NumericUpDown numPrice = new NumericUpDown() { Name = "numPrice", Left = 150, Top = 100, Width = 100, Minimum = 0, Maximum = 1000000, Increment = 1000 };

        //    Button btnSave = new Button() { Text = "Save", Left = 150, Top = 150, Width = 80 };
        //    btnSave.Click += (s, e) =>
        //    {
        //        CustomerName = txtCustomer.Text;
        //        ServiceType = cmbService.Text;
        //        Price = numPrice.Value;

        //        if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(ServiceType))
        //        {
        //            MessageBox.Show("Please fill all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        this.DialogResult = DialogResult.OK;
        //        this.Close();
        //    };

        //    Button btnCancel = new Button() { Text = "Cancel", Left = 240, Top = 150, Width = 80 };
        //    btnCancel.Click += (s, e) =>
        //    {
        //        this.DialogResult = DialogResult.Cancel;
        //        this.Close();
        //    };

        //    this.Controls.Add(lblCustomer);
        //    this.Controls.Add(txtCustomer);
        //    this.Controls.Add(lblService);
        //    this.Controls.Add(cmbService);
        //    this.Controls.Add(lblPrice);
        //    this.Controls.Add(numPrice);
        //    this.Controls.Add(btnSave);
        //    this.Controls.Add(btnCancel);
        //}

        private void FormSubmitTransaction_Load(object sender, EventArgs e)
        {
            // Opsional: jika kamu ingin load data awal
        }
    }
}
