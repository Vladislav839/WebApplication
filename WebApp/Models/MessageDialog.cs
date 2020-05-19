namespace WebApp.Models
{
    public class MessageDialog
    {
        public int MessageId { get; set; }
        public int DialogId { get; set; }
        public Message Message { get; set; }
        public Dialog Dialog { get; set; }
    }
}