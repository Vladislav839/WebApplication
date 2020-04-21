using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Repository
    {
        private static List<User> users = new List<User>();
        public static IEnumerable<User> Users
        {
            get
            {
                return users;
            }
        }
        public static void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
