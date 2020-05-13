using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    
    public class PostModel
    {
        public int ID{ get; set; }
        public string owner{ get; set; }
        public string text{ get; set; }
        public string date{ get; set; }
        public int rating { get; set; }
        public List<UserPost> UserPosts { get; set; }
        public List<LikePost> LikesPost { get; set; }
        
    }
}