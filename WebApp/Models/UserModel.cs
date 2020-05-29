using System.Collections.Generic;
using System.Dynamic;

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
        public string Path { get; set; }
        public List<PostModel> Posts { get; set; }
        public List<Subscriber> InputSubscriptions { get; set; }
        public List<Subscriber> OutputSubscribtions { get; set; }
        public List<LikePost> LikesPost { get; set; }
        public int subscribersQuantity { get; set; }
        public int subscriptionsQuantity { get; set; }
        public List<UserDialog> UserDialogs { get; set; }
    }
}