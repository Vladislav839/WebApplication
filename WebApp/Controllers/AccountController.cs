using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApp.ViewModels; // пространство имен моделей RegisterModel и LoginModel
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApp.Models;
using System.Linq;
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AuthApp.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationContext db;
        private IWebHostEnvironment _appEnvironment;
        public AccountController(ApplicationContext context, IWebHostEnvironment iWebHostEnvironment)
        {
            db = context;
            _appEnvironment = iWebHostEnvironment;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.NickName == model.NickName && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(model.NickName); // аутентификация

                    return RedirectToAction("Index", "User", new {id = user.Id});
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = await _db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    User reguser = new User { Email = model.Email, Password = model.Password, NickName = model.NickName, Path = "~/img/avatar-default.png" };
                    // добавляем пользователя в бд
                    _db.Users.Add(reguser);
                    await _db.SaveChangesAsync();

                    await Authenticate(model.NickName); // аутентификация

                    return RedirectToAction("Index", "Home", reguser);
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        [HttpPost]
        public IActionResult PostPost(string text)
       {
           Post a = new Post {Owner = User.Identity.Name, Text = text, Time = DateTime.Now.ToString()};
           db.Posts.Add(a);
           db.SaveChanges();
           return RedirectToAction("Index", "Home");
       }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            var user = await db.Users.FirstOrDefaultAsync(u => u.NickName == User.Identity.Name);
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                user.Path = path;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index", "Home", user);
        }

        [HttpGet]
        public List<Post> GetPosts()
        {
            return db.Posts.Where(u => u.Owner == User.Identity.Name).ToList();
        }
    }
}