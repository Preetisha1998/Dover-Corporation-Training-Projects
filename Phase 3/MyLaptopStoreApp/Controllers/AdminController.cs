using IdentitySecuredApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySecuredApp.Controllers
{
    public class AdminController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (user.UserName=="admin" && user.Password=="admin")
            {
                return RedirectToAction("Index", "Laptops", new { uname = user.UserName });
            }
            else
                ViewBag.msg = "Invalid input credentials...";
            return View();
        }
        //public IActionResult dashboard(string uname)
        //{
        //    ViewBag.msg = $"Hello{uname},welcome to dashboard";
        //    return View();
        //}
    }
}
