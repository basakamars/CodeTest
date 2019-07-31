using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_Cache_Test.Models;
using Microsoft.Extensions.Caching.Memory;

namespace Core_Cache_Test.Controllers
{
    public class HomeController : Controller
    {
        //重写new引入cache
        private IMemoryCache _cache;

        public HomeController(IMemoryCache cache)
        {
            _cache = cache;
        }
        public IActionResult Index()
        {
            DateTime cachedatetime = DateTime.Now;//缓存数据
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(3));//缓存过期时间差值
            _cache.Set("cache1", cachedatetime, cacheEntryOptions);//写入缓存(set没有异步方式)


            return View();
        }

        public IActionResult Privacy()
        {
            //方法一
            var d = _cache.Get<DateTime?>("cache1");
            //方法二
            DateTime data;
            if (!_cache.TryGetValue("cache1", out data))
            {
                //没有找到todo
            }

            //删除
            _cache.Remove("cache1");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
