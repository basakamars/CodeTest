using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCore.Encrypt;
using CryptJS_NetCore.Encrypt_Test.Models;

namespace CryptJS_NetCore.Encrypt_Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var key = "123456789012345678901234567890AA";
            var iv = "1234567890ABCDEF";
            string str = "Hi Crypt AES";
            ViewBag.CryptCode= EncryptProvider.AESEncrypt(str, key, iv);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
