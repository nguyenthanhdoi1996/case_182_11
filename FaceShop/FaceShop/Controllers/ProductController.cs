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
    public class ProductController : BaseController
    {
        private IProductService productService = new ProductService();
        public ProductController(FaceShop_DB_Context context,
            IConfiguration configuration) :
            base(context, configuration)
        { }

        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns></returns>
        [Route("GetAllProduct")]
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllOrder()
        {
            return productService.GetAll();
        }

        [Route("GetAllById/{id}")]
        [HttpGet]
        public Product GetOrderById(long id)
        {
            return productService.GetCartrById(id);
        }
    }
}