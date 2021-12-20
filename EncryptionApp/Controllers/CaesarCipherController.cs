using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncryptionApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncryptionApp.Controllers
{
    public class CaesarCipherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CaesarCipherAlgorithm obj) {
            ViewBag.Result = obj.Crypt();
            return View();
        }
    }
}
