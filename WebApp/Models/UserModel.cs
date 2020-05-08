using System.Collections.Generic;

namespace WebApp.Models
{
    public class UserModel
    {
        public string NickName { get; set; }
        //public string birthday { get; set; }
        //public int age { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Friend> Friends1 { get; set; }
        public List<Friend> Friends2 { get; set; }
        public List<UserPost> UserPosts { get; set; }
        public List<LikePost> LikesPosts { get; set; } 
    }
}