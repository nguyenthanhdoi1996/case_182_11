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
        private List<Product> product = new List<Product>();
        private List<Order> listOrder = new List<Order>();
        private Order order = new Order();

        public List<OrderDetail> GetAll()
        {
            return db.OrderDetails.ToList();
        }
        public OrderDetail GetOrderById(long id)
        {
            return db.OrderDetails.Where(x => x.Id == id).FirstOrDefault();
        }
        public  ListSearchDetail GetOrderByUserIdAsync(long id)
        {
            ListSearchDetail search = new ListSearchDetail();
            searchOrderDetail searchorderdetail = new searchOrderDetail();
            List<searchOrderDetail> listSearchOrderDetail = new List<searchOrderDetail>();
            Product ListProduct = new Product();
            List<OrderDetail> ListOrderDetail = new List<OrderDetail>();
            OrderDetail OderDetail = new OrderDetail();
            OrderDetail orderdetail = new OrderDetail();
            var orderDetail =  db.OrderDetails.Where(x => x.OrderId == id).ToList();
            if(orderDetail != null)
            {
                orderDetail.ForEach(c =>
                {
                    searchorderdetail = new searchOrderDetail();
                    ListProduct = new Product();
                    ListProduct = db.Products.Where(v => v.Id == c.ProductId).FirstOrDefault();
                    
                    var check = ListOrderDetail.Where(d => d.Id == c.Id).FirstOrDefault();
                    if (check == null)
                    {                       
                        searchorderdetail.orderDetail = c;
                        searchorderdetail.Product = ListProduct;
                        
                    }
                    ListOrderDetail.Add(c);
                    listSearchOrderDetail.Add(searchorderdetail);

                });
            };
            search.listsearchOrderDetail = listSearchOrderDetail;
            return search;
            
        }

        public List<OrderDetail> GetAllByUserId(long id)
        {
            return db.OrderDetails.Where(x => x.UserId == id).ToList();
        }
        public List<OrderDetail> GetAllByOrderId(long id)
        {
            return db.OrderDetails.Where(x => x.OrderId == id).ToList();
        }
    }
}
