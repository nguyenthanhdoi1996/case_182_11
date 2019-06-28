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
        private IRepository<Order> _order;
             private IRepository<searchProduct> _searchProduct;

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }
        public Order GetOrderById(long id)
        {
            return db.Orders.Where(x => x.Id == id).FirstOrDefault();
        }
        public Order GetOrderByOrderDetalId(long id)
        {
            return db.Orders.Where(x => x.Id == id).FirstOrDefault();
        }
        public SearchOrder GetOrderByUserId(long id)
        {
            SearchOrder searchorder = new SearchOrder();
            searchProduct searchproduct = new searchProduct();
            Order order = new Order();
            Product product = new Product();
            List<OrderDetail> listorderdetail = new List<OrderDetail>();
            List<Order> listorder = new List<Order>();
            List<searchProduct> listsearchproduct = new List<searchProduct>();
            int i = 1;
            listorder = db.Orders.Where(x => x.UserId == id).ToList();
            listorder.ForEach(c =>
            {
                List<Product> listproduct = new List<Product>();
                var listorderdetails = db.OrderDetails.Where(a => a.OrderId == c.Id).ToList();
                listorderdetails.ForEach(z =>
                {
                    
                    product = db.Products.Where(d => d.Id == z.ProductId).FirstOrDefault();
                    listproduct.Add(product);
                });
                searchproduct.order = c;
                searchproduct.listorderdetail = listorderdetails;
                searchproduct.listproduct = listproduct;
                listsearchproduct.Add(searchproduct);
            });
            return searchorder;
        }
        public List<Order> GetAllByUserId(long id)
        {
            return db.Orders.Where(x => x.UserId == id).ToList();
        }
        public void LockOrderByUserId(long id)
        {
            var order = db.Orders.Where(x => x.Id == id).FirstOrDefault();
            order.IsOrder = 0;
            db.Orders.Update(order);
            db.SaveChanges();
        }
    }
}
