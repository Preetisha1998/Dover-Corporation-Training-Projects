using IdentitySecuredApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace IdentitySecuredApp.Controllers
{
    public class AccountsController : Controller
    {
        UserManager<IdentityUser> _userManager = null;
        SignInManager<IdentityUser> _signInManager = null;
        public AccountsController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                ViewBag.msg = "User registerd successfully...";
                return RedirectToAction("UserIndex", "Laptops");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                //session to be created after successfull login
                HttpContext.Session.SetString("uname", model.Email);
                ViewBag.msg = "Login success...";
                return RedirectToAction("UserIndex","Laptops");

            }
            else
            {
                ViewBag.msg = "invalid input credentials...";
            }
            return View();
        }
      public IActionResult DashBoard()
        {
            if (HttpContext.Session.GetString("uname") != null)
            {
                string name = HttpContext.Session.GetString("uname");
                ViewBag.msg = $"hello {name} ,welcome to dashboard....";
            }
            else
            {
                ViewBag.msg=$"Landed on this page by a technique ! Invalid";
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("uname") != null)
            {
                string name = HttpContext.Session.GetString("uname");
                ViewBag.msg = $"hello {name} , log out was succesfull";
                HttpContext.Session.Clear();
            }
            else
            {
                ViewBag.msg = $"No user available to logout...";
            }
            return View();
        }

    }
}
