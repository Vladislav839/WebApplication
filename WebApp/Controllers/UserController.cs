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
            var user = await _db.UserModels.FirstOrDefaultAsync(u => u.Id == id).ConfigureAwait(true);
            return View(Mappers.BuildUser(user));
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