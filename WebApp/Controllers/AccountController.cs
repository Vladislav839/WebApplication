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
using WebApp.Services;

namespace AuthApp.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationContext _db;
        private IWebHostEnvironment _appEnvironment;
        private UserService _userService;
        private PostService _postService;
        public AccountController(ApplicationContext context, IWebHostEnvironment iWebHostEnvironment)
        {
            _db = context;
            _appEnvironment = iWebHostEnvironment;
            _userService = new UserService(_db);
            _postService = new PostService(_db);
        }
        
        // [HttpPost]
        // public IActionResult Dialog()
        // {
        //
        // }

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
                UserModel user = await _db.UserModels.FirstOrDefaultAsync(u =>
                    u.NickName == model.NickName && u.Password == model.Password);
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
                UserModel user = await _db.UserModels.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    UserModel reguser = new UserModel { Email = model.Email, Password = model.Password, NickName = model.NickName, Path = "/img/avatar-default.png" };
                    // добавляем пользователя в бд
                    _db.UserModels.Add(reguser);
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
        
        public Post SavePost(string text)
        {
            PostModel postModel = new PostModel
            {
                Owner = _db.UserModels.FirstOrDefault(um => um.NickName == User.Identity.Name) == null ? _db.UserModels.FirstOrDefault(um => um.Id == 1) : _db.UserModels.FirstOrDefault(um => um.NickName == User.Identity.Name), 
                Text = text, 
                Time = DateTime.Now.ToString(), 
                OwnerId = _db.UserModels.FirstOrDefault( um => um.NickName == User.Identity.Name)?.Id ?? 1, 
                Rating = 0
            };
            _db.PostModels.Add(postModel);
            _db.SaveChanges();
            return Mappers.BuildPost(postModel);
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
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.NickName == User.Identity.Name);
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
                _db.SaveChanges();
            }
            
            return RedirectToAction("Index", "Home", user);
        }

        [HttpGet]
        public List<Post> GetPosts(int Id)
        {
            int id = _userService.FindByName(User.Identity.Name).Id;
            List<Post> a = _userService.GetPosts(Id);
            return a;
        }
        [HttpGet]
        public List<User> GetSubscribersInput(int Id)
        {
            int a = Id;
            int id = _userService.FindByName(User.Identity.Name).Id;
            return _userService.GetFollowers(Id);
        }
        [HttpGet]
        public List<User> GetSubscribersOutput(int Id)
        {
            int a = Id;
            int id = _userService.FindByName(User.Identity.Name).Id;
            return _userService.GetFollows(a);
        }
        
        public IActionResult Subscribers(int id)
        {
            var iduser = _userService.FindById(id);
            var user = _userService.FindByName(User.Identity.Name);
            return RedirectToAction("Subscribers", "User", new {id = iduser.Id});
        }
        public IActionResult Subscriptions(int id)
        {
            var iduser = _userService.FindById(id);
            var user = _userService.FindByName(User.Identity.Name);
            return RedirectToAction("Subscriptions", "User", new {id = iduser.Id});
        }

        [HttpPost]
        public void Subscribe(string target)
        {
            int senderId = _userService.FindByName(User.Identity.Name).Id;
            int targetId = _userService.FindByName(target).Id;
            _userService.FollowUser(senderId, targetId);
        }

        public IActionResult Index(int id)
        {
            var iduser = _userService.FindById(id);
            var user = _userService.FindByName(User.Identity.Name);
            return RedirectToAction("Index", "User", new {id = iduser.Id});
        }
        public IActionResult IndexByName(string username)
        {
            var iduser = _userService.FindByName(username);
            var user = _userService.FindByName(User.Identity.Name);
            return RedirectToAction("Index", "User", new {id = iduser.Id});
        }

        public void SwitchLikePost(string userName, int postId)
        {
            _userService.SwitchLikePost(_userService.FindByName(userName).Id, postId);
        }
    }
}