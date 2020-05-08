using System.Collections.Generic;
using System.Linq;
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

        public User GetOwner(int id_post)
        {
            return _appContext.Users.Select(Mappers.BuildUser).FirstOrDefault(u => u.Id == _appContext.Posts.Select(Mappers.BuildPost).FirstOrDefault(p => p.Id == id_post).owner);
        }
        
        public List<Post> GetAllPosts()
        {
            return _appContext.Posts.Select(Mappers.BuildPost).ToList();
        }

        public string GetDate(int id_post)
        {
            return _appContext.Posts.Select(Mappers.BuildPost).FirstOrDefault(p => p.Id == id_post).date;
        }

        public int GetRating(int id_post)
        {
            return _appContext.Posts.Select(Mappers.BuildPost).FirstOrDefault(p => p.Id == id_post).rating;
        }

        public Post FindById(int id)
        {
            return _appContext.Posts.Select(Mappers.BuildPost).FirstOrDefault(p => p.Id == id);
        }
    }
}