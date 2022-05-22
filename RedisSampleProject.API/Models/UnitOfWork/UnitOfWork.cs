using Microsoft.EntityFrameworkCore;
using RedisSampleProject.API.Models.DAL;
using RedisSampleProject.API.Models.DB.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSampleProject.API.Models.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(RedisSampleContext context)
        {
            _context = context;
            Users = new UserDAL(context);
        }

        public IUserDAL Users { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
           return  _context.SaveChanges();
        }
    }
}
