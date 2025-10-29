using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int PackageId { get; set; }
        public Package Package { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
