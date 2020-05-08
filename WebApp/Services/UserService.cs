using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Services
{
    public class UserService
    {
        private readonly ApplicationContext _appContext;

        public UserService(ApplicationContext db)
        {
            _appContext = db;
        }
        


        public List<User> GetUsers()
        {
            return _appContext.Users.Select(Mappers.BuildUser).ToList();
        }

        public List<Post> GetPosts()
        {
            return _appContext.Posts.Select(Mappers.BuildPost).ToList();
        }
        
        public User FindById(int id)
        {
            return _appContext.Users.Select(Mappers.BuildUser).FirstOrDefault(user => user.Id == id);
        }
        
    }
}