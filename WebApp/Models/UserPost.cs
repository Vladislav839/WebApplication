using System.Dynamic;

namespace WebApp.Models
{
    public class UserPost
    {
        public int OwnerId { get; set; }
        public User Owner { get; set; }
        public PostModel PostModel { get; set; }
        public int PostId { get; set; }
        
    }
}