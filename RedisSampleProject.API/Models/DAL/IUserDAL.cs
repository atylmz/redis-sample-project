using RedisSampleProject.API.Models.DB.Entity;
using RedisSampleProject.API.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSampleProject.API.Models.DAL
{
    public interface IUserDAL : IEntityRepository<User>
    {
      
    }
}
