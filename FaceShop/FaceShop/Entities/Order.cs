using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Entities
{
    public class Order
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public DateTime Datetime { get; set; }
        public long Total { get; set; }
        public long PaymentType { get; set; }
        public string Status { get; set; }
    }
}
