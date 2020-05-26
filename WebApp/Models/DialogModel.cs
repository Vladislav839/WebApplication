using System.Collections.Generic;

namespace WebApp.Models
{
    public class DialogModel
    {
        public int Id { get; set; }
        public List<UserDialog> UsersDialogs { get; set; }
        public int FirstPersonId { get; set; }
        public int SecondPersonId { get; set; }
    }
}