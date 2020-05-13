using System.Collections.Generic;

namespace WebApp.Models
{
    public class Post
    {
        public int Id{ get; set; }
        public string Owner{ get; set; }
        public string Text{ get; set; }
        public string Time{ get; set; }
        public int rating { get; set; }
        public List<UserPost> UserPosts { get; set; }
        public List<LikePost> LikesPosts { get; set; }

        public Post()
        {
            UserPosts = new List<UserPost>();
            LikesPosts = new List<LikePost>();
        }
    }
}