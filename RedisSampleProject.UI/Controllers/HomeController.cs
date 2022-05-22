using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using RedisSampleProject.UI.Models;
using RedisSampleProject.UI.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RedisSampleProject.UI.Common;
using RedisSampleProject.UI.Provider;

namespace RedisSampleProject.UI.Controllers
{
    public class HomeController : Controller
    {
        IDistributedCache _cache;
        UserProvider _prov;

        public HomeController(IDistributedCache cache, UserProvider prov)
        {
            _cache = cache;
            _prov = prov;
        }

        public async Task<IActionResult> Index()
        {
            List<UserVMList> list;
            string location = "";
            string isCache = "";
            string key = "users_" + DateTime.Now.ToString("yyyyMMdd_hhmm");
            list = await _cache.GetRecordAsync<List<UserVMList>>(key);
            if (list is null)
            {
                list = await _prov.GetAllUsers();
                await _cache.SetRecordAsync<List<UserVMList>>(key, list);
                location = $"This data loaded from API at {DateTime.Now}";
                isCache = "";
            }
            else
            {
                location = $"This data loaded from REDIS at {DateTime.Now}";
                isCache = "text-danger";
            }
            ViewBag.Location = location;
            ViewBag.Cache = isCache;
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(string userName, string password, string eMail)
        {
            UserVM user = new UserVM();
            user.Email = eMail;
            user.Password = password;
            user.UserName = userName;
            string result = await _prov.AddUser(user);
            if (result != ":(")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest(); 
            }
           
        }
    }
}

