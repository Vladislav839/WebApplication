using System;
using System.Collections.Generic;
using System.Numerics;
using AuthApp.Controllers;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class User
    {
        public string NickName { get; set; }
        public int Id { get; set; }
        
        //public string birthday { get; set; }
        
        //public int age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public int subscribersQuantity { get; set; }
        public int subscriptionsQuantity { get; set; }

    }
}
