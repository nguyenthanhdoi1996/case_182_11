using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceShop.Interface
{
    public interface IRepository<T> 
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        //IEnumerable<T> GetAllWithCache();
        //IEnumerable<T> GetAllWithCache(EFCacheDebugInfo dbug);
        //T GetWithCache(long id);
        void Insert(T entity);
        void InsertRange(List<T> entities);

        bool Update(T entity);
        void Delete(T entity);

        void DeleteAll(List<T> entities);

        IQueryable<T> Queryable();

        void DeleteAllEntities(string tableName);
    }
}
