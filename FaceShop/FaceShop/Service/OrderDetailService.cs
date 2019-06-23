using FaceShop.DB_Context;
using FaceShop.Entities;
using FaceShop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Service
{
    public class OrderDetailService: IOrderDetailService
    {
        private FaceShop_DB_Context db = new FaceShop_DB_Context();

        public List<OrderDetail> GetAll()
        {
            return db.OrderDetails.ToList();
        }
        public OrderDetail GetOrderById(long id)
        {
            return db.OrderDetails.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
