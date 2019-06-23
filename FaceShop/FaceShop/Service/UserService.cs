using FaceShop.DB_Context;
using FaceShop.Entities;
using FaceShop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Service
{
    public class UserService: IUserService
    {
        private FaceShop_DB_Context db = new FaceShop_DB_Context();

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }
        public User GetOrderById(long id)
        {
            return db.Users.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
