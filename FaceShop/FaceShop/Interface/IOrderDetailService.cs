using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaceShop.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FaceShop.Interface
{
    interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
        OrderDetail GetOrderById(long id);
    }
}
