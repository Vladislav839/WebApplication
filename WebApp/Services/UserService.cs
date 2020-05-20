using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.Xml;
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
            return _appContext.UserModels.Select(Mappers.BuildUser).ToList();
        }

        /*public List<Post> GetLikedPosts(int userId)
        {
            var likepost = _appContext.LikesPosts.Where(lp => lp.RatingPersonId == userId).ToList();
            List<Post> likedPosts = new List<Post>();
            foreach (var lp in likepost)
            {
                likedPosts.Add(Mappers.BuildPost(lp.PostModel));
            }

            return likedPosts;
        }*/
        
        public List<Post> GetPosts(int user_id)
        {
            var a = _appContext.PostModels.Where(p => p.OwnerId == user_id)?.Select(Mappers.BuildPost)?.OrderByDescending(p => p.Time).ToList();
            return a;
        }
        
        /*public List<Subscriber> GetInputSubscriptions(int id)
        {
            return FindById(id).InputSubscriptions;
        }
        
        public List<Subscriber> GetOutputSubscriptions(int id)
        {
            return FindById(id).OutputSubcriptions;
        }*/
        public User FindById(int id)
        {
            return _appContext.UserModels.Select(Mappers.BuildUserInformation).FirstOrDefault(user => user.Id == id);
        }

        public User FindByName(string name)
        {
            return _appContext.UserModels.Select(Mappers.BuildUser).FirstOrDefault(user => user.NickName == name);
        }

        public void FollowUser(int senderId, int targetId)
        {
            UserModel currentUser = _appContext.UserModels.FirstOrDefault(user => user.Id == senderId);
            UserModel targetUser = _appContext.UserModels.FirstOrDefault(user => user.Id == targetId);
            if (FindById(senderId) != null && FindById(targetId) != null)
            {
                if (_appContext.Subscribers.FirstOrDefault(s =>
                    s.senderId == currentUser.Id && s.targetId == targetUser.Id) == null)
                {
                    Subscriber sub = new Subscriber()
                    {
                        sender = currentUser,
                        senderId = senderId,
                        target = targetUser,
                        targetId = targetId
                    };

                    _appContext.Subscribers.Add(sub);
                    _appContext.UserModels.FirstOrDefault(u => u.Id == senderId).subscriptionsQuantity =
                        currentUser.subscriptionsQuantity + 1;
                    _appContext.UserModels.FirstOrDefault(u => u.Id == targetId).subscribersQuantity = 
                        currentUser.subscribersQuantity + 1;
                    _appContext.UserModels.FirstOrDefault(u => u.Id == senderId).OutputSubscribtions.Add(sub);
                    _appContext.UserModels.FirstOrDefault(u => u.Id == targetId).InputSubscriptions.Add(sub);
                    _appContext.SaveChanges();
                }
            }
        }

        public void UnfollowUser(int senderId, int targetId)
        {
            UserModel currentUser = _appContext.UserModels.FirstOrDefault(user => user.Id == senderId);
            UserModel targetUser = _appContext.UserModels.FirstOrDefault(user => user.Id == senderId);
            if (FindById(senderId) != null && FindById(targetId) != null)
            {
                if (_appContext.Subscribers.FirstOrDefault(s =>
                    s.senderId == currentUser.Id && s.targetId == targetUser.Id) != null)
                {
                    _appContext.Subscribers.Remove(_appContext.Subscribers.FirstOrDefault(s=> s.senderId == senderId && s.targetId == targetId));
                    _appContext.SaveChanges();
                }
            }
        }

        public List<User> GetFollowers(int userId)
        {
            List<Subscriber> subPairs = _appContext.Subscribers.Where(s => s.targetId == userId).ToList();
            List<User> followers = new List<User>();
            foreach (var s in subPairs)
            {
                followers.Add(FindById(s.senderId));
            }
            return followers;
        }
        public List<User> GetFollows(int userId)
        {
            List<Subscriber> subPairs = _appContext.Subscribers.Where(s => s.senderId == userId ).ToList();
            List<User> follows = new List<User>();
            foreach (var s in subPairs)
            {
                follows.Add(FindById(s.targetId));
            }
            return follows;
        }
    }
}