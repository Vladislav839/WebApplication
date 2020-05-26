using System;
using System.Collections.Generic;
using System.Dynamic;

namespace WebApp.Models
{
    public class Post
    {
        public int Id{ get; set; }
        public User Owner{ get; set; }
        public int OwnerId { get; set; }
        public string Text{ get; set; }
        public DateTime Time{ get; set; }
        public int Rating { get; set; }
    }
}