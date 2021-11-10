using IdentitySecuredApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySecuredApp.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        private bool ValidateUser(string uname, string pwd)
        {
            List<UserModel> users = new List<UserModel>()
            {
                new UserModel{UserName="Seller1",Password="Seller1@123"},
                new UserModel{UserName="Seller2",Password="Seller2@123"},
                new UserModel{UserName="Seller3",Password="Seller3@123"},
                new UserModel{UserName="Seller4",Password="Seller4@123"},
            };
            return users.Exists(x => x.UserName == uname && x.Password == pwd);
        }
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (ValidateUser(user.UserName, user.Password))
            {
                return RedirectToAction("SellerIndex", "Laptops", new { uname = user.UserName });
            }
            else
                ViewBag.msg = "Invalid input credentials...";
            return View();
        }
    }
}
