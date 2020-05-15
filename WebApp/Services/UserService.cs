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

        /*public List<User> GetFriendList(int id)
        {
            var userFriends1 = FindById(id)?.FriendsOut ?? new List<Friend>();
            List<User> friends = new List<User>();
            foreach (var f in userFriends1)
            {
                if(f.PersonInputRequestId!= id) { friends.Add(Mappers.BuildUser(f.PersonOutputRequest));} else friends.Add(Mappers.BuildUser(f.PersonInputRequest));
            }
            var userFriends2 = FindById(id)?.FriendsIn ?? new List<Friend>();
            foreach (var f in userFriends2)
            {
                if(f.PersonInputRequestId!= id) { friends.Add(Mappers.BuildUser(f.PersonOutputRequest));} else friends.Add(Mappers.BuildUser(f.PersonInputRequest));
            }

            return friends;
        }*/
        
        /*public List<int> GetFriendListId(int id)
        {
            var userFriends1 = FindById(id)?.FriendsOut ?? new List<Friend>();
            List<int> friends = new List<int>();
            foreach (var f in userFriends1)
            {
                if(f.PersonInputRequestId!= id) { friends.Add(f.PersonInputRequestId);} else friends.Add(f.PersonOutputRequestId);
            }
            var userFriends2 = FindById(id)?.FriendsIn ?? new List<Friend>();
            foreach (var f in userFriends2)
            {
                if(f.PersonInputRequestId!= id) { friends.Add(f.PersonInputRequestId);} else friends.Add(f.PersonOutputRequestId);
            }

            return friends;
        }*/
        
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
            return _appContext.PostModels.Select(Mappers.BuildPost).Where(p => FindById(p.OwnerId).Id == user_id).ToList();
        }
        
        /*public List<Subscriber> GetInputRequests(int id)
        {
            return FindById(id).InputSubscriptions;
        }
        
        public List<Subscriber> GetOutputRequests(int id)
        {
            return FindById(id).OutputSubcriptions;
        }*/
        public User FindById(int id)
        {
            return _appContext.UserModels.Select(Mappers.BuildUser).FirstOrDefault(user => user.Id == id);
        }

        public User FindByName(string name)
        {
            return _appContext.UserModels.Select(Mappers.BuildUser).FirstOrDefault(user => user.NickName == name);
        }
        
        /*public void SendOutputRequest(int senderId, int targetId)
        {
            if (FindById(senderId) != null 
                && FindById(targetId) != null)
            {
                var senderModel = _appContext.UserModels.FirstOrDefault(um => um.Id == senderId);
                var targetModel = _appContext.UserModels.FirstOrDefault(um => um.Id == targetId);
                _appContext.UserModels.FirstOrDefault(um => um.Id == senderId)?.OutputSubscribtions.Add(
                    new Subscriber()
                    {
                        sender = senderModel,
                        senderId = senderId,
                        target = targetModel,
                        targetId = targetId
                    });
                _appContext.UserModels.FirstOrDefault(um => um.Id == targetId)?.InputSubscriptions.Add(
                    new Subscriber()
                    {
                        sender = senderModel,
                        senderId = senderId,
                        target = targetModel,
                        targetId = targetId
                    });
            }
        }
        
        public void AcceptOutputRequest(int senderId, int targetId)
        {
            FindById(senderId)?.FriendsOut.Add(
                new Friend()
                {
                    PersonOutputRequest = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId)?.sender,
                    PersonInputRequestId = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId).senderId,
                    PersonInputRequest = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId).target,
                    PersonOutputRequestId = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId).targetId
                }
                );
            FindById(targetId)?.FriendsIn.Add(
                new Friend()
                {
                    PersonOutputRequest = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId).sender,
                    PersonInputRequestId = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId).senderId,
                    PersonInputRequest = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId).target,
                    PersonOutputRequestId = FindById(senderId).OutputSubcriptions
                        .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId).targetId
                }
            );
            
            FindById(senderId)?.OutputSubcriptions.Remove(FindById(senderId).OutputSubcriptions
                .FirstOrDefault(s => s.senderId == senderId && s.targetId == targetId));
            
        }*/

        /*public void DeleteFriend(int userId, int targetId)
        {
            if (FindById(userId) != null 
                && FindById(targetId) != null 
                && _appContext.Friends
                    .FirstOrDefault(f => (f.PersonInputRequestId == userId 
                                         && f.PersonOutputRequestId == targetId) 
                                         ||(f.PersonInputRequestId == targetId
                                            && f.PersonOutputRequestId == userId)) != null)
            {
                _appContext.Subscribers.Add(new Subscriber()
                {
                    sender = _appContext.Friends.FirstOrDefault(f =>
                        (f.PersonInputRequestId == userId && f.PersonOutputRequestId == targetId)).PersonOutputRequest,
                    target = _appContext.Friends.FirstOrDefault(f =>
                        (f.PersonInputRequestId == userId && f.PersonOutputRequestId == targetId)).PersonInputRequest,
                    senderId = _appContext.Friends.FirstOrDefault(f =>
                            (f.PersonInputRequestId == userId && f.PersonOutputRequestId == targetId))
                        .PersonOutputRequestId,
                    targetId = _appContext.Friends.FirstOrDefault(f =>
                        (f.PersonInputRequestId == userId && f.PersonOutputRequestId == targetId)).PersonInputRequestId
                });
                _appContext.Friends.Remove(_appContext.Friends.FirstOrDefault(f =>
                    (f.PersonInputRequestId == userId && f.PersonOutputRequestId == targetId)));

                _appContext.Friends.Remove(_appContext.Friends.FirstOrDefault(f =>
                    (f.PersonInputRequestId == targetId && f.PersonOutputRequestId == userId)));

            }*/
        



    }
}