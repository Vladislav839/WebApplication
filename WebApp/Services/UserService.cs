using System;
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
            var a = _appContext.PostModels.Where(p => p.OwnerId == user_id);
            IEnumerable<Post> b;
            List<Post> c = new List<Post>();
            if (a != null)
            {
                b = a.Select(Mappers.BuildPost);
                if (b != null)
                {
                    c = b.OrderByDescending(p => p.Time).ToList();
                }
            };
            return c;
        }
        public List<Post> GetNews(int user_id)
        {
            List<Post> news = new List<Post>();
            var followers = GetFollowsModels(user_id);
            if (followers != null)
            {
                foreach (var f in followers)
                {
                    if (f != null)
                    {
                        foreach (var p in _appContext.PostModels.Where(pm => pm.OwnerId == f.Id))
                        {
                            news.Add(Mappers.BuildPost(p));
                        }
                    }
                }
            }
            var sortedUsers = from u in news
                orderby u.Time descending
                select u;
            return sortedUsers.ToList();
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
        public UserModel FindModelById(int id)
        {
            return _appContext.UserModels.FirstOrDefault(user => user.Id == id);
        }

        public User FindByName(string name)
        {
            return _appContext.UserModels.Select(Mappers.BuildUser).FirstOrDefault(user => user.NickName == name);
        }

        public void SwitchFollowUser(int senderId, int targetId)
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
                    
                    _appContext.UserModels.FirstOrDefault(u => u.Id == senderId).subscriptionsQuantity 
                        = currentUser.subscriptionsQuantity + 1;

                    _appContext.UserModels.FirstOrDefault(u => u.Id == targetId).subscribersQuantity 
                        = targetUser.subscribersQuantity + 1;

                    
                    _appContext.SaveChanges();
                }
                else
                {
                    _appContext.Subscribers.Remove(_appContext.Subscribers.FirstOrDefault(s=> s.senderId == senderId && s.targetId == targetId));
                    
                    _appContext.UserModels.FirstOrDefault(u => u.Id == senderId).subscriptionsQuantity 
                        = currentUser.subscriptionsQuantity - 1;

                    _appContext.UserModels.FirstOrDefault(u => u.Id == targetId).subscribersQuantity 
                        = targetUser.subscribersQuantity - 1;
                    
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
        public List<UserModel> GetFollowsModels(int userId)
        {
            List<Subscriber> subPairs = _appContext.Subscribers.Where(s => s.senderId == userId).ToList();
            List<UserModel> followers = new List<UserModel>();
            foreach (var s in subPairs)
            {
                followers.Add(FindModelById(s.targetId));
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
        
        public void SwitchLikePost(int userId, int postId)
        {
            UserModel user = _appContext.UserModels.FirstOrDefault(u => u.Id == userId);
            PostModel targetPost = _appContext.PostModels.FirstOrDefault(p => p.Id == postId);
            if (user != null && targetPost != null)
            {
                if (_appContext.LikesPosts.FirstOrDefault(lp =>
                    lp.RatingPersonId == user.Id && lp.PostId == targetPost.Id) == null)
                {
                    LikePost sub = new LikePost()
                    {
                        RatingPerson = user,
                        RatingPersonId = userId,
                        PostModel = targetPost,
                        PostId = postId
                    };

                    _appContext.LikesPosts.Add(sub);
                    _appContext.PostModels.FirstOrDefault(u => u.Id == postId).Rating =
                        targetPost.Rating + 1;
                    _appContext.SaveChanges();
                }
                else
                {
                    _appContext.LikesPosts.Remove(_appContext.LikesPosts.FirstOrDefault(lp => lp.PostId == postId && lp.RatingPersonId == userId));
                    _appContext.PostModels.FirstOrDefault(u => u.Id == postId).Rating =
                        targetPost.Rating - 1;
                    _appContext.SaveChanges();
                }
            }
        }

        public bool IsSubscribedOnUser(int targetId, int userId)
        {
            UserModel currentUser = _appContext.UserModels.FirstOrDefault(user => user.Id == userId);
            UserModel targetUser = _appContext.UserModels.FirstOrDefault(user => user.Id == targetId);
            if (FindById(userId) != null && FindById(targetId) != null)
                if (_appContext.Subscribers.FirstOrDefault(s =>
                    s.senderId == currentUser.Id && s.targetId == targetUser.Id) == null)
                    return false;
            return true;
        }
        public List<User> UserSearch(string request)
        {
            var users = _appContext.UserModels.Select(Mappers.BuildUser).Where(p => p.NickName.ToUpper().Contains(request.ToUpper())).ToList();
            return users;
        }
    }
}