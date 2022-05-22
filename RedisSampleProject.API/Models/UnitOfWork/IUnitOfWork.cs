using RedisSampleProject.API.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSampleProject.API.Models.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserDAL Users { get; }
        int SaveChanges();
    }
}
