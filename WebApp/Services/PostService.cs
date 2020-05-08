using WebApp.Models;

namespace WebApp.Services
{
    public class PostService
    {
        private readonly ApplicationContext _appContext;

        public PostService(ApplicationContext db)
        {
            _appContext = db;
        }
        
        
    }
}