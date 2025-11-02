using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarWash.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Code { get; set; }
        public string PlateNumber { get; set; }

        public int PackageId { get; set; }
        public Package Package { get; set; } 

        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
