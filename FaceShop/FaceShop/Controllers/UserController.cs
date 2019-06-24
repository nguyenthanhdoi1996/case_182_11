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
    public class UserController : BaseController
    {
        private IUserService userService = new UserService();
        public UserController(FaceShop_DB_Context context,
            IConfiguration configuration) :
            base(context, configuration)
        { }

        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns></returns>
        [Route("GetAllUser")]
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllOrder()
        {
            return userService.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("LoginByUsernameAndPassword")]
        [HttpPost]
        public ActionResult LoginByUsernameAndPassword([FromBody]Login input)
        {
            var user = userService.LoginByUsernameAndPassword(input);
            if(user == null)
            {
                return BadRequest(new { message = "user name or password is inconnect" });
            }
            return Ok(user);
        }
    }
}