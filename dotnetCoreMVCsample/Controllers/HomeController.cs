using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace dotnetCoreMVCsample.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            string displayText = configuration["constr"];
            ViewBag.displayText = displayText;

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
                //ViewData["ErrorMsg"] = "[Error] Invalid User or Password";
                ViewBag.msg = "[Error] Invalid User or Password";
                return View();
            }
            
        }

        public IActionResult ContactDetails()
        {
            return View();
        }
    }
}