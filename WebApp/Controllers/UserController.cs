using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationContext _db;
        public UserController(ApplicationContext context)
        {
            _db = context;
        }
        
        [Authorize]
        public async Task<IActionResult> Index(int id)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == id).ConfigureAwait(true);
            return View(user);
        }
    }
}