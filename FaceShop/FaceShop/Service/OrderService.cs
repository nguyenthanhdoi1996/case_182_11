using FaceShop.DB_Context;
using FaceShop.Entities;
using FaceShop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Service
{
    public class OrderService: IOrderService
    {
        private FaceShop_DB_Context db = new FaceShop_DB_Context();

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }
        public Order GetOrderById(long id)
        {
            return db.Orders.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
