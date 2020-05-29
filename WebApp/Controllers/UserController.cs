using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationContext _db;
        private readonly UserService _userService;
        private IWebHostEnvironment _appEnvironment;

        public UserController(ApplicationContext context, IWebHostEnvironment iWebHostEnvironment)
        {
            _db = context;
            _userService = new UserService(_db);
            _appEnvironment = iWebHostEnvironment;
        }

        [Authorize]
        public async Task<IActionResult> Index(int id)
        {
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.Id == id).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
        }
        public async Task<IActionResult> News(int id)
        {
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.Id == id).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
        }
        public async Task<IActionResult> Photos(int id)
        {
            //------новые изменения-------
            /*var photos = _db.PhotoModels.Where(u => u.Owner == User.Identity.Name).ToList();
            return View(photos);*/
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.Id == id).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
        }
    

        [HttpPost]
        public async Task<IActionResult> AddPhoto(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                PhotoModel model = new PhotoModel {OwnerId = _userService.FindByName(User.Identity.Name).Id, Path = path};
                _db.PhotoModels.Add(model);
                await _db.SaveChangesAsync();
                _db.SaveChanges();
            }
            
            return RedirectToAction("Photos", "User", new {id = _userService.FindByName(User.Identity.Name).Id});
        }
        public async Task<IActionResult> Subscribers(int id)
        {
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.Id == id).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
        }

        public async Task<IActionResult> Subscriptions(int id)
        {
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.Id == id).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
        }

        public async Task<IActionResult> Search(string request)
        {
            return View(new SearchRequest()
            {
                RequestText = request
            });
        }
    }
}