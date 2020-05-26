using System;

namespace WebApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int OwnerId { get; set; }
        public DateTime SendingTime { get; set; }
        public int OwnerDialogId { get; set; }
    }
}