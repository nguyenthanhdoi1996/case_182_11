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
    public class OrderDetailController : BaseController
    {
        private IOrderDetailService orderDetailService = new OrderDetailService();
        public OrderDetailController(FaceShop_DB_Context context,
            IConfiguration configuration) :
            base(context, configuration)
        { }

        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns></returns>
        [Route("GetAllOrderDetail")]
        [HttpGet]
        public ActionResult<IEnumerable<OrderDetail>> GetAllOrder()
        {
            return orderDetailService.GetAll();
        }

        [Route("GetAllById/{id}")]
        [HttpGet]
        public OrderDetail GetOrderById(long id)
        {
            return orderDetailService.GetOrderById(id);
        }
    }
}