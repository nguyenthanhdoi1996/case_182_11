using FaceShop.DB_Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Controllers
{
    public class BaseController: Controller
    {
        protected FaceShop_DB_Context DbContext;

        public BaseController(FaceShop_DB_Context context,
            IConfiguration configuration)
        {
            DbContext = context;
        }
    }
}
