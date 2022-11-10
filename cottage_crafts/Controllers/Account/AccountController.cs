using cottage_crafts.data;
using cottage_crafts.Models.Account;
using cottage_crafts.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace cottage_crafts.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly AppDbContext context;

        public AccountController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginSignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = context.Users.Where(e => e.Username == model.Username).SingleOrDefault();
                if(data != null)
                {
                    bool isValid = (data.Username==model.Username && data.Password==model.Password);
                    if (isValid)
                    {
                        var identity = new ClaimsIdentity(new[] {new Claim(ClaimTypes.Name, model.Username) }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString("Username", model.Username);
                        return RedirectToAction("Index","Crafts");
                    }
                    else
                    {
                        TempData["errorMessage_password"] = "Invalid Password";
                        return View(model);
                    }
                }
                else
                {
                    TempData["errorMessage_username"] = "Username not found";
                    return View(model);
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var storedCookies = Request.Cookies.Keys;
            foreach(var cookies in storedCookies)
            {
                Response.Cookies.Delete(cookies);
            }
            return RedirectToAction("Login", "Account");
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new User()
                {
                    Username = model.Username,
                    Email = model.Email,
                    Password = model.Password,
                    Mobile_no = model.Mobile_no
                };
                context.Users.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "You are eligible for login , Kindly enter your credentials correctly !!";
                return RedirectToAction("Login");
            }
            else
            {
                TempData["errorMessage"] = "Empty form can't be submitted!!";
                return View();
            }
           
        }

    }
}
