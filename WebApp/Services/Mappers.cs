using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Services
{
    public static class Mappers
    {
        public static User BuildUser(UserModel u)
        {
            return new User
            {
                NickName = u.NickName,
                Password = u.Password,
                Email = u.Email,
                //FriendsOut = u.Friends1,
                //FriendsIn = u.Friends2,
                Id = u.Id,
                Path = u.Path,
                //LikesPosts = u.LikesPosts,
                //InputSubscriptions = u.InputSubscriptions,
                //OutputSubcriptions = u.OutputSubscribtions,
                //Posts = u.Posts
                // age = u.age,
                //birthday = u.birthday
            };
        }

        public static User BuildUserInformation(UserModel u)
        {
            return new User
            {
                NickName = u.NickName,
                //Password = u.Password,
                Email = u.Email,
                //FriendsOut = u.Friends1,
                //FriendsIn = u.Friends2,
                Id = u.Id,
                Path = u.Path
                //LikesPosts = u.LikesPosts,
                //InputSubscriptions = u.InputSubscriptions,
                //OutputSubcriptions = u.OutputSubscribtions,
                //Posts = u.Posts
                // age = u.age,
                //birthday = u.birthday
            };
        }
        public static Post BuildPost(PostModel p)
        {
            return new Post
            {
                Time = DateTime.Parse(p.Time),
                Id = p.Id,
                //LikesPosts = p.LikesPost,
                Owner = BuildUserInformation(p.Owner),
                rating = p.Rating,
                Text = p.Text,
                OwnerId = p.OwnerId
            };
        }
        
    }
}