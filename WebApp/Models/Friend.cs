namespace WebApp.Models
{
    public class Friend
    {
        public int Person1Id { get; set; }
        public User Person1{ get; set; }
            
        public int Person2Id{ get; set; }
        public User Person2{ get; set; }
    }
}