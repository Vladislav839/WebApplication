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
        
        //public string birthday { get; set; }
        
        //public int age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Friend> Friends1 { get; set; }
        public List<Friend> Friends2 { get; set; }
        public List<UserPost> UserPosts { get; set; }
        public List<LikePost> LikesPosts { get; set; }  
        // public List<Subscribers> OutputFriendRequests { get; set; } = null; 
        // public List<Subscribers> Subscribers{ get; set; } = null;  

        public User()
        {
            Friends1 = new List<Friend>();
            Friends2 = new List<Friend>();
            UserPosts = new List<UserPost>();
            LikesPosts = new List<LikePost>();
        }
    }
}
