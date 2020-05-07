namespace WebApp.Models
{
    public class LikesPost
    {
        public User RatingPerson { get; set; }
        public int RatingPersonId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}