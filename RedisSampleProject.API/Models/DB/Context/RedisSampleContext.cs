using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RedisSampleProject.API.Models.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSampleProject.API.Models.DB.Context
{
    public class RedisSampleContext : DbContext
    {
        public RedisSampleContext(DbContextOptions<RedisSampleContext> options) : base(options)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(@"Server=localhost,1400;Initial Catalog=RedisSampleDB;Persist Security Info=True;User ID=sa;Password=Password_123;MultipleActiveResultSets=True;");
        }

        public DbSet<User> Users { get; set; }
    }
}
