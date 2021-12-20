using EncryptionApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptionApp.Controllers {
    public class MorseController : Controller {

        public IActionResult Index() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MorseAlgorithm obj) {
            ViewBag.Result = obj.Crypt();
            return View();
        }
    }
}
