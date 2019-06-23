using FaceShop.DB_Context;
using FaceShop.Entities;
using FaceShop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Service
{
    public class CartService: ICartService
    {
        private FaceShop_DB_Context db = new FaceShop_DB_Context();

        public List<Cart> GetAll()
        {
            return db.Carts.ToList();
        }
        public Cart GetCartById(long id)
        {
            return db.Carts.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
