using System.Collections.Generic;

namespace WebApp.Models
{
    
    public class Post
    {
        public int ID{ get; set; }
        public int owner{ get; set; }
        public string text{ get; set; }
        public string date{ get; set; }
        public List<UsersPost> UserPosts { get; set; }
        public List<LikesPost> LikesPosts { get; set; }
    }
}