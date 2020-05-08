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
                Friends1 = u.Friends1,
                Friends2 = u.Friends2,
                Id = u.Id,
                LikesPosts = u.LikesPosts,
                UserPosts = u.UserPosts
            };
        }
        public static Post BuildPost(PostModel p)
        {
            return new Post
            {
                date = p.date,
                ID = p.ID,
                LikesPosts = p.LikesPosts,
                owner = p.owner,
                rating = p.rating,
                text = p.text,
                UserPosts = p.UserPosts
            };
        }
    }
}