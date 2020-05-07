using System;
using System.Collections.Generic;
using System.Numerics;
using AuthApp.Controllers;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class User
    {
        public string NickName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Friend> Friends1 { get; set; }
        public List<Friend> Friends2 { get; set; }
        public List<UsersPost> UserPosts { get; set; }
        public List<LikesPost> LikesPosts { get; set; }  
        // public List<Subscribers> OutputFriendRequests { get; set; } = null; 
        // public List<Subscribers> Subscribers{ get; set; } = null;  

        public User()
        {
            Friends1 = new List<Friend>();
            Friends2 = new List<Friend>();
            UserPosts = new List<UsersPost>();
            LikesPosts = new List<LikesPost>();
        }
        
        
        
        /*public void AcceptInputRequest(int subscriber_id)
          {
              Subscribers.Remove(subscriber_id);
              FriendsContext.Friends.Add(subscriber_id);
          }
          public void DeclineInputRequest(int subscriber_id)
          {
              
          }
        
          public void OutputRequestToFriend(int new_friend_id)
          {
              OutputFriendRequests.Remove(new_friend_id);
              FriendsContext.Friends.Add(new_friend_id);
          }
        
          public void FriendToSubscriber(int friend_id)
          {
              FriendsContext.Friends.Remove(friend_id);
              Subscribers.Add(friend_id);
          }
        
          public void SendRequest(int user_id)
          {
              if (Subscribers.Contains(user_id))
              {
                  AcceptInputRequest(user_id);
                  return;
              }
              
         }*/

}
}
