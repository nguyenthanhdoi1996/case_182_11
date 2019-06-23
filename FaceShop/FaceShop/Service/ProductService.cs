using FaceShop.DB_Context;
using FaceShop.Entities;
using FaceShop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Service
{
    public class ProductService: IProductService
    {
        private FaceShop_DB_Context db = new FaceShop_DB_Context();

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public Product GetCartrById(long id)
        {
            return db.Products.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
