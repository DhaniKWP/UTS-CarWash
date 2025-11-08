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
    public partial class FormTransactionDetail : Form
    {
        public string TransactionId
        {
            get => paramId.Text;
            set => paramId.Text = value;
        }
        public FormTransactionDetail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormTransactionDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
