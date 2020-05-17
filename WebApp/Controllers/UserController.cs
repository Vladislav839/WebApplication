using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        public UserController(ApplicationContext context)
        {
            _db = context;
            _userService = new UserService(_db);
        }
        
        [Authorize]
        public async Task<IActionResult> Index(int id)
        {
            //------новые изменения-------
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.NickName == User.Identity.Name).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
        }
    }
}