namespace WebApp.Models
{
    public class LikePost
    {
        public UserModel RatingPerson { get; set; }
        public int RatingPersonId { get; set; }
        public PostModel PostModel { get; set; }
        public int PostId { get; set; }
    }
}