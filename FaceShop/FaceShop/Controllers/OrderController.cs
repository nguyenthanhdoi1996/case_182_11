using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaceShop.DB_Context;
using FaceShop.Entities;
using FaceShop.Interface;
using FaceShop.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FaceShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController   
    {
        private IOrderService orderService = new OrderService();
        public OrderController(FaceShop_DB_Context context,
            IConfiguration configuration) :
            base(context, configuration)
        { }

        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns></returns>
        [Route("GetAllOrder")]
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllOrder()
        {
            return orderService.GetAll();
        }

        [Route("GetAllById/{id}")]
        [HttpGet]
        public Order GetOrderById(long id)
        {
            return orderService.GetOrderById(id);
        }

        [Route("GetAllByOrderDetailId/{id}")]
        [HttpGet]
        public Order GetOrderByOrderDetalId(long id)
        {
            return orderService.GetOrderByOrderDetalId(id);
        }
        [Route("searchOrderByUserId/{id}")]
        [HttpGet]
        public ApiJsonResult GetOrderByUserId(long id)
        {
            var Order = orderService.GetOrderByUserId(id);
            return new ApiJsonResult { Success = true, Data = Order };
        }
        [Route("GetAllByUserId/{id}")]
        [HttpGet]
        public ApiJsonResult GetAllByUserId(long id)
        {
            var Order = orderService.GetAllByUserId(id);
            return new ApiJsonResult { Success = true, Data = Order };
        }
        [Route("LockOrderByOrderId/{id}")]
        [HttpGet]
        public ApiJsonResult LockOrderByOrderId(long id)
        {
             orderService.LockOrderByUserId(id);
            return new ApiJsonResult { Success = true, Data = null };
        }
    }
}