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
    public class CartController : BaseController
    {
        private ICartService cartService = new CartService();
        public CartController(FaceShop_DB_Context context,
            IConfiguration configuration) :
            base(context, configuration)
        { }

        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns></returns>
        [Route("GetAllCart")]
        [HttpGet]
        public ActionResult<IEnumerable<Cart>> GetAllOrder()
        {
            return cartService.GetAll();
        }

        [Route("GetAllById/{id}")]
        [HttpGet]
        public Cart GetOrderById(long id)
        {
            return cartService.GetCartById(id);
        }
    }
}