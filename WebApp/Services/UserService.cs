using System.Collections.Generic;
using System.Dynamic;
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

        public List<User> GetFriendList(int id)
        {
            var userFriends1 = FindById(id).Friends1;
            List<User> friends = null;
            foreach (var f in userFriends1)
            {
                if(f.Person1Id!= id) { friends.Add(Mappers.BuildUser(f.Person1));} else friends.Add(Mappers.BuildUser(f.Person2));
            }
            var userFriends2 = FindById(id).Friends2;
            foreach (var f in userFriends2)
            {
                if(f.Person1Id!= id) { friends.Add(Mappers.BuildUser(f.Person1));} else friends.Add(Mappers.BuildUser(f.Person2));
            }

            return friends;
        }
        public List<int> GetFriendListId(int id)
        {
            var userFriends1 = FindById(id).Friends1;
            List<int> friends = null;
            foreach (var f in userFriends1)
            {
                if(f.Person1Id!= id) { friends.Add(f.Person1Id);} else friends.Add(f.Person2Id);
            }
            var userFriends2 = FindById(id).Friends2;
            foreach (var f in userFriends2)
            {
                if(f.Person1Id!= id) { friends.Add(f.Person1Id);} else friends.Add(f.Person2Id);
            }

            return friends;
        }

        public int GetId(User u)
        {
            return u.Id;
        }

        public string GetNickname(int id)
        {
            return FindById(id).NickName;
        }
        
        public List<User> GetUsers()
        {
            return _appContext.Users.Select(Mappers.BuildUser).ToList();
        }
        public User FindById(int id)
        {
            return _appContext.Users.Select(Mappers.BuildUser).FirstOrDefault(user => user.Id == id);
        }

        public List<Post> GetPosts(int user_id)
        {
            return _appContext.Posts.Select(Mappers.BuildPost).Where(p => FindById(p.owner).Id == user_id).ToList();
        }
        
    }
}