using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class PostController
    {
        private readonly ApplicationContext _db;
        private readonly UserService _userService;
        public PostController(ApplicationContext context)
        {
            _db = context;
            _userService = new UserService(_db);
        }
    }
}