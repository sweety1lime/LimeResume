using LimeResume.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace LimeResume.Controllers
{
    public class HomeController : Controller
    {
        private readonly LimeResumeContext db;

        public HomeController(LimeResumeContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var resume = new Resume();
            if (HttpContext.Session.Keys.Contains("User"))
            {
                var user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("User"));
                resume = db.Resumes.First(x => x.IdResume == user.IdUser);
            }
            return View(resume);
        }

        public IActionResult RegAuth()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrate(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
                return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authenticate(LoginModell model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.FirstOrDefault(u => u.Login == model.login && u.Password == model.password);
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimsIdentity.DefaultNameClaimType, model.login)
                    };
                    ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
                    HttpContext.Session.SetString("User", JsonSerializer.Serialize(user));

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return RedirectToAction("RegAuth", "Home");
        }

        public IActionResult AllBase()
        {
            List<Company> companies = db.Companies.ToList();
            return View(companies);
        }
    }
}
