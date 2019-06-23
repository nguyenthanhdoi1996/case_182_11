using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Entities
{
    public class Cart
    {
        [Key]
        public long Id { get; set; }
        public long Qty { get; set; }
        public long UserId { get; set; }
        public long ProductId { get; set; }
    }
}
