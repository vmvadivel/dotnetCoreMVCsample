using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetCoreMVCsample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //by default it's GET. So it's not necessary to add this line
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string LoginID, string Password)
        {
            if (LoginID == "vadi" && Password == "Pa$$@123")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
               // ViewData["ErrorMsg"] = "[Error] Invalid User or Password";
                ViewBag.msg = "[Error] Invalid User or Password";
                return View();
            }
            
        }
    }
}