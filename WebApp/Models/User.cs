using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        public static int id = 0;
        public int Id { get; set; } = id;
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User()
        {
            id++;
        }
    }
}
