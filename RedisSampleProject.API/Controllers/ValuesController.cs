using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisSampleProject.API.Models.DB.Entity;
using RedisSampleProject.API.Models.UnitOfWork;
using RedisSampleProject.API.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSampleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IUnitOfWork _uow;
        public ValuesController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpGet("getusers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = (from u in await _uow.Users.GetAllAsync()
                          select new UserVMList()
                          {
                              UserName = u.UserName,
                              Email = u.Email
                          });
            
            return Ok(result);
        }

        [HttpPost("adduser")]
        public IActionResult AddUser(UserVM vm)
        {
            byte[] passHash, passSalt;
            User user = new User();
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(vm.Password));
                passSalt = hmac.Key;
            }
            user.UserName = vm.UserName;
            user.PasswordHash = passHash;
            user.PasswordSalt = passSalt;
            user.Email = vm.Email;
            user.IsActive = true;
            user.ModifiedDate = DateTime.Now;
            user.CreatedDate = DateTime.Now;
            _uow.Users.Add(user);
            _uow.SaveChanges();
            return StatusCode(201);
        }
    }
}
