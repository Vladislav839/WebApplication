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
                FriendsOut = u.Friends1,
                FriendsIn = u.Friends2,
                Id = u.Id,
                LikesPosts = u.LikesPosts,
                UserPosts = u.UserPosts,
                InputSubscriptions = u.InputSubscriptions,
                OutputSubcriptions = u.OutputSubscribtions
                // age = u.age,
                //birthday = u.birthday
            };
        }
        public static Post BuildPost(PostModel p)
        {
            return new Post
            {
                Time = p.date,
                Id = p.ID,
                LikesPosts = p.LikesPost,
                Owner = p.owner,
                rating = p.rating,
                Text = p.text,
                UserPosts = p.UserPosts
            };
        }
        
    }
}