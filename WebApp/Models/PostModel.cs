using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    
    public class PostModel
    {
        public int Id{ get; set; }
        public string Text{ get; set; }
        public string Time{ get; set; }
        public int Rating { get; set; }
        //public List<LikePost> LikesPost { get; set; }
        
        public int OwnerId { get; set; }
        public UserModel Owner { get; set; }
        
    }
}