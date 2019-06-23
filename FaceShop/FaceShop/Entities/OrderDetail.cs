using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Entities
{
    public class OrderDetail
    {
        [Key]
        public long Id { get; set; }
        public long Qty { get; set; }
        public long Price { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
    }
}
