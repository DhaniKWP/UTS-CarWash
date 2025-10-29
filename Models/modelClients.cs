using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CarWash.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string VehicleType { get; set; }
        public string PlateNumber { get; set; }

        // Navigation property
        public ICollection<Transaction> Transactions { get; set; }
    }

}
