using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Entities
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public long Price { get; set; }
        public string Desc { get; set; }
        public string Detail { get; set; }
        public string View { get; set; }
        public string Sold { get; set; }
    }
}
