using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Entities
{
    public class searchProduct
    {
        public List<Product> listproduct { get; set; } 
        public Order order { get; set; }
        public List<OrderDetail> listorderdetail { get; set; }
    }
}
