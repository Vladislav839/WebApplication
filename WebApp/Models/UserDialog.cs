namespace WebApp.Models
{
    public class UserDialog
    {
        public int UserId { get; set; }
        public int DialogId { get; set; }
        public UserModel User { get; set; }
        public DialogModel Dialog { get; set; }
    }
}