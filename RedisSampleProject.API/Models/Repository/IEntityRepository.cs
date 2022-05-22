using RedisSampleProject.API.Models.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RedisSampleProject.API.Models.Repository
{
   public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        Task<IEnumerable<T>> GetAllAsync();
        int SaveChanges();
    }
}
