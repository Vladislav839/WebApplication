using System.Dynamic;

namespace WebApp.Models
{
    public class UsersPost
    {
        public int OwnerId { get; set; }
        public User Owner { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }

    }
}