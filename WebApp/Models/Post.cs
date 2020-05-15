using System.Collections.Generic;
using System.Dynamic;

namespace WebApp.Models
{
    public class Post
    {
        public int Id{ get; set; }
        public UserModel Owner{ get; set; }
        public int OwnerId { get; set; }
        public string Text{ get; set; }
        public string Time{ get; set; }
        public int rating { get; set; }
        //public List<LikePost> LikesPosts { get; set; }

        public Post()
        {
            //LikesPosts = new List<LikePost>();
        }
    }
}