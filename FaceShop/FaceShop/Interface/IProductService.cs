﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaceShop.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FaceShop.Interface
{
    interface IProductService
    {
        List<Product> GetAll();
        Product GetAllById(long id);
        Product GetProducByUserId(long id);
    }
}
