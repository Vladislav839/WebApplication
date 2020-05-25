using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using System.Security.Claims;
using WebApp.Services;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

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
            //------новые изменения-------
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.NickName == User.Identity.Name).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
        }

        public IActionResult Photos()
        {
            //------новые изменения-------
            var photos = _db.PhotoModels.Where(u => u.Owner == User.Identity.Name).ToList();
            return View(photos);
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
                PhotoModel model = new PhotoModel {Owner = User.Identity.Name, Path = path};
                _db.PhotoModels.Add(model);
                await _db.SaveChangesAsync();
                _db.SaveChanges();
            }
            
            return RedirectToAction("Photos", "User");
        }
    }
}