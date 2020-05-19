using System.Collections.Generic;

namespace WebApp.Models
{
    public class DialogModel
    {
        public int DialogId { get; set; }
        public int FirstPersonId { get; set; }
        public int SecondPersonId { get; set; }
        public List<MessageModel> Messages { get; set; }
    }
}